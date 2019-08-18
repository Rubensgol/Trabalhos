namespace SistemaCsharpComTela
{
    class CalculaSistemaLinear
    {

        public double[] Resolucao(double[][] a, double[] b)
        {
            double[] result = new double[b.Length];
            result[b.Length] = b[b.Length] / a[b.Length][b.Length];
            double s;
            for (int i = b.Length; i >0; i--)
            {
                s = 0;
                for (int j = i+1; j < b.Length; j++)
                {
                    s = s + a[i][j] * result[j];
                }
                result[i] = (b[i] - s) / a[i][i];
            }    

            return result;

        }
        public double[] Eliminacao(double[][] a, double[] b)
        {
            double m;
            /*
            
            */
            for (int k = 0; k < a.Length - 1; k++)
            {
                for (int i = k + 1; i < a.Length; i++)
                {
                    m = a[i][k] / a[k][k];
                    a[i][k] = 0;
                    for (int j = k + 1; j < b.Length; j++)
                    {
                        a[i][j] = a[i][j] - (m * b[k]);
                    }
                }
            }
            return Resolucao(a, b);

        }






    }
}
