using System.ComponentModel.DataAnnotations;
namespace Create.Models;
public class TeacherModel
{
    //Teacher Id, Teacher Name, Teacher Email, Teacher Qualification and Teacher Location.
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Qualification { get; set; }
    public string? Location { get; set; }

}