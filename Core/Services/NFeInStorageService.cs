namespace blazor.Services;

using System.Threading.Tasks;
using LeitorNfe.Data;
using LeitorNfe.Core.Models;
using LeitorNfe.Core.Models.DTOs;
using LeitorNfe.Core.Services.Responses;
using Microsoft.EntityFrameworkCore;

public interface INFeInStorageService
{
    Task<GetNFesResponse> GetNFes();
    Task<AddNFeResponse> AddNFe(AddNFeInStorageForm AddNFeForm);
    Task<BaseResponse> DeleteNFe(NFe nfe);
    Task<UpdateNFeResponse> UpdateNFe(NFe nfe);
    Task<GetNFeResponse> GetNFe(int id);
}

public class NFeInStorageService : INFeInStorageService
{
    private readonly IDbContextFactory<DataContext> _factory;

    public NFeInStorageService(IDbContextFactory<DataContext> factory)
    {
        _factory = factory;
    }

    public async Task<GetNFesResponse> GetNFes()
    {
        var response = new GetNFesResponse();
        try 
        {
            using (var context = _factory.CreateDbContext())
            {
                var nfes = await context.NFes.ToListAsync();
                response.NFes = nfes;
                response.Message = "NFes List";
                response.StatusCode = 200;
            }
        }
        catch (Exception ex)
        {
            response.NFes = null;
            response.StatusCode = 500;
            response.Message = "Error Retrieving NFe: " + ex.Message;
        }

        return response;
    }

    public async Task<GetNFeResponse> GetNFe(int id)
    {
        GetNFeResponse response = new();
        try
        {
            using var context = _factory.CreateDbContext();
            var nfe = await context.NFes.FirstOrDefaultAsync(x => x.Id == id);
            if (nfe != null)
            {
                response.StatusCode = 200;
                response.Message = "NFe successfully found!";
                response.NFe = nfe;
            }
            else
            {
                response.StatusCode = 404; // Not Found
                response.Message = "NFe not found.";
            }
        }
        catch(Exception ex)
        {
            response.StatusCode = 500;
            response.Message = $"An error occurred: {ex.Message}";
        }

        return response;
    }

    public async Task<BaseResponse> DeleteNFe(NFe nfe)
    {
        BaseResponse response = new();
        try
        {
            using var context = _factory.CreateDbContext();
            context.Remove(nfe);
            var result = await context.SaveChangesAsync();
            if(result == 1)
            {
                response.StatusCode = 200;
                response.Message = "NFe deleted succesfully!";
            }
            else
            {
                response.StatusCode = 400;
                response.Message = "Error while deleting NFe.";                    
            }
        } catch(Exception ex)
        {
            response.StatusCode = 500;
            response.Message = $"Error Deleting NFe of Id: {nfe.Id} | Error message:" + ex.Message;
        }
        return response;
    }


    public async Task<UpdateNFeResponse> UpdateNFe(NFe nfe)
    {
        UpdateNFeResponse response = new();

        try
        {
            using var context = _factory.CreateDbContext();
            context.Update(nfe);
            var result = await context.SaveChangesAsync();
            if(result == 1)
            {
                response.NFe = nfe;
                response.StatusCode = 200;
                response.Message = "NFe updated succesfully!";
            }
            else
            {
                response.NFe = null;
                response.StatusCode = 400;
                response.Message = "Error while updating NFe.";                    
            }
        } catch(Exception ex)
        {
            response.StatusCode = 500;
            response.Message = $"Error Updating NFe of Id: {nfe.Id} | Error message:" + ex.Message;
        }
        return response;
    }

    public async Task<AddNFeResponse> AddNFe(AddNFeInStorageForm form)
    {
        var response = new AddNFeResponse();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                context.Add(new NFe
                {
                    // aqui coloque todos os inputs necessarios.
                });

                var result = await context.SaveChangesAsync();

                if(result == 1)
                {
                    response.StatusCode = 200;
                    response.Message = "NFe created succesfully!";
                }
                else
                {
                    response.StatusCode = 400;
                    response.Message = "Error while creating NFe.";                    
                }
            }
        } catch(Exception ex)
        {
            response.StatusCode = 500;
            response.Message = "Error Retrieving NFes: " + ex.Message;
        }

        return response;
    }
}
