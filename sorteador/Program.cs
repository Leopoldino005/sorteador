List<string> nomes = new List<string>() {};
Dictionary<string, string> pares = new Dictionary<string, string>();
int opcao;
string novoNome;

do { 
    Console.WriteLine("\nAMIGO OCULTO"); 
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
                        if (!nomes.Contains(novoNome))
                        {
                            nomes.Add(novoNome);
                        }
                        else
                        {
                            Console.WriteLine("Nome já cadastrado, tente outro.");
                        }
                    }
            }while (novoNome.ToLower() != "sair");            
            break;

        case 2:
            Console.WriteLine("\nOs nomes já cadastrados são: " + string.Join(", ", nomes));        
            break;

        case 3:
            if (nomes.Count < 2)
            {
                Console.WriteLine("É necessário pelo menos 2 nomes para sortear!");
            }
            else
            {
                Console.WriteLine("\n=== PARES DO SORTEIO ===");
                foreach (var par in pares)
                {
                    Console.WriteLine($"{par.Key} → {par.Value}");
                }
            }
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    
}while (opcao!=0);

