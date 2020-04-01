using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MailSender.Service;

namespace MailSender.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
			
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<IDataAccessService, DataBaseAccessService>();
		}

        public MainWindowViewModel Main => ServiceLocator.Current.GetInstance<MainWindowViewModel>();
    }
}