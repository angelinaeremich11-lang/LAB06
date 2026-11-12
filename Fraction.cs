using System;

namespace LAB06
{
    public class Fraction
    {
        private int integerPart;
        public int IntegerPart
        {
            get { return integerPart; }
            set { integerPart = value; }
        }
        private int fractionalPart;
        public int FractionalPart
        {
            get { return fractionalPart; }
            set
            {
                if (value < 0 || value > 999)
                {
                    throw new ArgumentException("Дробная часть должна быть в диапазоне от 0 до 999");
                }
                fractionalPart = value;
            }
        }
        public Fraction(int integerPart, int fractionalPart)
        {
            IntegerPart = integerPart;
            FractionalPart = fractionalPart;
        }
        public Fraction(int integerPart)
        {
            IntegerPart = integerPart;
            FractionalPart = 0;
        }
        public override string ToString()
        {
            return $"{IntegerPart}.{FractionalPart:D3}";
        }
        private long ToThousandths()
        {
            return IntegerPart * 1000L + FractionalPart;
        }
        private static Fraction FromThousandths(long value)
        {
            int intPart = (int)(value / 1000);
            int fracPart = (int)(value % 1000);
            if (fracPart < 0)
            {
                fracPart += 1000;
                intPart -= 1;
            }
            return new Fraction(intPart, fracPart);
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long total = f1.ToThousandths() + f2.ToThousandths();
            return FromThousandths(total);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long total = f1.ToThousandths() - f2.ToThousandths();
            return FromThousandths(total);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            long total = (f1.ToThousandths() * f2.ToThousandths()) / 1000L;
            return FromThousandths(total);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            long v1 = f1.ToThousandths();
            long v2 = f2.ToThousandths();

            if (v2 == 0)
            {
                throw new DivideByZeroException("Деление на ноль недопустимо");
            }
            long total = (v1 * 1000L) / v2;
            return FromThousandths(total);
        }
    }
}