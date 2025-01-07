namespace MathsLib
{
    public class Maths1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mult(int x, int y) 
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if(x == 0)
            {
                return -1;
            }

            return y / x;
        }


    }
}
