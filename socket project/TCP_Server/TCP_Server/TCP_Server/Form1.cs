using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
namespace TCP_Server
{
    public partial class Form1 : Form
    {

        //전역 변수 선언부
        TcpListener _tcpLitener;
        bool _open_flag = false;
        Thread _thread_listener;
        Thread _thread_receive;
        NetworkStream _ntstream;
        StreamReader _streader;
        StreamWriter _stwriter; 
        TcpClient _client;
     
        delegate void D_receive(string data); //델리게이트 다음번에 자세히 설명하겠음.

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_open_Click(object sender, EventArgs e)                                          //서버 오픈 버튼
        {
            try
            {
                if (!_open_flag)                                                                       //현재 접속중인지 아닌지 판단.(첫 접속일 경우 전역변수 선언부에서 false로 선언하였기때문에 접속중이 아님) 
                {
                    _tcpLitener = new TcpListener(IPAddress.Parse(tb_ip.Text), int.Parse(tb_port.Text));//텍스트 박스 값으로 TcpListener 생성 (int.parse 는 텍스트를 숫자화 하는 메서드)
                    _tcpLitener.Start();                                                                //TcpListener 시작
                    _open_flag = true;                                                                  //서버를 오픈하였기 때문에 오픈 플래그를 True로 변경
                    _thread_listener = new Thread(listener);                                            //listener메서드 스레드로 생성
                    _thread_listener.Start();                                                           //스레드 시작                
                    tb_recevie_text("서버가 시작되었습니다.\r\n");
                    bt_send.Enabled = true;
                    
                }
            }
            catch (Exception ex)                                                                      //에러    
            {
                _open_flag = false;                                                                     //실패할경우 오픈이 취소되었음으로 플래그를 false로 변경
                MessageBox.Show(ex.ToString());     //오류 보고  
            }
        }
        void listener()                                                                                 //접속 Client를 받아들이는 메소드
        {
            try
            {
                if (_open_flag)                                                                         //현재 오픈중인지 아닌지 판단
                {
                    _client = _tcpLitener.AcceptTcpClient();                                   //Client가 접속할경우 Client변수 생성
                    tb_recevie_text("Client가 접속하였습니다\r\n");
                    create_stream();                                                              //접속한 Client로 create_stream메소드 실행
                }
                else
                {
                    tb_recevie_text("서버가 열리지 않았습니다\r\n");
                }
            }
            catch(Exception ex)                                                                         //에러
            {
                _open_flag = false;                                                                     //실패할경우 오픈이 취소되었음으로 플래그를 false로 변경
                MessageBox.Show(ex.ToString());
            }
        }
        void create_stream()                                                            
        {
            try
            {
                _ntstream = _client.GetStream();                                                         //접속한 Client에서 networkstream 추출
                _client.ReceiveTimeout = 500;                                                            //Client의 ReceiveTimeout
                _streader = new StreamReader(_ntstream);                                                //추출한 networkstream으로 streamreader,writer 생성
                _stwriter = new StreamWriter(_ntstream);
                _thread_receive = new Thread(receive);                                                  //receive메서드 스레드로 생성
                _thread_receive.Start();                                                                //스레드 시작     
            }
            catch (Exception ex)                                                                        //에러
            {
                _open_flag = false;                                                                     //실패할경우 접속이 취소되었음으로 플래그를 false로 변경
                MessageBox.Show(ex.ToString());
            }
        }
        void receive()
        {
            try
            {
                while (_open_flag)                                                                         //현재 오픈중인지 아닌지 판단
                {
                    string _receive_data = _streader.ReadLine();                                           //streamreader의 한줄을 읽어들여 string 변수에 저장  
                    if (_receive_data == ("Client : 가위"))
                    {
                        tb_recevie_text("상대측이 가위를 냈습니다. 주먹을 냅니다.\r\n");
                        _stwriter.WriteLine("Server" + " : " + "주먹\r\n" + "패배하셨습니다. 풉\r\n");                           //StreamWriter 버퍼에 텍스트박스 내용 저장
                        _stwriter.Flush();
                        continue;
                    }
                    else if (_receive_data == ("Client : 주먹") || _receive_data == ("Client : 바위"))
                    {
                        tb_recevie_text("상대측이 바위를 냈습니다. 보를 냅니다.\r\n");
                        _stwriter.WriteLine("Server" + " : " + "보\r\n" + "패배하셨습니다. 풉\r\n");                           //StreamWriter 버퍼에 텍스트박스 내용 저장
                        _stwriter.Flush();
                        continue;
                    }

                    else if (_receive_data == ("Client : 보"))
                    {
                        tb_recevie_text("상대측이 바위를 냈습니다. 보를 냅니다.\r\n");
                        _stwriter.WriteLine("Server" + " : " + "가위\r\n" + "패배하셨습니다. 풉\r\n");                           //StreamWriter 버퍼에 텍스트박스 내용 저장
                        _stwriter.Flush();
                        continue;
                    }

                    else if (_receive_data != null)                                                             //데이터가 null이 아니면
                    {
                        tb_recevie_text(_receive_data);   
                    }
                }
                
            }
            catch (IOException)                                                                           //IO에러 (Timeout에러도 이쪽으로 걸림)                  
            {
                if (_open_flag)                                                                           //현재 접속중인지 아닌지 체크
                {
                    _thread_receive = new Thread(receive);                                                //접속중일 경우 receive메서드를 이용한 스레드 다시생성
                    _thread_receive.Start();
                }                                                                                         //접속중이 아닐경우 자연스럽게 스레드 정지
            }
            catch (Exception ex)                                                                          //그 밖의 에러
            {
                _open_flag = false;

                tb_recevie_text("클라이언트의 연결이 종료되었습니다\r\n다시 서버오픈을 시도합니다.\r\n"); 
                _tcpLitener.Stop();
                bt_open_Click(null, null);
            }
        }
        void tb_recevie_text(string data)                                                 //텍스트박스에 텍스트 추가하는 메서드
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new D_receive(tb_recevie_text), data);                         //델리게이트 관련 코드로 다음번에 간단히 다시 설명하겠습니다.
            }
            else
            {
                if (data != null)                                                         //data가 null이 아닐경우
                {
                    tb_receive.AppendText(data + "\r\n");                                 //텍스트박스에 데이터+개행문자 추가
                }
            }
        }
        private void bt_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (_open_flag)                                                        //현재 접속중인지 아닌지 체크
                {
                    if (tb_writeline.Text != string.Empty)                                //전송할 내용이 담긴 TextBox가 비었는지 체크
                    {
                        tb_receive.AppendText("Server" + " : " +tb_writeline.Text + "\r\n");
                        _stwriter.WriteLine("Server" + " : " + tb_writeline.Text);                           //StreamWriter 버퍼에 텍스트박스 내용 저장
                        _stwriter.Flush();                                                //StreamWriter 버퍼 내용을 스트림으로 전달
                        tb_writeline.Text = null;
                    }
                }
            }
            catch (Exception ex)                                                           //에러
            {
                _open_flag = false;                                                    //접속이 취소되었음으로 플래그를 false로 변경
                
                MessageBox.Show(ex.ToString());                                           //에러 내용 보고

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)                             //FormClosing 이벤트
        {
            if (_open_flag)
            {
	            if (_ntstream.CanRead )
	            {
	                _stwriter.WriteLine("Server" + "의 연결이 끊어졌습니다. ");                           //StreamWriter 버퍼에 텍스트박스 내용 저장
	                _stwriter.Flush();
	                _ntstream.Close();
	            }
	            _open_flag = false;          
            }
                                                                 //접속중인지 체크하는 _connect_flag를 false로 변경
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_receive_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_writeline_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
