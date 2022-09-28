using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //constructor
        {
                
        }
        //create our category table inside the database
        //properties are used to access to the table that EFC will create in our database

        public DbSet <Category> Categories { get; set; }  //the table name inside the database is Categories 
                                                           // <Category> model has the column or attribute of the Categories table
    }
}
