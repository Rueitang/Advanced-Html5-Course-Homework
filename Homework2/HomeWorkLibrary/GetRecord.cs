using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLibrary
{   //由0~9取出四個不同數字
    public class GetRecord
    {
        private Random 亂數 = new Random();//亂數種子

        public int limitUp = 10;
        public int limitLow = 0;
        public int[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //利用抽取陣列的資料來避免重覆取出
        public int[] GetNumber()
        {
            int[] getData = new int[4];
            int itsUp = limitUp;

            for (int timer2 = 0; timer2 < data.LongLength; timer2++)          //資料初始化
            {
                data[timer2] = timer2;
            }

            for (int timer1 = 0; timer1 < getData.Length; timer1++, itsUp--)
            {
                int 選出 = 亂數.Next(limitLow, itsUp);
                getData[timer1] = data[選出];                                 //回傳亂數

                for (int timer2 = 選出; timer2 < data.Length - 1; timer2++)      //整理資料陣列
                {
                    選出 = timer2 + 1;
                    if (選出 < data.Length)
                        data[timer2] = data[選出++];
                }
            }
            return getData;                                                   //回傳值
        }
    }
}