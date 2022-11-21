namespace APICatalogo.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public decimal Preco { get; set; }

        public string? ImagemUrl { get; set; }

        public float Estoque { get; set; }

        public DateTime DataCadastro { get; set; }

        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}

//é uma classe anêmica: não tem comportamento, ou seja, n contem informações aqui e sim no banco de dados.
//a prop CategoriaId mapeia para a FK no db e uma prop de navegação Categoria para indicar que 1 Produto esta relacionado a 1 Categoria