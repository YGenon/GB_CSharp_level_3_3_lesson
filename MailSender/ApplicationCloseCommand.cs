using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

namespace MailSender
{
	public class ApplicationCloseCommand : MarkupExtension, ICommand
	{
		public override object ProvideValue(IServiceProvider serviceProvider) => this;
		private event EventHandler _CanExecuteChanged;
		public event EventHandler CanExecuteChanged
		{
			add
			{
				_CanExecuteChanged += value;
				CommandManager.RequerySuggested += value;
			}
			remove
			{
				_CanExecuteChanged -= value;
				CommandManager.RequerySuggested -= value;
			}
		}
		public void Execute(object parameter) => Application.Current.Shutdown();
		public bool CanExecute(object parameter) => true;
	}
}