using System.Collections;

class AgendaController{
    private List<Contato> agenda = new List<Contato>();

    public string getAgenda()
    {
        string contatos = "g";

        foreach (Contato c in agenda)
        {
            contatos += c.ToString(c);
        }
        return contatos;
    }

    public Data addData(int dia, int mes, int ano)
    {
        if(ano<1) return null;
        if(mes<1 || mes>12) return null;

        int limite;
        switch(mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                limite = 31;
                break;
            case 2:
                limite = DateTime.IsLeapYear(ano)? 29 : 28;
                break;
            default:
                limite = 30;
                break;
        }

        if(dia<1 || dia>limite) return null;

        Data data = new Data(dia, mes, ano);
        return data;
    }

    public bool addContato(string email, string nome, Data dtNasc)
    {
        if(email == null || email.Length==0) return false;
        if(nome == null || nome.Length==0) return false;
        if(dtNasc == null) return false;

        Contato contato = new Contato(email, nome, dtNasc);
        Console.WriteLine(contato.ToString(contato));

        return true;
    }

    public Contato findContato(string email)
    {
        foreach(Contato c in agenda)
        {
            if(c.getEmail() == email)
            {
                return c;
            }
        }

        return null;
    }

    public bool addTelefone(Contato c, string tel)
    {
        if(tel == null) return false;
        c.adicionarTelefone(tel);

        return true;
    }
}