using BarrioTab.Data;
using BarrioTab.Models;
using SQLite;

namespace BarrioTab.Services;
    public class DataBaseService : IAsyncDisposable
    {
        private readonly SQLiteAsyncConnection _database;
        public DataBaseService()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BarrioTab.db3");
            _database = new SQLiteAsyncConnection(dbPath, 
                SQLiteOpenFlags.Create | 
                SQLiteOpenFlags.ReadWrite | 
                SQLiteOpenFlags.SharedCache);
        }

        public async Task InicializaBasedeDatosAsync()
        {
            await _database.CreateTableAsync<Almacen>();
            await _database.CreateTableAsync<Categorias>();
            await _database.CreateTableAsync<Turnos>();
            await _database.CreateTableAsync<Usuarios>();
            await _database.CreateTableAsync<Venta>();
           
            await SeedDataAsync();
        }

        private async Task SeedDataAsync()
        {
            var firstCategory = await _database.Table<Categorias>().FirstOrDefaultAsync();
            if (firstCategory != null)
                return; // DB has been seeded

            var categorias = SeedData.GetCategorias();
            var almacen = SeedData.GetAlmacen();
            var usuarios = SeedData.GetUsuarios();

            await _database.InsertAllAsync(categorias);
            await _database.InsertAllAsync(almacen);
            await _database.InsertAllAsync(usuarios);

        }

    public async Task<IEnumerable<Categorias>> GetCategoriasAsync()
    {
        var ans = await _database.Table<Categorias>().ToListAsync();
        return ans;
    }

    public async Task<IEnumerable<Almacen>> GetAlmacenAsync()
    {
        var ans = await _database.Table<Almacen>().ToListAsync();
        return ans;
    }

    public async Task<IEnumerable<Almacen>> GetAlmacenCategoria(int categoria)
    {
        var ans = await _database.Table<Almacen>().Where(x => x.categoria == categoria).ToListAsync();
        return ans;
    }

    public async ValueTask DisposeAsync()
        {
            if(_database != null)
            {
                await _database.CloseAsync();
            }
        }

    public async Task InsertCategoriaAsync(Categorias newCat)
    {
        await _database.InsertAsync(newCat);
    }

    public async Task InsertAlmacenAsync(Almacen newAlmacen)
    {
        await _database.InsertAsync(newAlmacen);
    }

    public async Task InsertVentaAsync(Venta newVenta)
    {
        await _database.InsertAsync(newVenta);
    }

    public async Task InsertTurnoAsync(Turnos newTurno)
    {
        await _database.InsertAsync(newTurno);
    }
    public async Task InsertUsuarioAsync(Usuarios newUsuario)
    {
        await _database.InsertAsync(newUsuario);
    }
    public async Task  DeleteCategoriaAsync(Categorias cat)
    {
        await _database.DeleteAsync(cat);
    }
}
