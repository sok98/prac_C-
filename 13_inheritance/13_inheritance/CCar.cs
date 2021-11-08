﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_inheritance
{
    class CCar : CCycle
    {
        public Rectangle _rtSquare2;  // 몸통2

        public CCar(string sName) : base(sName)
        {
            strName = sName;
            _pen = new Pen(Color.Blue, 3);

            _rtSquare1 = new Rectangle(90,30,180,90);
            _rtSquare2 = new Rectangle(30,120,300,60);
            _rtCircle1 = new Rectangle(60,180,90,90);
            _rtCircle2 = new Rectangle(210,180,90,90);
        }

        public override void fMove(int iMove)
        {
            base.fMove(iMove);
            fSquare2Move(iMove);
        }

        protected void fSquare2Move(int iMove)
        {
            Point p = _rtSquare2.Location;
            p.X = p.X + iMove;
            _rtSquare2.Location = p;
        }
    }
}
