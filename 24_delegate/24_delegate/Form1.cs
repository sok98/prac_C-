using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_delegate
{
    public partial class Form1 : Form
    {
        public delegate int delFunc_Dow_Edge(int i);
        public delegate int delFunc_Topping(string s, int i);
        int _totalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            delFunc_Dow_Edge delDow = new delFunc_Dow_Edge(fDow);
            delFunc_Dow_Edge delEdge = new delFunc_Dow_Edge(fEdge);

            delFunc_Topping delTopping = null;

            int iDow = 0;
            int iEdge = 0;

            if (rbtnDow1.Checked) iDow = 1;
            else if (rbtnDow2.Checked) iDow = 2;

            if (rbtnEdge1.Checked) iEdge = 1;
            else if (rbtnEdge2.Checked) iEdge = 2;

            //delDow(iDow);
            //delEdge(iEdge);

            fCallBackDelegate(iDow, delDow);
            fCallBackDelegate(iEdge, delEdge);

            if (cboxTopping1.Checked || cboxTopping2.Checked || cboxTopping3.Checked)
            {
                if (cboxTopping1.Checked) delTopping += fTopping1;
                if (cboxTopping2.Checked) delTopping += fTopping2;
                if (cboxTopping3.Checked) delTopping += fTopping3;

                delTopping("토핑", (int)numEA.Value);
            }

            lboxOrder.Items.Add("-------------------------------");
            lboxOrder.Items.Add($"총 가격 : {_totalPrice} 원");
            lboxOrder.Items.Add("-------------------------------");
        }

        #region Function
        /// <summary>
        /// 0 : 선택 안함, 1 : 오리지널, 2 : 씬
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우 : 오리지널 ({0}원)", iPrice);
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우 : 씬 ({0}원)", iPrice);
            }
            else
            {
                strOrder = string.Format("도우 : 선택 안함");
            }

            lboxOrder.Items.Add(strOrder);
            _totalPrice += iPrice;

            return _totalPrice;
        }
        /// <summary>
        /// 0 : 선택 안함, 1 : 리치골드, 2 : 치즈크러스트
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지 : 리치골드 ({0}원)", iPrice);
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("엣지 : 치즈크러스트 ({0}원)", iPrice);
            }
            else
            {
                strOrder = string.Format("엣지 : 선택 안함");
            }

            flboxOrderAdd(strOrder);
            _totalPrice += iPrice;

            return _totalPrice;
        }
        /// <summary>
        /// 토핑 소세지 선택
        /// </summary>
        /// <param name="Order"></param>
        /// <param name="iEa"></param>
        /// <returns></returns>
        private int fTopping1(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 500;

            strOrder = string.Format("{0} : 소세지 {1}개 선택 -> {2}원 (1EA 500원)", Order, iEa, iPrice);

            flboxOrderAdd(strOrder);
            _totalPrice += iPrice;

            return _totalPrice;
        }
        /// <summary>
        /// 토핑 감자 선택
        /// </summary>
        /// <param name="Order"></param>
        /// <param name="iEa"></param>
        /// <returns></returns>
        private int fTopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;

            strOrder = string.Format("{0} : 감자 {1}개 선택 -> {2}원 (1EA 200원)", Order, iEa, iPrice);

            flboxOrderAdd(strOrder);
            _totalPrice += iPrice;

            return _totalPrice;
        }
        /// <summary>
        /// 토핑 치즈 선택
        /// </summary>
        /// <param name="Order"></param>
        /// <param name="iEa"></param>
        /// <returns></returns>
        private int fTopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;

            strOrder = string.Format("{0} : 치즈 {1}개 선택 -> {2}원 (1EA 300원)", Order, iEa, iPrice);

            flboxOrderAdd(strOrder);
            _totalPrice += iPrice;

            return _totalPrice;
        }

        private void flboxOrderAdd(string strOrder)
        {
            lboxOrder.Items.Add(strOrder);
        }

        public int fCallBackDelegate(int i, delFunc_Dow_Edge dFunc)
        {
            return dFunc(i);
        }
        #endregion
    }
}