
using System;
using System.Runtime.CompilerServices;

namespace BasicsOOP.Basics
{
    public class RationalNumber
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        //+
        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            var numerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
            var denominator = r1.Denominator * r2.Denominator;
            var (n, d) = ReduceFraction(numerator, denominator);
            return new RationalNumber(n, d);
        }

        //-
        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            var numerator = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
            var denominator = r1.Denominator * r2.Denominator;
            var (n, d) = ReduceFraction(numerator, denominator);
            return new RationalNumber(n, d);
        }

        //*
        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            var numerator = r1.Numerator * r2.Numerator;
            var denominator = r1.Denominator * r2.Denominator;
            var (n, d) = ReduceFraction(numerator, denominator);
            return new RationalNumber(n, d);
        }

        //div
        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            var numerator = r1.Numerator * r2.Denominator;
            var denominator = r1.Denominator * r2.Numerator;
            var (n, d) = ReduceFraction(numerator, denominator);
            return new RationalNumber(n, d);
        }

        //%
        public static RationalNumber operator %(RationalNumber r1, RationalNumber r2)
        {
            var div = r1 / r2;
            return GetFractionalPart(div);
        }

        //++
        public static RationalNumber operator ++(RationalNumber r)
        {
            return r + new RationalNumber(1, 1);
        }

        //--
        public static RationalNumber operator --(RationalNumber r)
        {
            return r - new RationalNumber(1, 1);
        }

        //==
        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            return r1?.Numerator == r2?.Numerator &&
                   r1?.Denominator == r2?.Denominator;
        }
        
        //!=
        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 == r2);
        }

        //<
        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
        }

        //>
        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator > r2.Numerator * r1.Denominator;
        }

        //<=
        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator <= r2.Numerator * r1.Denominator;
        }

        //>=
        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator >= r2.Numerator * r1.Denominator;
        }

        //float
        public static explicit operator float(RationalNumber r)
        {
            return (float)r.Numerator/r.Denominator;
        }

        //int
        public static explicit operator int(RationalNumber r)
        {
            return (int)r.Numerator / r.Denominator;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var compared = (RationalNumber)obj;
            return (Numerator == compared.Numerator)&&(Denominator == compared.Denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        private static (int numerator, int denominator) ReduceFraction(int numerator, int denominator)
        {
            var min = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
            var gcd = 1;
            for (int i = 1; i <= min; i++)
            {
                if (numerator % i == 0 && denominator % i == 0)
                    gcd = i;
            }

            numerator /= gcd;
            denominator /= gcd;

            return (numerator, denominator);
        }

        private static RationalNumber GetFractionalPart(RationalNumber r)
        {
            return r.Numerator > r.Denominator 
                ? new RationalNumber(r.Numerator - r.Denominator, r.Denominator) 
                : r;
        }
    }
}
