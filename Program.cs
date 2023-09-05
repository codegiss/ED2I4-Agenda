int resp;
AgendaController agendaController = new AgendaController();
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
            
            Console.Write("Dia de nascimento: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês de nascimento: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());

            Data dtNasc = new Data(dia, mes, ano);

            Console.WriteLine(agendaController.addContato(email, nome, dtNasc)? "Contato gravado com sucesso" : "Não foi possível gravar o contato");
            break;
        case 2:
            Console.Write("Qual o email do contato? ");
            email = Console.ReadLine();
            

            Contato c = agendaController.findContato(email);

            if(c==null)
            {
                Console.WriteLine("Contato não existe");
            }
            else
            {
                Console.Write("Digite o telefone do contato: ");
                string telefone = Console.ReadLine();

                
            }
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            Console.WriteLine(agendaController.getAgenda());
            break;
    }
}
while (resp != 0);