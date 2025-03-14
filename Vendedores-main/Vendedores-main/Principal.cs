public class Principal
{
    public static void Main(string[] args)
    {
        Vendedores vendedores = new Vendedores(10);
        int opcao;

        do
        {
            Console.WriteLine("\n0. Sair");
            Console.WriteLine("1. Cadastrar vendedor");
            Console.WriteLine("2. Consultar vendedor");
            Console.WriteLine("3. Excluir vendedor");
            Console.WriteLine("4. Registrar venda");
            Console.WriteLine("5. Listar vendedores");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Percentual de Comissão: ");
                    double percComissao = double.Parse(Console.ReadLine());

                    Vendedor novoVendedor = new Vendedor(id, nome, percComissao);
                    if (vendedores.addVendedor(novoVendedor))
                        Console.WriteLine("Vendedor cadastrado com sucesso.");
                    else
                        Console.WriteLine("Erro ao cadastrar. Limite de vendedores atingido.");
                    break;

                case 2:
                    Console.Write("ID do vendedor a consultar: ");
                    int idConsulta = int.Parse(Console.ReadLine());
                    Vendedor vendedorConsultado = vendedores.searchVendedor(idConsulta);

                    if (vendedorConsultado != null)
                    {
                        Console.WriteLine($"Nome: {vendedorConsultado.Nome}");
                        Console.WriteLine($"Valor total de vendas: {vendedorConsultado.valorVendas():C}");
                        Console.WriteLine($"Valor da comissão: {vendedorConsultado.valorComissao():C}");
                    }
                    else
                    {
                        Console.WriteLine("Vendedor não encontrado.");
                    }
                    break;

                case 3:
                    Console.Write("ID do vendedor a excluir: ");
                    int idExcluir = int.Parse(Console.ReadLine());

                    if (vendedores.delVendedor(idExcluir))
                        Console.WriteLine("Vendedor excluído com sucesso.");
                    else
                        Console.WriteLine("Erro ao excluir. Vendedor não encontrado.");
                    break;

                case 4:
                    Console.Write("ID do vendedor: ");
                    int idVenda = int.Parse(Console.ReadLine());
                    Vendedor vendedorVenda = vendedores.searchVendedor(idVenda);

                    if (vendedorVenda != null)
                    {
                        Console.Write("Dia da venda (1-31): ");
                        int dia = int.Parse(Console.ReadLine());
                        Console.Write("Quantidade de produtos vendidos: ");
                        int qtde = int.Parse(Console.ReadLine());
                        Console.Write("Valor total da venda: ");
                        double valor = double.Parse(Console.ReadLine());

                        Venda venda = new Venda(qtde, valor);
                        vendedorVenda.registrarVenda(dia, venda);
                        Console.WriteLine("Venda registrada com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Vendedor não encontrado.");
                    }
                    break;

                case 5:
                    vendedores.listarVendedores();
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 0);
    }
}