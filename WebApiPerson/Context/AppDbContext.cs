using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context
{
    public class AppDbContext: DbContext
    {   
        // Constructor de la clase AppDbContext que recibe un objeto de tipo DbContextOptions<AppDbContext> y lo pasa al constructor de la clase base DbContext.
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        // DbSet es una colección de entidades que se pueden consultar, modificar y guardar en la base de datos.
        public DbSet<Person> Persons { get; set; }
    }
}
