﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0330
{
    class Program
    {
        static void Main(string[] args)
        {
            // 資料陣列
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string [] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };

            // 宣告變數
            int Acount = 0, Bcount = 0, Ocount = 0, ABcount = 0;
            double Ah = 0, Bh = 0, Oh = 0, ABh = 0;
            int sum = 0, boysum = 0, girlsum = 0, ga = 0, ba= 0, all = 0;
            int max = -99999;
            int min = 99999;

            // 迴圈計算資料
            for (int i = 0; i < gender.Length; i++)
            {
                // 辨別血型
                if(blood[i] == "A")
                {
                    Acount += 1;
                    Ah = (Acount / (double) blood.Length) *100;
                }

                if (blood[i] == "B")
                {
                    Bcount += 1;
                    Bh = (Bcount / (double)blood.Length) * 100;
                }

                if (blood[i] == "O")
                {
                    Ocount += 1;
                    Oh = (Ocount / (double)blood.Length) * 100;
                }

                if (blood[i] == "AB")
                {
                    ABcount += 1;
                    ABh = (ABcount / (double)blood.Length) * 100;
                }

                // 設置身高正常範圍
                if (height[i] > 100 && height[i] < 200)
                {
                    // 計算全班身高總和平均
                    all += 1;
                    sum += height[i];

                    // 計算女生身高總和平均
                    if (gender[i] == "女")
                    {
                        ga += 1;
                        girlsum += height[i];
                    }

                    // 計算男生身高總和平均
                    if (gender[i] == "男")
                    {
                        ba += 1;
                        boysum += height[i];
                    }

                    // 計算最高身高
                    if (height[i] > max)
                    {
                        max = height[i];
                    }

                    // 計算最低身高
                    if (height[i] < min)
                    {
                        min = height[i];
                    }
                }

            }

            // 顯示結果
            Console.WriteLine("A型人數: {0} {1:0}%" , Acount, Ah);
            Console.WriteLine("B型人數: {0} {1:0}%" , Bcount, Bh);
            Console.WriteLine("O型人數: {0} {1:0}%", Ocount, Oh);
            Console.WriteLine("AB型人數: {0} {1:0}%", ABcount, ABh);

            Console.WriteLine("全班身高總和:" + sum);
            Console.WriteLine("全班身高平均:" + (sum / all));

            Console.WriteLine("女生身高總和:" + girlsum);
            Console.WriteLine("女生身高平均:" + (girlsum / ga));

            Console.WriteLine("男生身高總和:" + boysum);
            Console.WriteLine("男生身高平均:" + (boysum / ba));

            Console.WriteLine("全班最高身高為:" + max);
            Console.WriteLine("全班最低身高為:" + min);

            // 防止視窗自動關閉
            Console.ReadLine();
        }
    }
}
