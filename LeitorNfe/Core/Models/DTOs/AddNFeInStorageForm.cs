using System.ComponentModel.DataAnnotations;

namespace LeitorNfe.Core.Models.DTOs;

public class AddNFeInStorageForm 
{
    [Required]

    public NFe NFe {get; set;}


    [Required]

    public string Directory {get; set;}

    public string? Comentary {get; set;}
}