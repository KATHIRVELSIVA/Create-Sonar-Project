namespace Create.Data;
using Create.Models;
using Microsoft.EntityFrameworkCore;

public class Appdbcontext : DbContext
{
    public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
    {

    }
    public DbSet<TeacherModel> Teachers { get; set; }

}
