using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Teste.Manutencao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(string.Format("-- {0} ", "{SEU NOME AQUI}"));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Executar();

            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(string.Format("-- PROGRAMA FINALIZADO EM {0}ms", stopwatch.ElapsedMilliseconds));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void Executar()
        {
            var linhas = File.ReadLines(@".\Arquivos\input.3.in");

            for (int i = 0; i < linhas.ToList().Count; i++)
            {
                var linha = linhas.ToList()[i];
                var valorInteiro = "";
                Console.WriteLine();
                Console.WriteLine(string.Format("-- Teste #{0:00} ------------------------------", i + 1));
                Console.WriteLine(string.Format("Entrada: \t{0}", linha));
                Console.Write("Saída: \t\t");

                switch (linha.Length)
                {
                    case 13:
                        // 5547984461240  	MOB: +55 (47) 9 8442-1245
                        Console.WriteLine(string.Format("MOB: +{0} ({1}) {2} {3}-{4}",
                                linha.Substring(0, 2),
                                linha.Substring(2, 2),
                                linha.Substring(4, 1),
                                linha.Substring(5, 4),
                                linha.Substring(9, 4)
                            ));
                        break;

                    case 12:
                        valorInteiro = linha.Substring(4, 1);
                        if (int.Parse(valorInteiro) > 6)
                        {
                            if (linha.Substring(0, 1) == "0")
                            {
                                Console.WriteLine(
                                string.Format("MOB: ({0}) {1} {2}-{3}",
                                    linha.Substring(1, 2),
                                    linha.Substring(3, 1),
                                    linha.Substring(4, 4),
                                    linha.Substring(8, 4)
                                ));
                            }
                            else
                            {
                                Console.WriteLine(
                                string.Format("MOB: +{0} ({1}) {2}-{3}",
                                    linha.Substring(0, 2),
                                    linha.Substring(2, 2),
                                    linha.Substring(4, 4),
                                    linha.Substring(8, 4)
                                ));
                            }
                        }
                        else
                        {
                            Console.WriteLine(
                                string.Format("RES: +{0} ({1}) {2}-{3}",
                                    linha.Substring(0, 2),
                                    linha.Substring(2, 2),
                                    linha.Substring(4, 4),
                                    linha.Substring(8, 4)
                                ));
                        }
                        break;

                    case 11:
                        valorInteiro = linha.Substring(3, 1);
                        if (int.Parse(valorInteiro) > 6)
                        {
                            if (linha.Substring(0, 1) == "0")
                            {
                                Console.WriteLine(
                                    string.Format("MOB: ({0}) {1}-{2}",
                                        linha.Substring(1, 2),
                                        linha.Substring(3, 4),
                                        linha.Substring(7, 4)
                                    ));
                            }
                            else
                            {
                                Console.WriteLine(
                                    string.Format("MOB: ({0}) {1} {2}-{3}",
                                        linha.Substring(0, 2),
                                        linha.Substring(2, 1),
                                        linha.Substring(3, 4),
                                        linha.Substring(7, 4)
                                    ));
                            }
                        }
                        else
                        {
                            if (linha.Substring(0, 4) == "0800")
                            {
                                Console.WriteLine(
                                 string.Format("RES: {0} {1} {2}",
                                     linha.Substring(0, 4),
                                     linha.Substring(4, 3),
                                     linha.Substring(7, 4)
                                 ));
                            }
                            else
                            {
                                Console.WriteLine(
                                    string.Format("RES: ({0}) {1}-{2}",
                                        linha.Substring(1, 2),
                                        linha.Substring(3, 4),
                                        linha.Substring(7, 4)
                                    ));
                            }
                        }
                        break;

                    case 10:
                        if (linha.Substring(2, 1) == "8" || linha.Substring(2, 1) == "9")
                        {
                            // 4784461240  	MOB: (47) 8442-1245
                            Console.WriteLine(
                                    string.Format("MOB: ({0}) {1}-{2}",
                                        linha.Substring(0, 2),
                                        linha.Substring(2, 4),
                                        linha.Substring(6, 4)
                                    ));
                        }
                        else
                        {
                            // 4733251368	        RES: (47) 3325-1378
                            Console.WriteLine(
                                    string.Format("RES: ({0}) {1}-{2}",
                                        linha.Substring(0, 2),
                                        linha.Substring(2, 4),
                                        linha.Substring(6, 4)
                                    ));
                        }
                        break;

                    case 9:
                        // 984461240  	    MOB: 9 8442-1245
                        Console.WriteLine(
                                string.Format("MOB: {0} {1}-{2}",
                                    linha.Substring(0, 1),
                                    linha.Substring(1, 4),
                                    linha.Substring(5, 4)
                                ));
                        break;

                    case 8:
                        if (linha.Substring(0, 1) == "3")
                        {
                            // 33251368     RES: 3325-1378
                            Console.WriteLine(
                                    string.Format("RES: {0}-{1}",
                                        linha.Substring(0, 4),
                                        linha.Substring(4, 4)
                                    ));
                        }
                        else
                        {
                            // 84461240  	MOB: 8442-1245
                            Console.WriteLine(
                                    string.Format("MOB: {0}-{1}",
                                        linha.Substring(0, 4),
                                        linha.Substring(4, 4)
                                    ));
                        }
                        break;

                    case 5:
                        if (linha.Substring(0, 3) == "103")
                        {
                            // 10321	ETF: 103+21
                            Console.WriteLine(string.Format("ETF: {0}+{1}", linha.Substring(0, 3), linha.Substring(3, 2)));
                        }

                        if (linha.Substring(0, 3) == "106")
                        {
                            // 10625    ETV: 10625
                            Console.WriteLine(string.Format("ETV: {0}", linha.Substring(0, 5)));
                        }
                        break;

                    case 4:
                        // 1052	    ETM: 1052
                        Console.WriteLine(string.Format("ETM: {0}", linha.Substring(0, 4)));
                        break;

                    case 3:
                        // 190	SUP: 190
                        Console.WriteLine(string.Format("SUP: {0}", linha.Substring(0, 3)));
                        break;

                    default:
                        Console.WriteLine(string.Format("N/A: {0}", linha));
                        break;
                }

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}