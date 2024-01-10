using LeitorNfe.Core.Models;

namespace LeitorNfe.Core.Services.Responses;


public class UpdateNFeInStorageResponse : BaseResponse
{
    public NFeInStorage? NFeInStorage {get; set;}
}