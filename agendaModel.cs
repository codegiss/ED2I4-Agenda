class Data{
    private int dia {get; set;}
    private int mes {get; set;}
    private int ano;

    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    public int getAno()
    {
        return ano;
    }

    public void setAno(int ano)
    {
        this.ano = ano;
    }

    public void setData(int dia, int mes, int ano){
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    public override string ToString(){
        return dia + "/" +
                mes + "/" +
                ano;
    }
}

class Telefone {
    private string tipo;
    private string numero;
    private bool principal;

    public Telefone(string tipo, string numero)
    {
        this.tipo = tipo;
        this.numero = numero;
        principal = true;
    }
}

class Contato{
    private string email;
    private string nome {get; set;}
    private Data dtNasc {get; set;}
    private List<Telefone> telefones {get; set;}

    public Contato(string email, string nome, Data dtNasc)
    {
        this.email = email;
        this.nome = nome;
        this.dtNasc = dtNasc;
    }

    public string getEmail()
    {
        return email;
    }

    public void setEmail(string email)
    {
        this.email = email;
    }

    public int getIdade(Contato c){
        int nasc = c.dtNasc.getAno();
        int agora = DateTime.Now.Year;
        return agora-nasc;
    }

    public void adicionarTelefone(string tel){
        
    }

    public string getTelefonePrincipal(){
        return "";
    }

    public string ToString(Contato c)
    {
        return "Nome: " + nome +
        "\nEmail: " + email +
        "\nTelefone principal: " + getTelefonePrincipal() + 
        "\nIdade: " + getIdade(c);
    }

    public override bool Equals(object obj)
    {
        return false;
    }
}

class Contatos
{
    private readonly List<Contato> agenda;

    public Contatos(List<Contato> agenda)
    {
        this.agenda = agenda;
    }

    public bool adicionar(Contato c)
    {
        return false;
    }
    public Contato pesquisar(Contato c)
    {
        return c;
    }
    public bool alterar(Contato c)
    {
        return false;
    }
    public bool remover(Contato c)
    {
        return false;
    }
}