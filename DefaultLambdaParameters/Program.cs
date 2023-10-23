
List<Produto> produtos = new List<Produto>
    {
        new Produto("Produto A", 10.99M),
        new Produto("Produto B", 15.99M),
        new Produto("Produto C", 5.99M),
        new Produto("Produto D", 20.99M),
        new Produto("Produto E", 1.99M),
    };


var filtrarPorPrecoMinimo = (decimal precoMinimo = 0.0M) =>
{
    return produtos.FindAll(produto => produto.Preco >= precoMinimo);
};

filtrarPorPrecoMinimo();
filtrarPorPrecoMinimo(10);

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}
