using SQLite;

namespace BarrioTab.Models
{
    public class Categorias
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
    }
}
