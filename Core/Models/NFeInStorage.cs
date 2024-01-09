
namespace LeitorNfe.Core.Models;

public class NFeInStorage
{
    public int Id {get; set;}
    public NFe NFe {get; set;}
    public string Directory {get; set;}
    public string? Comentary {get; set;}
}