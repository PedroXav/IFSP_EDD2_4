public class Vendedores
{
    private int max;
    private Vendedor[] osVendedores;
    private int qtde;

    public Vendedores(int max)
    {
        this.max = max;
        osVendedores = new Vendedor[max];
        qtde = 0;
    }

    public bool addVendedor(Vendedor v)
    {
        if (qtde < max)
        {
            osVendedores[qtde++] = v;
            return true;
        }
        return false;
    }

    public bool delVendedor(int id)
    {
        for (int i = 0; i < qtde; i++)
        {
            if (osVendedores[i].Id == id)
            {
                for (int j = i; j < qtde - 1; j++)
                {
                    osVendedores[j] = osVendedores[j + 1];
                }
                osVendedores[--qtde] = null;
                return true;
            }
        }
        return false;
    }

    public Vendedor searchVendedor(int id)
    {
        for (int i = 0; i < qtde; i++)
        {
            if (osVendedores[i].Id == id)
                return osVendedores[i];
        }
        return null;
    }

    public double valorVendas()
    {
        double total = 0;
        for (int i = 0; i < qtde; i++)
        {
            total += osVendedores[i].valorVendas();
        }
        return total;
    }

    public double valorComissao()
    {
        double total = 0;
        for (int i = 0; i < qtde; i++)
        {
            total += osVendedores[i].valorComissao();
        }
        return total;
    }

    public void listarVendedores()
    {
        if (qtde == 0)
        {
            Console.WriteLine("Nenhum vendedor cadastrado.");
        }
        else
        {
            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine($"ID: {osVendedores[i].Id}, Nome: {osVendedores[i].Nome}, Valor Vendas: {osVendedores[i].valorVendas():C}, Comissão: {osVendedores[i].valorComissao():C}");
            }
        }
    }
}