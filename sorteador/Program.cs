using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        Dictionary<string, string> pares = new Dictionary<string, string>();
        int opcao;
        string novoNome;

        do
        {
            Console.WriteLine("AMIGO OCULTO");
            Console.WriteLine("Escolha uma opção:\n" +
                              "0 - Sair\n" +
                              "1 - Adicionar Nomes\n" +
                              "2 - Lista de Nomes\n" +
                              "3 - Sortear\n");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Finalizado!");
                    break;

                case 1:
                    do
                    {
                        Console.WriteLine("Digite os nomes (digite 'sair' para parar):");
                        novoNome = Console.ReadLine();
                        if (novoNome.ToLower() != "sair")
                        {
                            if (!nomes.Contains(novoNome) && !string.IsNullOrWhiteSpace(novoNome))
                            {
                                nomes.Add(novoNome);
                            }
                            else
                            {
                                Console.WriteLine("Nome já cadastrado ou inválido, tente outro.");
                            }
                        }
                    } while (novoNome.ToLower() != "sair");
                    break;

                case 2:
                    Console.WriteLine("Os nomes já cadastrados são: " + string.Join(", ", nomes));
                    break;

                case 3:
                    if (nomes.Count < 3)
                    {
                        Console.WriteLine("É necessário pelo menos 3 nomes para sortear!");
                    }
                    else
                    {
                        pares = SortearAmigoOculto(nomes);

                        Console.WriteLine("=== PARES SORTEADOS ===");
                        foreach (var par in pares)
                        {
                            Console.WriteLine($"{par.Key} → {par.Value}");
                        }
                        Console.WriteLine("Obrigado Por Participar!");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);
    }

    static Dictionary<string, string> SortearAmigoOculto(List<string> nomes)
    {
        Random rnd = new Random();
        Dictionary<string, string> pares = new Dictionary<string, string>();
        bool valido;

        do
        {
            valido = true;

            List<string> sorteados = new List<string>(nomes);
            for (int i = sorteados.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                string temp = sorteados[i];
                sorteados[i] = sorteados[j];
                sorteados[j] = temp;
            }

            pares.Clear();

            for (int i = 0; i < nomes.Count; i++)
            {
                string pessoa = nomes[i];
                string amigo = sorteados[i];

                if (pessoa == amigo)
                {
                    valido = false;
                    break;
                }

                pares[pessoa] = amigo;
            }

            if (valido)
            {
                foreach (var par in pares)
                {
                    if (pares.ContainsKey(par.Value) && pares[par.Value] == par.Key)
                    {
                        valido = false;
                        break;
                    }
                }
            }

        } while (!valido);

        return pares;
    }
}
