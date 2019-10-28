using System;

using GalaSoft.MvvmLight.Ioc;

using WinTSDemo.Services;
using WinTSDemo.Views;

namespace WinTSDemo.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        private static ViewModelLocator _current;

        public static ViewModelLocator Current => _current ?? (_current = new ViewModelLocator());

        private ViewModelLocator()
        {
            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<MainViewModel, MainPage>();
            Register<WebViewViewModel, WebViewPage>();
            Register<MasterDetailViewModel, MasterDetailPage>();
            Register<TreeViewViewModel, TreeViewPage>();
            Register<ContentGridViewModel, ContentGridPage>();
            Register<ContentGridDetailViewModel, ContentGridDetailPage>();
            Register<DataGridViewModel, DataGridPage>();
            Register<TelerikDataGridViewModel, TelerikDataGridPage>();
            Register<ChartViewModel, ChartPage>();
            Register<TabbedViewModel, TabbedPage>();
            Register<MapViewModel, MapPage>();
            Register<CameraViewModel, CameraPage>();
            Register<ImageGalleryViewModel, ImageGalleryPage>();
            Register<ImageGalleryDetailViewModel, ImageGalleryDetailPage>();
            Register<SettingsViewModel, SettingsPage>();
            Register<SchemeActivationSampleViewModel, SchemeActivationSamplePage>();
        }

        public SchemeActivationSampleViewModel SchemeActivationSampleViewModel => SimpleIoc.Default.GetInstance<SchemeActivationSampleViewModel>();

        public SettingsViewModel SettingsViewModel => SimpleIoc.Default.GetInstance<SettingsViewModel>();

        public ImageGalleryDetailViewModel ImageGalleryDetailViewModel => SimpleIoc.Default.GetInstance<ImageGalleryDetailViewModel>();

        public ImageGalleryViewModel ImageGalleryViewModel => SimpleIoc.Default.GetInstance<ImageGalleryViewModel>();

        public CameraViewModel CameraViewModel => SimpleIoc.Default.GetInstance<CameraViewModel>();

        public MapViewModel MapViewModel => SimpleIoc.Default.GetInstance<MapViewModel>();

        public TabbedViewModel TabbedViewModel => SimpleIoc.Default.GetInstance<TabbedViewModel>();

        public ChartViewModel ChartViewModel => SimpleIoc.Default.GetInstance<ChartViewModel>();

        public TelerikDataGridViewModel TelerikDataGridViewModel => SimpleIoc.Default.GetInstance<TelerikDataGridViewModel>();

        public DataGridViewModel DataGridViewModel => SimpleIoc.Default.GetInstance<DataGridViewModel>();

        public ContentGridDetailViewModel ContentGridDetailViewModel => SimpleIoc.Default.GetInstance<ContentGridDetailViewModel>();

        public ContentGridViewModel ContentGridViewModel => SimpleIoc.Default.GetInstance<ContentGridViewModel>();

        public TreeViewViewModel TreeViewViewModel => SimpleIoc.Default.GetInstance<TreeViewViewModel>();

        public MasterDetailViewModel MasterDetailViewModel => SimpleIoc.Default.GetInstance<MasterDetailViewModel>();

        public WebViewViewModel WebViewViewModel => SimpleIoc.Default.GetInstance<WebViewViewModel>();

        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();

        public ShellViewModel ShellViewModel => SimpleIoc.Default.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => SimpleIoc.Default.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
