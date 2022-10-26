using System;

namespace ParedeVsAzulejo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hp, lp, ha, la, areaParede, areaAzulejo, qtoAzulejo;
            try
            {
                Console.WriteLine("\nInforme a altura da parede:");
                hp = obterValor(); 
                Console.WriteLine("\nInforme a largura da parede:");
                lp = obterValor(); 
                Console.WriteLine("\nInforme a altura do azulejo");
                ha = obterValor(); 
                Console.WriteLine("\nInforme a largura do azulejo");
                la = obterValor(); 
                areaParede = hp * lp;
                areaAzulejo = ha * lp;
                qtoAzulejo = areaParede / areaAzulejo;
                Console.WriteLine("\n A quantidade de azulejos é: {0}", qtoAzulejo);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n Pressione qualquer tecla para finalizar");
            Console.ReadKey();                       
        }
        static double obterValor()
        {
            try
            {
                var valor = Console.ReadLine();
                return Convert.ToDouble(valor);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nValor informado esta incorreto, informe novamente:");
                return obterValor();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
