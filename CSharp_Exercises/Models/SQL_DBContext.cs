using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using CSharp_Exercises.DAL;

namespace CSharp_Exercises.Models;

public class SQL_DBContext : DbContext
{
    // Tables
    public DbSet<Employee> Employees { get; set; }

    // Database provider
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        GrabLocalDatabaseCredentials credentialGrabber = new GrabLocalDatabaseCredentials();
        //SqlConnection connection = new SqlConnection(credentialGrabber.sqlConnStr);

        /*if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {

        }*/
        optionsBuilder.UseSqlServer(credentialGrabber.sqlConnStr);
    }
}
