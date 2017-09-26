using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;
using AkavacheTests.Rest.Dtos;


namespace AkavacheTests.Rest
{
    public interface IRestApiService
    {
        [Get("/photos")]
        Task<IEnumerable<PhotoDto>> GetPhotosAsync();
    }
}
