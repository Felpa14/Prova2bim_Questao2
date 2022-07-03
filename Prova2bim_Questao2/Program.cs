using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2bim_Questao2
{
    internal class Program
    {
        private static string Mesext(int mes)
        {
            string mesextenso;
            mesextenso = null;
            switch (mes)
            {
                case 1:
                    mesextenso = "Janeiro";
                    break;
                case 2:
                    mesextenso = "Fevereiro";
                    break;
                case 3:
                    mesextenso = "Março";
                    break;
                case 4:
                    mesextenso = "Abril";
                    break;
                case 5:
                    mesextenso = "Maio";
                    break;
                case 6:
                    mesextenso = "Junho";
                    break;
                case 7:
                    mesextenso = "Julho";
                    break;
                case 8:
                    mesextenso = "Agosto";
                    break;
                case 9:
                    mesextenso = "Setembro";
                    break;
                case 10:
                    mesextenso = "Outubro";
                    break;
                case 11:
                    mesextenso = "Novembro";
                    break;
                case 12:
                    mesextenso = "Dezembro";
                    break;
            }
            return mesextenso;
        }

        static void Main(string[] args)
        {
            int cidade, dia, ano, mes;
            string cidadeextenso;
            cidadeextenso = null;

            Console.Write("Digite o numero da cidade desejada:\n1- Atibaia\n2- Bragança Paulista\n3- Mairiporã\n4- Nazaré\n5- Terra Preta\n6- Extrema\n7- Vargem\n= ");
            cidade = Convert.ToInt32(Console.ReadLine());
            switch (cidade)
            {
                case 1:
                    cidadeextenso = "Atibaia";
                    break;
                case 2:
                    cidadeextenso = "Bragança Paulista";
                    break;
                case 3:
                    cidadeextenso = "Mairoporã";
                    break;
                case 4:
                    cidadeextenso = "Nazaré";
                    break;
                case 5:
                    cidadeextenso = "Terra Preta";
                    break;
                case 6:
                    cidadeextenso = "Extrema";
                    break;
                case 7:
                    cidadeextenso = "Vargem";
                    break;
                default:
                    Console.Write("O número digitado não é valido!");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }

            Console.Write("Digite uma data no formato DD/MM/AAAA: ");
            var data = Convert.ToDateTime(Console.ReadLine());
            dia = data.Day;
            mes = data.Month;
            ano = data.Year;
            Console.Write(cidadeextenso + ", " + dia + " de " + Mesext(mes) + " de " + ano + ".");
            Console.ReadKey();
                       
            
                                                               
        }                  
    }
}
