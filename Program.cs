int resp;
do
{
    do
    {
        Console.WriteLine("0. Sair");
        Console.WriteLine("1. Adicionar contato");
        Console.WriteLine("2. Adicionar telefone no contato");
        Console.WriteLine("3. Pesquisar contato");
        Console.WriteLine("4. Alterar contato");
        Console.WriteLine("5. Remover contato");
        Console.WriteLine("6. Listar contatos");
        resp = int.Parse(Console.ReadLine());
    }
    while (resp < 0 || resp > 6);

    switch (resp)
    {
        case 1:
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
    }
}
while (resp != 0);