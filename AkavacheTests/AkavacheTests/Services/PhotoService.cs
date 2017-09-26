using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;
using AkavacheTests.Rest;
using AkavacheTests.Rest.Dtos;


namespace AkavacheTests.Services
{
    public class PhotoService
    {
        public Task<IEnumerable<PhotoDto>> GetPhotosAsync()
        {
            var restApiService = RestService.For<IRestApiService>("http://jsonplaceholder.typicode.com");
            return restApiService.GetPhotosAsync();
        }
    }
}
