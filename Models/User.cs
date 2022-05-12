using Dapper.Contrib.Extensions;

namespace Revisao.Models;
[Table("[Users]")]
public class User
{
    public int Id { get; set; }
    public string nome { get; set; }
    public string email { get; set; }
    public string Password { get; set; }
}