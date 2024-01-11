using System.ComponentModel.DataAnnotations;
using LeitorNfe.Core.Models;
namespace LeitorNfe.Core.Models.DTOs;

public class EditNFeInStorageForm
{
    [Required]

    public NFeInStorage? NFeInStorage {get; set;}
}