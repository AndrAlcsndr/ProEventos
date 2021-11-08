using Microsoft.EntityFrameworkCore;
using Proeventos.API.Models;

namespace Proeventos.Api.Data 
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext>options): base (options) 
        {
            

        } 
        public DbSet<Evento> Eventos {get; set;}

    }
}