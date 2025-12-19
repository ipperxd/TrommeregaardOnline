namespace Trommeregaard.API.Service;
public interface ICowService
{
    Task<IEnumerable<Models.Cow>> GetAllCowsAsync();
    Task<Models.Cow?> GetCowByIdAsync(int tagId);
    Task<Models.Cow> CreateCowAsync(Models.DTO.CowDTO cowDTO);
    Task<Models.Cow?> UpdateCowAsync(int id, Models.Cow cow);
}