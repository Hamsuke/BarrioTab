using SQLite;

namespace BarrioTab.Models
{
    public class Almacen
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public int categoria { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
    }
}
