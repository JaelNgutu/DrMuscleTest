using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DrMuscleTest.Helpers;
using DrMuscleTest.Views.Pages;
using MvvmHelpers;
using Xamarin.Forms;

namespace DrMuscleTest.ViewModels
{
    public class LandingViewModel : BaseViewModel
    {
        /// <summary>
        /// List of Image Items binded to UI
        /// </summary>
        ObservableRangeCollection<object> _carouselImages;
        public ObservableRangeCollection<object> CarouselImages
        {
            get { return _carouselImages; }
            set
            {
                _carouselImages = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The current position of the Carousel
        /// </summary>
        int _carouselPosition;
        public int CarouselPosition
        {
            get { return _carouselPosition; }
            set
            {
                _carouselPosition = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Icon displayed on Welcome screens and Page Title Bars
        /// </summary>
        private string _logo;
        public string Logo
        {
            get { return _logo; }
            set
            {
                _logo = value;
                OnPropertyChanged();
            }
        }

        public LandingViewModel()
        {
            LoadImages();
            LoadLogoImage();
        }

        private void LoadImages()
        {
            CarouselImages = new ObservableRangeCollection<object>();

            CarouselImages.AddRange(new List<object>
            {
                new {  ImageSource = ImageHelper.ReturnImageSourceFromFile("firstpage") },
                new {  ImageSource = ImageHelper.ReturnImageSourceFromFile("secondpage") }
            });

            CarouselPosition = 0;
        }



        private void LoadLogoImage()
        {
            Logo = ImageHelper.ReturnImageSourceFromFile("logo");
        }

        async Task GoToSignupPage()
        {
            Application.Current.MainPage = new NavigationPage(new SignupPage());
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }

        ICommand _signUpCommand = null;

        public ICommand SignUpCommand
        {
            get
            {
                return _signUpCommand ?? (_signUpCommand =
                                          new Command(async () => await GoToSignupPage()));
            }
        }
    }
}
