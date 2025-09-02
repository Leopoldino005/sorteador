List<string> nomes = new List<string>() {};
int opcao;
string novoNome;

do { 
    Console.WriteLine("\nAMIGO OCULTO"); 
    Console.WriteLine("Escolha uma opção:\n" +
                      "0 - Sair\n" +
                      "1 - Sortear\n" +
                      "2 - Adicionar Nomes\n" +
                      "3 - Lista de Nomes\n");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Finalizado!");
            break;

        case 1:
            break;

        case 2:
            do
            {
                Console.WriteLine("Digite um nome (ou 'sair' para parar):");
                novoNome = Console.ReadLine();

                if (novoNome.ToLower() != "sair")
                {
                    nomes.Add(novoNome);
                }

            } while (novoNome.ToLower() != "sair");
            break;

        case 3:
            Console.WriteLine("\nOs nomes já cadastrados são: " + string.Join(", ", nomes));        
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    
}while (opcao!=0);

