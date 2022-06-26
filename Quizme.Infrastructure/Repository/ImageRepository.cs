using Quizme.Infrastructure.Context;
using Quizme.Infrastructure.Entities;

namespace Quizme.Infrastructure.Repository;

public class ImageRepository : IImageRepository
{
    private readonly MainContext _mainContext;

    public ImageRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public Task<IEnumerable<Image>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Image> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Image entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Image entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}