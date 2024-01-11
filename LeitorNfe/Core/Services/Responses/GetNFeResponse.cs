using LeitorNfe.Core.Models;

namespace LeitorNfe.Core.Services.Responses;


public class GetNFeResponse : BaseResponse
{
    public NFe NFe {get; set;}
}