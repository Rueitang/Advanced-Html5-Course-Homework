using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLibrary
{   //由0~9取出四個不同數字
    public class GetCode
    {
        private Random 亂數 = new Random();//亂數種子

        public int limitUp = 10;
        public int limitLow = 0;

        //判斷是否重覆取得亂數，若有重覆就再重取亂數
        public int[] GetNumber()
        {
            int[] getData = new int[4];
            bool get0 = false;
            //         int sendNumber;

            for (int timer1 = 0; timer1 < getData.Length; timer1++)
            {
                int 選出 = 亂數.Next(this.limitLow, limitUp);    //取得亂數
                getData[timer1] = 選出;

                if (getData[timer1] == 0)                   //第一次取0
                    if (get0 == true)
                        timer1--;                           //重取亂數
                    else
                        get0 = true;                        //記憶得0

                if (timer1 > 0)                             //第二次以上
                    for (int timer2 = 0; timer2 < timer1; timer2++)
                    {
                        if (選出 == getData[timer2])        //比較重覆數字
                        {
                            timer2 = timer1;
                            timer1--;                       //重取亂數
                        }
                    }
            }
            return getData;                                 //回傳值
        }
    }
}