namespace CatalogoJogos.Models
{
    public class BaseModel
    {
        protected readonly Database database;

        protected BaseModel()
        {
            database = new Database();
        }
    }
}