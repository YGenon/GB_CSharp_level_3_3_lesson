using System.Collections.Generic;
using GalaSoft.MvvmLight.Ioc;
using MailSender.ViewModel;

namespace MailSender
{
	public static class Resources
	{
		private static readonly Dictionary<string, string> _SendersDictionary;

		public static Dictionary<string, string> GetSendersDictionary()
		{
			return _SendersDictionary;
		}
		public static Dictionary<string, string> SendersDictionary { get; } = new Dictionary<string, string>
		{
			{"qwe@ewq.ru", EncrypterDll.Encrypter.Deencrypt("123")},
			{"qaz@zaq.ru", EncrypterDll.Encrypter.Deencrypt("3241")}
		};

		public static Dictionary<string, int> SmtpServers = new Dictionary<string, int>()
		{
			{ "smtp.yandex.ru", 25 }
		};
	}
}