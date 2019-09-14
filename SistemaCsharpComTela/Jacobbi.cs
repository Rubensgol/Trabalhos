using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double erros ;
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
                stringBuilder.Append(String.Format("{0}     ",k));
                if (k == 0)
                {
                  
                    for (int i = 0; i < b.Length; i++)
                    {

                        
                        anterior[i] = usaroutros[i, i] * b[i];
                        stringBuilder.Append(String.Format("{0}      ", anterior[i]));
                       

                    }
                    inicial = anterior;
                    stringBuilder.Append(Environment.NewLine);
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
                        anterior[i] = Math.Round(usaroutros[i,i] * (b[i] + (sum)));
                        erros = Math.Abs(inicial[i] - anterior[i]);
                        stringBuilder.Append(String.Format("{0}   {1} ", anterior[i],erros));
                        
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
