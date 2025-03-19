using SQLite;

namespace BarrioTab.Models
{
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string usuario { get; set; }
        public int password { get; set; }
        public bool administrador { get; set; }
    }
}
