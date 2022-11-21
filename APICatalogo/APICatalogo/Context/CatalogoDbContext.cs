using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Banco
{
    //nessa classe definimos o mapeamento entre as entidades e as tabelas
    public class CatalogoDbContext : DbContext
    {
        public CatalogoDbContext(DbContextOptions<CatalogoDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}

//DbContext : representa uma sessão com o banco de dados sendo a ponte entre as entidades de domínio e o banco 

//DbContextOptions configura o contexto que sera usado na classe base (que nesse caso será a options)

//DbSet<...> : representa uma coleção de entidades no contexto que podem ser consultadas no banco de dados

//Categorias e Produtos são as tableas que vão ser criadas no banco de dados

//Uma categoria pode ter um ou mais produtos (relacionamento 1:n entre a tb Categorias e tb Produtos)

//a fk (foreign key) estabelece um link entra as duas tabelas
