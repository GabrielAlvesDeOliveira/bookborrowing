using Microsoft.EntityFrameworkCore;
using OdenMVC.Models;

namespace OdenMVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {   
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }
}
