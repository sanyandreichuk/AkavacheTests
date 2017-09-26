using System;
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

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            _photoService.GetPhotos().Subscribe(photos => Photos.ReplaceRange(photos));           
        }
    }
}
