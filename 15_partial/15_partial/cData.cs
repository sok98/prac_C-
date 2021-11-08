using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_partial
{
    /// <summary>
    /// 변수
    /// </summary>
    partial class cData
    {

        private string _strItem = string.Empty;
        private int _iRate = 0;
        private int _iCount = 0;
        private string _strErrorName = string.Empty;

        public string StrItem
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    _strErrorName = "물건이 선택되지 않았습니다.";
                else
                    _strItem = value;
            }
        }
        public int IRate
        {
            set
            {
                if (value > 20)
                    _strErrorName = "사장님만 가능한 할인 입니다.";
                else
                    _iRate = value;
            }
        }
        public int ICount
        {
            set
            {
                if (value == 0)
                    _strErrorName = "물품의 개수가 0개입니다.";
                else if (value > 5)
                    _strErrorName = "개별 물품은 5개 이상 살 수 없습니다.";
                else
                    _iCount = value;
            }
        }
        public string StrErrorName
        {
            get
            {
                return _strErrorName;
            }
        }
    }

    /// <summary>
    /// 변수 값 초기화
    /// </summary>
    partial class cData
    {
        public void fDataDefault()
        {
            _strItem = string.Empty;
            _iRate = 0;
            _iCount = 0;
            _strErrorName = string.Empty;
        }
    }

    /// <summary>
    /// 수식 계산
    /// </summary>
    partial class cData
    {
        public double fitemPrice()
        {
            double dPrice = 0;
            int itemPrice = 0;

            if (String.IsNullOrEmpty(_strErrorName))
            {
                itemPrice = (int)Enum.Parse(typeof(EnumItem), _strItem);
                dPrice = itemPrice - Math.Round((double)itemPrice * (double)_iRate / 100, 2);
            }

            return dPrice * _iCount;
        }

        private double _dTotalPrice = 0.0;
        public double DTotalPrice
        {
            get { return _dTotalPrice; }
            set
            {
                _dTotalPrice += value;
            }
        }

    }
    /// <summary>
    ///  문자열
    /// </summary>
    partial class cData
    {
        public string fResult(double dPrice)
        {
            if (_iRate == 0)    // 할인 받지 않음
                return string.Format("{0} X {1} = {2}원", _strItem, _iCount, dPrice);
            else
                return string.Format("{0} X {1} = {2}원 (할인율 : {3}%)", _strItem, _iCount, dPrice, _iRate);
        }
    }


}
