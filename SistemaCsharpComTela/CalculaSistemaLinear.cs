namespace SistemaCsharpComTela
{
    class CalculaSistemaLinear
    {
        public double[] Resolucao(double[,] a, double[] b)
        {
            double[] result = new double[b.Length];
            result[b.Length - 1] = b[b.Length - 1] / a[b.Length - 1, b.Length - 1];
            double s;
            for (int i = b.Length - 1; i > -1; i--)
            {
                s = 0;
                for (int j = i+1; j < b.Length; j++)
                {
                    s = s + a[i,j] * result[j];
                }
                result[i] = (b[i] - s) / a[i,i];
            }    
            return result;
        }

        public double[] Eliminacao(double[,] a, double[] b)
        {
            double m;
            int h = a.Length;
            for (int k = 0; k < a.GetLength(0) - 1; k++)
            {
                for (int i = k + 1; i < a.GetLength(0); i++)
                {
                    m = a[i, k] / a[k, k];
                    a[i,k] = 0;
                    for (int j = k + 1; j < b.Length; j++)
                    {
                        a[i,j] = a[i,j] - (m * a[k,i]);
                    }
                    b[i] = b[i] - (b[k] * m);
                }
            }
            return Resolucao(a, b);
        }
    }
}
