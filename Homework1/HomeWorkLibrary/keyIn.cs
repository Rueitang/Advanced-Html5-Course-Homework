using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLibrary
{
    public class keyIn
    {
        public string keyText;
        public string showText;
        public int keyNumber;

        public bool addText()
        {
            //  bool keyError = false ;
            if (showText.Length < 4)
            {
                showText = showText + keyText;      //文字串連
                return true;                       //回傳成功
            }
            else
                return false;                        //回傳失敗
        }
    }
}