using Sales.Library;
using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Sales.ViewModels
{
    public class LoginViewModel : UserModel
    {
        private object[] campos;
        private ICommand command;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private string date = DateTime.Now.ToString("dd/MMM/yyy");
        private Frame rootFrame = Window.Current.Content as Frame;

        public LoginViewModel(object[] campos)
        {
            this.campos = campos;

            this.textBoxEmail = (TextBox)campos[0];
            this.textBoxPassword = (TextBox)campos[1];
        }


        public ICommand IniciarCommand
        {
            get => command ?? (command = new CommandHandler( async () => { await IniciarAsync();  } ));
        }

        private async Task IniciarAsync()
        {
            if (string.IsNullOrEmpty(Email))
            {
                EmailMessage = "Enter an Email.";
                textBoxEmail.Focus(FocusState.Programmatic);

                return;
            }

            if (!TextBoxEvent.IsValidEmail(Email))
            {
                EmailMessage = "The Email is not Valid.";
                textBoxEmail.Focus(FocusState.Programmatic);
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                PasswordMessage = "Enter a Password.";
                textBoxPassword.Focus(FocusState.Programmatic);

                return;

            }


            var data1 = Email;
            var data2 = Password; 

        }
    }
}
