using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharp_Exercises.Models;

public class Employee
{
    [Column("Id")]
    public int Id { get; set; }
    [Column("Name")]
    public required string Name { get; set; }
    [Column("Email")]
    public required string Email { get; set; }
    [Column("Occupation")]
    public required string Occupation { get; set; }
}
