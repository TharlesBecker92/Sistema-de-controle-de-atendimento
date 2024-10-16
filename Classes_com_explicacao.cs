using System;

public class FilaAtendimento
{
    private Queue<Atendimento> fila = new Queue<Atendimento>();

    public void AdicionarAtendimento(Atendimento atendimento)
    {
        fila.Enqueue(atendimento);
    }

    public Atendimento ProximoAtendimento()
    {
        return fila.Dequeue();
    }

    public int TamanhoFila()
    {
        return fila.Count;
    }
}

