using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCsharpComTela
{
    class Jacobbi
    {
        public double[] SolucaoErro(double[] b, double[,] a, double erro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            double er = erro + 1;
            double[] inicial = new double[b.Length];
            double[] anterior = new double[b.Length];
            double[,] usaroutros = new double[b.Length, b.Length];
            
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if(i==j)
                    {
                        usaroutros[i,i] = 1 / a[i, i];
                    }
                    else
                    {
                        usaroutros[i, j] = -1 * a[i, j];
                    }
                }
            }
            int k = 0;
            while(k < erro)
            {
                if (k == 0)
                {
                    stringBuilder.Append(String.Format("Linha {0}:", k));
                    for (int i = 0; i < b.Length; i++)
                    {
                        anterior[i] = usaroutros[i, i] * b[i];
                    }
                }
                else
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        double sum = 0;
                        for (int j = 0; j < b.Length; j++)
                        {
                            if(i!=j)
                            {
                                sum +=usaroutros[i,j] * anterior[j];
                            }
                        }
                        anterior[i] = usaroutros[i,i] * (b[i] + (sum));
                        stringBuilder.Append(String.Format("x{0}: é", i, anterior[i]));
                    }
                }
                k++;
            }
            return anterior;
        }
    }
}
