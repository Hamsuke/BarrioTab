using SQLite;

namespace BarrioTab.Models
{
    public class Turnos
    {
        [PrimaryKey, AutoIncrement]
        int id { get; set; }
        public string encargado { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public float apertura { get; set; }
        public float cierre { get; set; }
        public float deficit { get; set; }
    }
}
