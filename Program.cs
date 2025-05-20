using System.Runtime.ConstrainedExecution;

//get; set;

class Produto
{
    private string nome; // atributo (ou campo) — é um membro da classe declarado com tipo e nome, e usado		             para armazenar dados

    public string Nome // propriedade com acessores (ou método: get; set). Não armazena valor, que 			           armazena valor é o atributo. A propriedade é um filtro de acesso do atributo.
    {
        get // retorna o valor do atributo (lê o valor do atributo) ← aqui o get faz a ligação: "valor da				 propriedade vem do atributo"
        {
            return nome; // o valor lido será do atributo nome.
        }
        set // atribui valor ao atributo (escrever no atributo)
        {
            if (value.Length > 1)
                nome = value;
            else
                throw new Exception(“Nome do produto deve ter pelo menos 2 caracteres.”);
        }
    }
}

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

        Produto p1 = new Produto();
        p1.Nome = "Banana"; // quando você usa uma atribuição (=) em uma propriedade com set definido, o				   compilador automaticamente entende que você quer executar o set daquela propriedade.

        Console.WriteLine(p1.Nome);
    }
}

/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

        Produto p1 = new Produto();
        p1.nome = "";
        Console.WriteLine($"Seu nome é: {p1.nome} ");
    }
}

class Produto
{
    public string nome; // campo
    public string Nome //propriedade; serve como a "porta de entrada controlada" para acessar e modificar a variável nome
    {
        get
        {
            return nome; // é aqui que vincula a propriedade Nome à variável nome.
        }
        set
        {
            if (value.Length > 1)
                nome = value;
            else
                throw new Exception("Nome do produto deve ter pelo menos 2 caracteres.");
        }
    }
}*/

// Instanciando um objeto de uma classe
/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

        Produto p1 = new Produto();
        p1.nome = "Ricardo";
        Console.WriteLine($"Seu nome é: {p1.nome} ");
    }
}

class Produto
{
    public string nome;
}*/

