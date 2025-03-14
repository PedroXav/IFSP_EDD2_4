public class Venda
{
    private int qtde { set; get; }
    private double valor { set; get; }

    public Venda(int qtde, double valor)
    {
        this.qtde = qtde;
        this.valor = valor;
    }

    public double valorMedio()
    {
        return valor / qtde;
    }

    public double Valor
    {
        get { return valor; }
    }
}