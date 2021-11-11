using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // FormatException : 잘못된 Format
                
                int iCheck = int.Parse(textBox1.Text);
                //int iCheck = 0;
                //if (int.TryParse(textBox1.Text, out iCheck))
                //{
                //    iCheck = int.Parse(textBox1.Text);
                //}
                //else label1.Text = "Data Form이 맞지 않습니다.";

                // ArgumentException : list 범위 벗어남

                string strTest = string.Empty;
                List<string> lStringCheck = new List<string>();
                lStringCheck.Add("Test1");

                for (int i = 0; i < 2; i++)
                {
                    strTest = lStringCheck[i];
                }
                //foreach(string istrTest in lStringCheck)
                //{
                //    strTest = istrTest;
                //}

                // NullReferenceException : 값이 없음 (null)

                List<object> lObject = null;
                object oRet = lObject[0];
                //if (lObject != null)
                //{
                //    object oRet = lObject[0];
                //}
                //else label1.Text = "lObject에 값이 없습니다.";

                // InvalidCastException : 잘못된 타입 cast

                object oCheck = "check";
                int iCastCheck = (int)oCheck;
                //if(oCheck is int)
                //{
                //    int iCastCheck = (int)oCheck;
                //}
                //else label1.Text = "잘못된 명시적 cast입니다.";

            }
            catch (FormatException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (ArgumentException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (NullReferenceException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (InvalidCastException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (SystemException ex)  // 부모 exception
            {
                label1.Text = ex.ToString();
            }
            catch (Exception ex)    // 최상위 부모 exception
            {
                label1.Text = ex.ToString();
            }
            finally
            {
                label1.Text = "함수를 완료하기 전 무조건 실행";
            }
        }
    }
}
