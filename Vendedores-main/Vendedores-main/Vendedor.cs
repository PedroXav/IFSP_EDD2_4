public class Vendedor
{
    private int id { set; get; }
    private string nome { set; get; }
    private double percComissao { set; get; }
    private Venda[] asVendas = new Venda[31];

    public Vendedor(int id, string nome, double percComissao)
    {
        this.id = id;
        this.nome = nome;
        this.percComissao = percComissao;
    }

    public void registrarVenda(int dia, Venda venda)
    {
        if (dia >= 1 && dia <= 31)
        {
            asVendas[dia - 1] = venda;
        }
        else
        {
            Console.WriteLine("Dia inválido. Deve estar entre 1 e 31.");
        }
    }

    public double valorVendas()
    {
        double total = 0;
        foreach (var venda in asVendas)
        {
            if (venda != null)
                total += venda.Valor;
        }
        return total;
    }

    public double valorComissao()
    {
        return valorVendas() * percComissao / 100;
    }

    public int Id
    {
        get { return id; }
    }

    public string Nome
    {
        get { return nome; }
    }
}