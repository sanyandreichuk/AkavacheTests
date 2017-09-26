using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;
using Akavache;
using AkavacheTests.Rest;
using AkavacheTests.Rest.Dtos;



namespace AkavacheTests.Services
{
    public class PhotoService
    {
        public IObservable<IEnumerable<PhotoDto>> GetPhotos()
        {
            return BlobCache.LocalMachine.GetAndFetchLatest("photos", () => GetRemotePhotosAsync());
        }

        private Task<IEnumerable<PhotoDto>> GetRemotePhotosAsync()
        {
            var restApiService = RestService.For<IRestApiService>("http://jsonplaceholder.typicode.com");
            return restApiService.GetPhotosAsync();
        }
    }
}
