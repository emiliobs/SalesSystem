using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.ViewModels
{
    public class LoginViewModel : UserModel
    {
        private object[] campos;

        public LoginViewModel(object[] campos)
        {
            this.campos = campos;
        }
    }
}
