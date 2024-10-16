public class Servico
{
    //atributos
    public int Id;
    public string Nome;
    public string Descricao;

    //metodos
    void ExibirInformações() {}
}

public class Fila
{
    //atributos
    public Servico Servico
    public Queue<Senha> Senhas

    //metodos
    public void AdicionarSenha() {}
    public Senha ChamarProximaSenha(){}
}
// Explicando a linha Queue<Senha>
// https://learn.microsoft.com/pt-br/dotnet/api/system.collections.queue?view=net-8.0
/*
    Queue representa uma coleção primeiro a entrar, primeiro a sair de objetos.
    Essa classe implementa uma fila como uma matriz circular. Os objetos armazenados
    em um Queue são inseridos em uma extremidade e removidos do outro. FIFO (First In, First Out).
*/

public class Senha
{
    //atributos
    public int Numero
    public DateTime HoraEmissao
    public DateTime HoraAtendimento

    //metodos
    public void RegistrarAtendimento(){}
    public double TempoDeEspera(){}
}

/*
https://learn.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-8.0
DateTime: Representa um momento no tempo, geralmente expresso como uma data e hora do dia.
*/
