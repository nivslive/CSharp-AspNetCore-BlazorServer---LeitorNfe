using LeitorNfe.Core.Models;

namespace LeitorNfe.Core.Services.Responses;


public class GetNFesInStorageResponse : BaseResponse
{
    public List<NFeInStorage>? NFesInStorage {get; set;}
}