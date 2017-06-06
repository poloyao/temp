using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemo.ViewModel
{
    class demoTest
    {




        public void Test()
        {
            double d = 80.24;
            int id = (int)d;//强制转换

            double di = id; //隐式转换

            double di2 = (int)d; //强制转换为int后再隐式转换为double;
            double di3 = d;      //跟上一步进行对比。


        }


        public void Test2()
        {
            int i = 10;
            object obj = i; //装箱操作


            int i2 = (int)obj; //拆箱操作
            
        }

        public void Test3()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.ForEach(x => { Console.WriteLine(x); });
        }

        public void Test4()
        {
            if (1 == 2)
            { }
            else if (1 == 3)
            { }
            else
            { }
        }

        public void Test5()
        {
            int temp = 0;
            switch (temp)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        public void Test6()
        {
            while (true)
            {

            }

            do
            {

            } while (true);

            foreach (var item in "asdasda")
            {

            }
        }

        public void Test7()
        {
            do
            {

            } while (true);
        }


    }
}
