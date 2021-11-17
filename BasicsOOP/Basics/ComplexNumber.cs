namespace BasicsOOP.Basics
{
    public class ComplexNumber
    {
        public ComplexNumber(int re, int im)
        {
            Re = re;
            Im = im;
        }

        public int Re { get; }
        public int Im { get; }

        //==
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1?.Re == c2?.Re &&
                   c1?.Im == c2?.Im;
        }

        //!=
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }

        //+
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        //-
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re - c2.Re, c1.Im - c2.Im);
        }
        //*
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(
                c1.Re * c2.Re - c1.Im * c2.Im, 
                c1.Re * c2.Im + c1.Im * c2.Re);
        }

        public override string ToString()
        {
            return Im > 0 ? $"{Re}+{Im}*i" : $"{Re}{Im}*i";
        }
    }
}
