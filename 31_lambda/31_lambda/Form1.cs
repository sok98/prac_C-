using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Action _stepCheck = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            _stepCheck = () => lblStepCheck.Text = string.Format("- 다음 Step은 {0}. {1}", iNowStep, ((enumLambdaCase)iNowStep).ToString());
            _stepCheck();
            ButtonColorChange();
        }

        private void ButtonColorChange()
        {
            // Event 함수 호출
            btn1.Click += Btn1_Click;

            // 무명 메소드 사용
            btn2.Click += delegate (object sender, EventArgs e)
            {
                btn2.BackColor = Color.Red;
            };

            // 람다식 사용
            btn3.Click += (sender, e) => btn3.BackColor = Color.Coral;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Aqua;
        }

        int iNowStep = 0;
        delegate int delIntFunc(int a, int b);
        delegate string delStringFunc();

        private void btnNext_Click(object sender, EventArgs e)
        {
            Lambda(iNowStep);
            iNowStep++;
            _stepCheck();
        }

        private void Lambda(int iCase)
        {
            delIntFunc dInt;
            int iRet = 0;

            delStringFunc dStr;
            string strRet = string.Empty;

            switch (iCase)
            {
                case (int)enumLambdaCase.식형식_람다식:
                    dInt = (a, b) => a * b;
                    iRet = dInt(4, 5);
                    lboxResult.Items.Add(iCase + ")" + iRet.ToString());

                    dStr = () => string.Format("Lambda Sample 식형식");
                    strRet = dStr();
                    lboxResult.Items.Add(iCase + ")" + strRet);
                    break;

                case (int)enumLambdaCase.문형식_람다식:
                    dStr = () =>
                    {
                        return string.Format("Lambda Sample 문형식");
                    };
                    strRet = dStr();
                    lboxResult.Items.Add(iCase + ")" + strRet);
                    break;

                case (int)enumLambdaCase.제네릭_형태의_무명메소드_Func:
                    Func<int, int, int> fInt = (a, b) => a * b;
                    iRet = fInt(3, 5);
                    lboxResult.Items.Add(iCase + ")" + iRet.ToString());
                    break;

                case (int)enumLambdaCase.제네릭_형태의_무명메소드_Action:
                    Action<string, string> aString = (a, b) =>
                    {
                        strRet = string.Format($"인자 값 {a}와 {b}를 받았습니다.");
                        lboxResult.Items.Add(iCase + ")" + iRet.ToString());
                    };
                    aString("시간", "금");
                    break;

                case (int)enumLambdaCase.제네릭_형태의_인자_반환:
                    int[] iGroup = { 1, 3, 5, 7, 9 };
                    int iCount = iGroup.Sum(x => x);
                    lboxResult.Items.Add(iCase + ")" + iCount.ToString());
                    break;
            }
        }

        enum enumLambdaCase
        {
            식형식_람다식 = 0,
            문형식_람다식 = 1,
            제네릭_형태의_무명메소드_Func = 2,
            제네릭_형태의_무명메소드_Action = 3,
            제네릭_형태의_인자_반환 = 4,
        }
    }
}
