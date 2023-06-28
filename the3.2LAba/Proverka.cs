using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The3rdLaba
{
    public class Proverka
    {
        public double _a = 0.0;
        public double _b = 0.0;

        public double b
        {
            get { return _b; }
            set
            {
                if (value == 0)
                    throw new Exception("Нулевое значение b недопустимо!");
                else
                    _b = value;
            }
        }

        public double a
        {
            get { return _a; }
            set
            {
                if (value == 0)
                    throw new Exception("Нулевое значение а недопустимо!");
                else
                    _a = value;


            }
        }

        //public double Res()
        //{
       //     return (a - b) / (a * b);
        //}
    }

    public class Result : Proverka
    {
        public int _d = 0;
        double s = 0;

        public int d
        {
            get { return _d; }
            set
            {
                if (value >= a)
                    throw new Exception("Значение d недопустимо !");
                else
                    _d = value;
            }
        }
        public double Otvet()
        {
            
            for(int i = 0; i < d; i++)
            {
                s = s + i / (a - d) / (a * b);
            }
            return s;
        }
    }
}
