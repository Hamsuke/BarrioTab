using BarrioTab.Models;

namespace BarrioTab.Data;
    public static class SeedData
    {
    public static List<Categorias> GetCategorias()
    {
        return new List<Categorias>
        {
            new Categorias
            {
                id = 1,
                nombre = "Todos",
            },
            new Categorias
            {
                id = 2,
                nombre = "Cerveza",
            },
            new Categorias
            {
                id = 3,
                nombre = "Botana",

            }
        };
    }

    public static List<Almacen> GetAlmacen()
    {
        return new List<Almacen>
        {
            new Almacen
            {
                id = 1,
                nombre = "Maleficio",
                categoria = 2,
                precio = 20,
                cantidad = 100
            },
            new Almacen
            {
                id = 2,
                nombre = "Doritos",
                categoria = 3,
                precio = 15,
                cantidad = 50
            },
        };
    }    

    public static List<Usuarios> GetUsuarios()
    {
        return new List<Usuarios>
        {
            new Usuarios
            {
                id = 1,
                usuario = "Admin",
                password = 1234,
                administrador = true
            },
        };
    }
}
