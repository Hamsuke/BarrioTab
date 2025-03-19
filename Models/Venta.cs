using SQLite;

namespace BarrioTab.Models
{
    public class Venta
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Nota { get; set; }
        public string Mesa { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Turno { get; set; }
        public decimal Pago { get; set; }
        public string Encargado { get; set; }
        public bool Estado { get; set; }
    }
}
