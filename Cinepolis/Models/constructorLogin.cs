using SQLite;
namespace Cinepolis.Models
{
    public class constructorLogin
    {
        [PrimaryKey]
        public int codigo { get; set; }
        public string nombre { get; set; }

        public string correo { get; set; }
    }
}
