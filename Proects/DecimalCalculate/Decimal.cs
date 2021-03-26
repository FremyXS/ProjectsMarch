using System;
using System.Collections.Generic;
using System.Text;

namespace DecimalCalculate
{
    public class Decimal
    {
        private int num;
        private int denum;
        public Decimal(string dec)
        {
            string[] msDec = dec.Split(new char[] { '/' });

            this.num = int.Parse(msDec[0]);
            this.denum = int.Parse(msDec[1]);
        }
        public static Decimal operator +(Decimal one, Decimal two)
        {
            int num; int denum;

            if (one.denum != two.denum)
            {
                num = one.num * two.denum + two.num * one.denum;
                denum = one.denum * two.denum;
            }
            else
            {
                num = one.num + two.num;
                denum = one.denum;
            }

            return new Decimal($"{num}/{denum}");

        }
        public static Decimal operator -(Decimal one, Decimal two)
        {
            int num; int denum;

            if (one.denum != two.denum)
            {
                num = one.num * two.denum - two.num * one.denum;
                denum = one.denum * two.denum;
            }
            else
            {
                num = one.num - two.num;
                denum = one.denum;
            }

            return new Decimal($"{num}/{denum}");

        }
        public static Decimal operator *(Decimal one, Decimal two)
        {
            int num = one.num * two.num;
            int denum = one.denum * two.denum;

            return new Decimal($"{num}/{denum}");
        }
        public static Decimal operator /(Decimal one, Decimal two)
        {
            int num = one.num * two.denum;
            int denum = one.denum * two.num;

            return new Decimal($"{num}/{denum}");
        }
        public override string ToString()
        {
            return $"{num}/{denum}";
        }
    }
}
