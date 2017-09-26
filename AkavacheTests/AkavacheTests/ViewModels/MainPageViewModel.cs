using MvvmHelpers;
using Prism.Mvvm;
using Prism.Navigation;
using AkavacheTests.Services;
using AkavacheTests.Rest.Dtos;


namespace AkavacheTests.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigatingAware
    {
        public ObservableRangeCollection<PhotoDto> Photos { get; } = new ObservableRangeCollection<PhotoDto>();

        private PhotoService _photoService;

        public MainPageViewModel(PhotoService photoService)
        {
            _photoService = photoService;
        }

        public async void OnNavigatingTo(NavigationParameters parameters)
        {
            var photos = await _photoService.GetPhotosAsync();
            Photos.ReplaceRange(photos);
        }
    }
}
