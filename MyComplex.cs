using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{


    class MyComplex
    {

        double[] index = new double[2];
        public double r
        {
            get { return index[0]; }
            set { index[0] = value; }
        }

        public double i
        {
            get { return index[1]; }
            set { index[1] = value; }
        }

        public MyComplex() { }
        public MyComplex(double r,double i)
        {
            index[0] = r;
            index[1] = i;
        }

        public double this[char x]
        {
            get
            {
                if (x == 'r')
                {
                    return index[0];
                }
                if (x == 'i')
                {
                    return index[1];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (x == 'r')
                {
                    index[0] = value;
                    return;
                }
                if (x == 'i')
                {
                    index[1] = value;
                    return;
                }
            }
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            MyComplex result = new MyComplex();
            result['r'] = a['r'] + b['r'];
            result['i'] = a['i'] + b['i'];
            return result;
        }

        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            MyComplex result = new MyComplex();
            result['r'] = a['r'] - b['r'];
            result['i'] = a['i'] - b['i'];
            return result;
        }

        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            MyComplex result = new MyComplex();
            result['r'] = a['r'] * b['r'] - a['i'] * b['i'];
            result['i'] = a['r'] * b['i'] + b['r'] * a['i'];
            return result;
        }

        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            MyComplex result = new MyComplex();
            result['r'] = (a['r'] * b['r'] + a['i'] * b['i']) / (b['r'] * b['r'] + b['i'] * b['i']);
            result['i'] = (b['r'] * a['i'] - a['r'] * b['i']) / (b['r'] * b['r'] + b['i'] * b['i']);
            return result;
        }
    }
}
