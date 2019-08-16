namespace SistemaCsharpComTela
{
    class CalculaSistemaLinear
    {

        public double[] Resolucao(double[][] a, double[] b)
        {

            return null;

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
