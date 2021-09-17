using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoJogos.Models
{
    public class Jogo : BaseModel
    {
        public int IdJogo { get; set; }
        
        [field: Required(ErrorMessage = "Campo 'Nome' é obrigatório.")]
        [field: StringLength(45, ErrorMessage = "Campo 'Nome' não pode ser maior que 45 caracteres.")]
        public string Nome { get; set; }
        
        [field: Required(ErrorMessage = "Campo 'Categoria' é obrigatório.")]
        public int IdCategoria { get; set; }
        
        [Required(ErrorMessage = "Campo 'Joguei' é obrigatório.")]
        public bool Joguei { get; set; }

        
        public void Insert()
        {
            database.BeginTransaction();

            var query = @"insert into jogos (nome, id_categoria, joguei)
                            values (@Nome, @IdCategoria, @Joguei)";
            
            var parameters = new Dictionary<string, object>
            {
                {"@Nome", Nome},
                {"@IdCategoria", IdCategoria},
                {"@Joguei", Joguei}
            };
            
            database.ExecuteQuery(query, parameters);
            
            database.Commit();
        }
        
        
        public void Delete()
        {
            database.BeginTransaction();

            var query = @"delete from jogos where id_jogo = @IdJogo";
            
            var parameters = new Dictionary<string, object>
            {
                {"@IdJogo", IdJogo}
            };
            
            database.ExecuteQuery(query, parameters);
            
            database.Commit();
        }
        
        
        public DataTable List()
        {
            var query = @"select id_jogo, jogos.nome as nome, categorias.nome as categoria, jogos.joguei from 
                            jogos inner join categorias on 
                            jogos.id_categoria = categorias.id_categoria";

            
            var parameters = new Dictionary<string, object>();

            var data = database.ExecuteQuery(query, parameters);
            
            return data;
        }
        
        
        public DataTable View()
        {
            var query = @"select id_jogo, jogos.nome as nome, categorias.nome as categoria, jogos.joguei from 
                            jogos inner join categorias on 
                            jogos.id_categoria = categorias.id_categoria
                            where id_jogo = @IdJogo";
            
            
            var parameters = new Dictionary<string, object>
            {
                {"@IdJogo", IdJogo}
            };

            var data = database.ExecuteQuery(query, parameters);

            return data;
        }
        
        
        public void Edit()
        {
            database.BeginTransaction();

            var query = @"update jogos set
                            nome = @Nome,
                            id_categoria = @IdCategoria,
                            joguei = @Joguei
                            where id_jogo = @IdJogo";
            
            
            var parameters = new Dictionary<string, object>
            {
                {"@IdJogo", IdJogo},
                {"@Nome", Nome},
                {"@IdCategoria", IdCategoria},
                {"@Joguei", Joguei}
            };

            database.ExecuteQuery(query, parameters);
            
            database.Commit();
        }
    }
}