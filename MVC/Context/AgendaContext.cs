using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVC.Models;

namespace MVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos{get; set;}
    }
}
