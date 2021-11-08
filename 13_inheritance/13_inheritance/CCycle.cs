using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_inheritance
{
    class CCycle : CBase
    {
        public Rectangle _rtSquare1;    // 몸통
        public Rectangle _rtCircle1;    // 바퀴1
        public Rectangle _rtCircle2;    // 바퀴2

        public CCycle(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.Black, 3);

            _rtSquare1 = new Rectangle(60,90,240,60);
            _rtCircle1 = new Rectangle(30,150,120,120);
            _rtCircle2 = new Rectangle(210, 150, 120, 120);
        }

        public Pen penInfo()
        {
            return _pen;
        }

        /// <summary>
        /// 외부에서 호출 가능하도록 
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
            fSquare1Move(iMove);
        }

        /// <summary>
        /// 내부에서만 움직인다.
        /// </summary>
        protected void fCircle1Move(int iMove)
        {
            Point p = _rtCircle1.Location;
            p.X = p.X + iMove;
            _rtCircle1.Location = p;
        }
        protected void fCircle2Move(int iMove)
        {
            Point p = _rtCircle2.Location;
            p.X = p.X + iMove;
            _rtCircle2.Location = p;
        }
        protected void fSquare1Move(int iMove)
        {
            Point p = _rtSquare1.Location;
            p.X = p.X + iMove;
            _rtSquare1.Location = p;
        }
    }
}
