using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class UserModel : PropertyChangeNotification
    {
        private string email;
        private string password;
        private string message;
        private string emailMessage;
        private string passwordMessage;
        

        public string Email
        {
            get => email;
            set
            {
                if (email != value)
                {
                    email = value;
                    NotifyPropertyChanged();
                    EmailMessage = string.Empty;
                    Message = string.Empty;
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    NotifyPropertyChanged();
                    PasswordMessage = string.Empty;
                    Message = string.Empty;
                }
            }
        }

        public string EmailMessage
        {
            get => emailMessage;
            set
            {
                if (emailMessage != value)
                {
                    emailMessage = value;
                    NotifyPropertyChanged();

                }
            }
        }
        public string PasswordMessage
        {
            get => PasswordMessage;
            set
            {
                if (passwordMessage != value)
                {
                    passwordMessage = value;
                    NotifyPropertyChanged();
                    
                }
            }
        }

        public string Message
        {
            get => message;
            set
            {
                if (message != value)
                {
                    password = value;
                    NotifyPropertyChanged();
                  
                }
            }
        }

    }
}
