using System;
using System.Text;

namespace SistemaCsharpComTela
{
    class Jacobbi
    {
        public String SolucaoErro(double[] b, double[,] a, double erro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(Environment.NewLine);
            double er = erro + 1;
            double[] inicial = new double[b.Length];
            double[] anterior = new double[b.Length];
            double[,] usaroutros = new double[b.Length, b.Length];
            double[] erros = new double[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (i == j)
                    {
                        usaroutros[i, i] = 1 / a[i, i];
                    }
                    else
                    {
                        usaroutros[i, j] = -1 * a[i, j];
                    }
                }
            }
            int k = 0;
            while (k < erro)
            {
                _ = stringBuilder.Append(String.Format("{0}     ", k));
                if (k == 0)
                {

                    for (int i = 0; i < b.Length; i++)
                    {


                        anterior[i] = usaroutros[i, i] * b[i];
                        stringBuilder.Append(String.Format("{0}      ", anterior[i]));
                        inicial[i] = anterior[i];

                    }

                    _ = stringBuilder.Append(Environment.NewLine);
                }
                else
                {
                    for (int i = 0; i < b.Length; i++)
                    {

                        double sum = 0;
                        for (int j = 0; j < b.Length; j++)
                        {
                            if (i != j)
                            {
                                sum += usaroutros[i, j] * anterior[j];
                            }
                        }
                        anterior[i] = Math.Round(usaroutros[i, i] * (b[i] + (sum)), 4);
                        erros[i] = Math.Abs(inicial[i] - anterior[i]);

                        _ = stringBuilder.Append(string.Format("{0}   {1}  ", anterior[i], Math.Round(erros[i], 4)));

                    }

                    inicial = anterior;
                }

                stringBuilder.Append(Environment.NewLine);
                k++;
            }

            return stringBuilder.ToString();
        }


    }
}
