using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_inheritance
{
    class COneCycle : CBase
    {
        public Rectangle _rtSquare1;    // 몸통1
        public Rectangle _rtCircle1;    // 바퀴1

        public COneCycle(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.WhiteSmoke, 3);

            _rtSquare1 = new Rectangle(150, 30, 60, 120);
            _rtCircle1 = new Rectangle(120, 150, 120, 120);
        }

        public Pen penInfo()
        {
            return _pen;
        }

        public Pen penInfo(Color oColor)
        {
            _pen = new Pen(oColor);
            return _pen;
        }

            public Pen penInfo(Color oColor, int w)
        {
            _pen = new Pen(oColor, w);
            return _pen;
        }

        /// <summary>
        /// 외부에서 호출 가능하도록 
        /// </summary>
        /// <param name="iMove"></param>
        public virtual void fMove(int iMove)
        {
            fCircle1Move(iMove);
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
        protected void fSquare1Move(int iMove)
        {
            Point p = _rtSquare1.Location;
            p.X = p.X + iMove;
            _rtSquare1.Location = p;
        }
    }
}
