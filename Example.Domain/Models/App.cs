using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.Domain.Models;

public class App
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [MaxLength(40)]
    public string Name { get; set; }
    [MaxLength(100)]
    public string Description { get; set; }
    [ForeignKey("FK")]
    public int ProgrammerId { get; set; }
    public Programmer Programmer { get; set; }
}
