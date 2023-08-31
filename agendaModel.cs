class Data{
    private int dia;
    private int mes;
    private int ano;

    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
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
    private string nome;
    private Data dtNasc;
    private List<Telefone> telefones;

    public Contato(string email, string nome, Data dtNasc)
    {
        this.email = email;
        this.nome = nome;
        this.dtNasc = dtNasc;
    }

    public int getIdade(){
        return 0;
    }

    public void adicionarTelefone(){

    }

    public string getTelefonePrincipal(){
        return "";
    }

    public override string ToString()
    {
        return "Nome: " + nome +
        "\nEmail: " + email +
        "Telefone principal: " + getTelefonePrincipal() + 
        "\nIdade: " + getIdade();
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