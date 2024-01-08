using LeitorNfe.Core.Models;

namespace LeitorNfe.Core.Services.Responses;


public class GetNFesResponse : BaseResponse
{
    public List<NFe>? NFes {get; set;}
}