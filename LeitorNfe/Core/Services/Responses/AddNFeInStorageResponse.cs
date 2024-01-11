using LeitorNfe.Core.Models;

namespace LeitorNfe.Core.Services.Responses;


public class AddNFeInStorageResponse : BaseResponse
{
    public NFe Nfe {get; set;}

    public string Directory {get; set;}
    public string Comentary {get; set;}
}