using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_thread
{
    public partial class Play : Form
    {
        public delegate int delMessage(object sender, string strResult);
        public event delMessage eventdelMessage;

        Thread _thread = null;

        bool _threadStop = false;
        string _strName = string.Empty;
        public string StrName { get; set; }

        public Play()
        {
            InitializeComponent();
        }
        public Play(string strName)
        {
            InitializeComponent();
            lblName.Text = StrName = strName;
        }

        public void fThreadStart()
        {
            //_thread = new Thread(new ThreadStart(fRun));    // 방법 1. ThreadStart 델리게이트 타입 객체를 생성 후 함수를 넘김
            //_thread = new Thread(delegate () { fRun(); });  // 방법 2, 익명 메소드를 사용하여 생성 후 함수를 넘김

            _thread = new Thread(fRun);                       // 방법 3. 컴파일러에서 델리게이트 객체를 추론해서 생성 후 함수를 넘김
            _thread.Start();
        }
        public void fRun()
        {
            try
            {
                // UI Control이 자신이 만들어진 Thread가 아닌 다른 Thread에서 접근할 경우 Cross Thread가 발생
                int ivar = 0;
                Random rd = new Random();

                while (pbarPlayer.Value < 100 && !_threadStop)
                {
                    if (this.InvokeRequired)    // 요청한 Thread가 Main Thread에 있는 Control을 액세스할 수 있는지 확인
                    {
                        this.Invoke(new Action(delegate ()
                        {
                            ivar = rd.Next(1, 11);
                            pbarPlayer.Value = (pbarPlayer.Value + ivar > 100) ? 100 : pbarPlayer.Value + ivar;

                            lblProgress.Text = string.Format("진행 상황 표시: {0} % ", pbarPlayer.Value);

                        }));

                        Thread.Sleep(300);
                    }
                }
                if (!_threadStop) eventdelMessage(this, "완주!! (Thread Complete!)");
                else eventdelMessage(this, "중도 포기 ... (Thread Stop)");
            }
            catch (ThreadInterruptedException exInterrupt)
            {
                exInterrupt.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public void ThreadAbort()
        {
            if (_thread.IsAlive)
            {
                _thread.Abort();
            }
        }

        public void ThreadJoin()
        {
            if (_thread.IsAlive)
            {
                bool bThreadEnd = _thread.Join(2000);
            }
        }

        public void ThreaInterrupt()
        {
            if (_thread.IsAlive)
            {
                _thread.Interrupt();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ThreadAbort();
            if (_thread.IsAlive)
            {
                _threadStop = true;
            }
        }
    }
}
