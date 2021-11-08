using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_struct
{
   

    class CPlayer
    {
        public int CardSum(int sun, int moon, int star)
        {
            return sun + moon + star;
        }

        public string resultText(int cnt, int sun, int moon, int star, int sum)
        {
            //cnt++;
            //cardSum = CardSum(sun, moon, star);
            return string.Format("{0}회) 해 : {1}, 달 : {2}, 별 : {3} => 합계는 {4}",
                cnt, sun, moon, star, sum);
        }

        public string PlayerPair(int cnt, int p1Sum, int p2Sum)
        {
            int iCheck = p1Sum - p2Sum;

            if (iCheck > 0)
            {
                return string.Format("{0} 회차 : Player1이 {1}만큼 큽니다.", cnt, iCheck);
            }
            else if (iCheck < 0)
            {
                return string.Format("{0} 회차 : Player2가 {1}만큼 큽니다.", cnt, -iCheck);
            }
            else
            {
                return string.Format("{0} 회차 : Player1와 Player2가 같습니다.", cnt);
            }
        }

        public string PlayerResult(int p1Sum, int p2Sum)
        {
            string strReturn = string.Empty;

            if (p1Sum > p2Sum)
                strReturn = "Player1이 이겼습니다.";
            else if (p1Sum < p2Sum)
                strReturn = "Player2가 이겼습니다.";
            else
               strReturn = "비겼습니다.";

            return strReturn;
        }
    }
}
