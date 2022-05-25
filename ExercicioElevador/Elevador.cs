namespace ExercicioElevador;


/*
 * Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio.
 * A classe deve armazenar o andar atual (actual = 0), total de andares no prédio (desconsiderando o RC), capacidade do elevador e quantas pessoas estão presentes nele.
 *
 * A classe deve também disponibilizar os seguintes métodos:

Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no RC e vazio);

Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);

Sai : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);

Sobe : para subir um andar (não deve subir se já estiver no último andar); Desce : para descer um andar (não deve descer se já estiver no RC); Encapsular todos os atributos da classe (criar os métodos set e get).
 */
public class Elevador
{
    private int actual = 0;
    private int totalAndares;
    private int capacidade;
    private int pessoasDentro = 0;

    public Elevador(int totalAndares, int capacidade)
    {
        this.totalAndares = totalAndares;
        this.capacidade = capacidade;
    }

    public void entra()
    {
        if (capacidade > pessoasDentro)
        {
            pessoasDentro++;
            Console.WriteLine("Entro uma pessoa.");

        }
        else
        {
            Console.WriteLine("O elevador está cheio.");
        }
    }

    public void sai()
    {
        if (pessoasDentro > 0)
        {
            pessoasDentro--;
            Console.WriteLine("Saiu uma pessoa");

        }
        else
        {
            Console.WriteLine("Elevador vazio");
        }
    }

    public void sobe()
    {
        if (actual < totalAndares)
        {
            actual++;
            Thread.Sleep(2000);
            Console.WriteLine("{0}º Andar", actual);
        }
        else
        {
            Console.WriteLine("Falhou - Já se encontra no último piso");
        }
    }

    public void desce()
    {
        if (actual > 0)
        {
            actual--;
            Thread.Sleep(2000);
            Console.WriteLine("{0}º Andar", actual);
        }
        else
        {
            Console.WriteLine("Falhou - Já se encontra no RC");

        }
    }
    
    
}