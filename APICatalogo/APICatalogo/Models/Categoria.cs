using System.Collections.ObjectModel;

namespace APICatalogo.Models
{
    public class Categoria
    {
        //isso inicializa a coleção dos produtos
        public Categoria() => Produtos = new Collection<Produto>();

        //vou criar propriedades que irão representar as info q vou gerenciar
        public int CategoriaId { get; set; }

        //o uso do '?' é necessário para transformar as prop em não nulas
        public string? Nome { get; set; }

        //nesta api a imagem não ficará no banco de dados e sim com uma url aq no codigo
        public string? ImagemUrl { get; set; }
        //Essa é uma prop que indica a relação de 1:n (uma categoria pode ter uma coleção de produtos)
        public ICollection<Produto>? Produtos { get; set; }
    }
}

//é uma classe anêmica: n contem informações aqui e sim no banco de dados.
