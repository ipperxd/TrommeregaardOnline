using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using Trommeregaard.API.Data;
using Trommeregaard.API.Models;
using Trommeregaard.API.Models.DTO;

namespace Trommeregaard.API.Service;
public class CowService(TrommeregaardAPIContext context) : ICowService
{
    public Task<Cow> CreateCowAsync(CowDTO cowDTO)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Models.Cow>> GetAllCowsAsync()
    {
        List<Cow> listOfCows = await context.Cow.ToListAsync();
        return listOfCows;
    }

    public Task<Cow?> GetCowByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Cow?> UpdateCowAsync(int id, Cow cow)
    {
        throw new NotImplementedException();
    }
}
