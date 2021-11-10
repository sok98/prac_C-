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

namespace _24_delegate
{
    public partial class FormPizza : Form
    {

        public delegate int delPizzaComplete(string strResult, int iTime);
        public event delPizzaComplete eventdelPizzaComplete; // delegate event 선언

        public FormPizza()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void fPizzaCheck(Dictionary<string, int> dPizzaOrder)
        {
            int totalTime = 0;
            foreach (KeyValuePair<string, int> order in dPizzaOrder)
            {
                int nowTime = 0;
                string strType = string.Empty;

                switch (order.Key)
                {
                    // 도우
                    case "오리지널":
                        nowTime = 1000;
                        strType = "도우";
                        break;
                    case "씬":
                        nowTime = 900;
                        strType = "도우";
                        break;
                    
                    // 엣지
                    case "리치골드":
                        nowTime = 300;
                        strType = "엣지";
                        break;
                    case "치즈크러스트":
                        nowTime = 400;
                        strType = "엣지";
                        break;
                    
                    // 토핑
                    case "소세지":
                        nowTime = 30;
                        strType = "토핑";
                        break;
                    case "감자":
                        nowTime = 20;
                        strType = "토핑";
                        break;
                    case "치즈":
                        nowTime = 40;
                        strType = "토핑";
                        break;
                }
                int iCnt = order.Value;
                int iTime = nowTime * iCnt;
                totalTime += iTime;
                lboxMake.Items.Add(string.Format("{0}) {1} : {2}초 ({3}초, {4}개)", strType, order.Key, iTime, nowTime, iCnt));

                Refresh();
                Thread.Sleep(nowTime);
            }

            int iRet = eventdelPizzaComplete("Pizza가 완성되었습니다.", 1000);
            if (iRet == 0)
            {
                lboxMake.Items.Add("-------------------------------");
                lboxMake.Items.Add("주문 완료 확인 !!!");
                lboxMake.Items.Add("-------------------------------");
            }
        }
    }
}
