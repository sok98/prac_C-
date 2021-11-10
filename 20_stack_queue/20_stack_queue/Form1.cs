using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_stack_queue
{
    public partial class Form1 : Form
    {
        Queue<int> _Queue = new Queue<int>(6);
        Stack<int> _Stack = new Stack<int>(6);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iData = rd.Next(1, 101);

            // Queue
            if (_Queue.Count < 6)
                _Queue.Enqueue(iData);

            //Stack
            if (_Stack.Count < 6)
                _Stack.Push(iData);

            fQueueDataDisplay();
            fStackDataDisplay();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            // Queue 
            if (_Queue.Count > 0)
                _Queue.Dequeue();

            // Stack
            if (_Stack.Count > 0)
                _Stack.Pop();

            fQueueDataDisplay();
            fStackDataDisplay();
        }

        private void fQueueDataDisplay()
        {
            int[] iArr = _Queue.ToArray();
            Array.Resize(ref iArr, 6);

            lblQueue0.Text = (iArr[0] == 0) ? "" : iArr[0].ToString();
            lblQueue1.Text = (iArr[1] == 0) ? "" : iArr[1].ToString();
            lblQueue2.Text = (iArr[2] == 0) ? "" : iArr[2].ToString();
            lblQueue3.Text = (iArr[3] == 0) ? "" : iArr[3].ToString();
            lblQueue4.Text = (iArr[4] == 0) ? "" : iArr[4].ToString();
            lblQueue5.Text = (iArr[5] == 0) ? "" : iArr[5].ToString();
        }

        private void fStackDataDisplay()
        {
            int[] iArr = _Stack.ToArray();
            Array.Resize(ref iArr, 6);

            lblStack0.Text = (iArr[0] == 0) ? "" : iArr[0].ToString();
            lblStack1.Text = (iArr[1] == 0) ? "" : iArr[1].ToString();
            lblStack2.Text = (iArr[2] == 0) ? "" : iArr[2].ToString();
            lblStack3.Text = (iArr[3] == 0) ? "" : iArr[3].ToString();
            lblStack4.Text = (iArr[4] == 0) ? "" : iArr[4].ToString();
            lblStack5.Text = (iArr[5] == 0) ? "" : iArr[5].ToString();
        }
    }
}
