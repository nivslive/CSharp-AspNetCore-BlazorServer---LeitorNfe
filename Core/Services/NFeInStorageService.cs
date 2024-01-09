namespace LeitorNfe.Core.Services;

using System.Threading.Tasks;
using LeitorNfe.Data;
using LeitorNfe.Core.Models;
using LeitorNfe.Core.Models.DTOs;
using LeitorNfe.Core.Services.Responses;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
public interface INFeInStorageService
{
    Task<GetNFesInStorageResponse> GetNFes();
    Task<AddNFeInStorageResponse> AddNFe(AddNFeInStorageForm AddNFeForm);
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

    public async Task<GetNFesInStorageResponse> GetNFes()
    {
        var response = new GetNFesInStorageResponse();
        try 
        {
            using (var context = _factory.CreateDbContext())
            {
                var nfes = await context.NFesInStorage.Include(m => m.NFe).ToListAsync();
                response.NFesInStorage = nfes;
                response.Message = "NFes saved on storage List";
                response.StatusCode = 200;
            }
        }
        catch (Exception ex)
        {
            response.NFesInStorage = null;
            response.StatusCode = 500;
            response.Message = "Error Retrieving NFes: " + ex.Message;
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
                response.StatusCode = 404;
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

    public async Task<AddNFeInStorageResponse> AddNFe(AddNFeInStorageForm form)
    {
        var response = new AddNFeInStorageResponse();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                context.Add(new NFeInStorage {
                    NFe = form.NFe,
                    Directory = form.Directory,
                    Comentary = "",
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
