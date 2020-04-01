using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MailSender.Service;

namespace MailSender.ViewModel
{
	public class MainWindowViewModel : ViewModelBase
	{
		private readonly IDataAccessService _dataService;
		private ObservableCollection<Emails> _emails = new ObservableCollection<Emails>();

		public ObservableCollection<Emails> Emails
		{
			get => _emails;
			set
			{
				Set(ref _emails, value);
				//if (Equals(_emails, value)) return;
				//_emails = value;
				//RaisePropertyChanged(nameof(Emails));
			}
		}
		private Emails _currentEmail = new Emails();
		public Emails CurrentEmail
		{
			get => _currentEmail;
			set => Set(ref _currentEmail, value);
		}

		public RelayCommand<Emails> SaveEmailCommand { get; }
		public RelayCommand ReadAllMailsCommand { get; }
		public RelayCommand SearchMailsCommand { get; set; }

		private string searchText = "";

		public void SetSearchText(string value)
		{ searchText = value; }

		public MainWindowViewModel(IDataAccessService dataService)
		{
			_dataService = dataService;
			 
			ReadAllMailsCommand = new RelayCommand(GetEmails);

			SearchMailsCommand = new RelayCommand(SearhEmails); 			

			SaveEmailCommand = new RelayCommand<Emails>(SaveEmail);
		}

		private void SaveEmail(Emails email)
		{
			email.Id = _dataService.CreateEmail(email);
			if (email.Id == 0) return;
			Emails.Add(email);
		}

		private void GetEmails() => Emails = _dataService.GetEmails();

		private void SearhEmails()
		{
			//MessageBox.Show("Ищем");
			Emails.Clear();
		}
	}
}
