using System;

public class Atendimento
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public Funcionario Funcionario { get; set; }
    public DateTime DataAtendimento { get; set; }
    public string Descricao { get; set; }

    public Atendimento(int id, Cliente cliente, Funcionario funcionario, DateTime dataAtendimento, string descricao)
    {
        Id = id;
        Cliente = cliente;
        Funcionario = funcionario;
        DataAtendimento = dataAtendimento;
        Descricao = descricao;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Atendimento ID: {Id}");
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"Funcionário: {Funcionario.Nome}");
        Console.WriteLine($"Data: {DataAtendimento}");
        Console.WriteLine($"Descrição: {Descricao}");
    }
}
