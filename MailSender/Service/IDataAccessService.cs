using System.Collections.ObjectModel;

namespace MailSender.Service
{
	public interface IDataAccessService
	{
		ObservableCollection<Emails> GetEmails();
		int CreateEmail(Emails email);
	}
}