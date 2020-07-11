using System;

namespace CalcoloMisteriosoMetodo
{
    public class Calcolo
    {
        public static double CalcoloMisterioso(double[] v)
        {
            double s = 0;
            if (v.Length == 0)
                s = double.NaN;
            else
            {
                for (int i = 0; i < v.Length; i++)
                s = s + v[i];
            }
            return s;
        }
    }
}
