using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itau.Validators
{
    public class PasswordValidator : IPassword
    {
        private bool _result { get; set; }
        private string _password { get; set; }
        public PasswordValidator(string password)
        {
            _password = password;
            _result = true;
        }
        public void hasLowercase()
        {
            if (!_password.Any(char.IsLower))
            {
                _result = false;
            }
        }
        public void hasNumber()
        {
            if (!_password.Any(char.IsDigit))
            {
                _result = false;
            }
        }
        public void hasRepeatedCharacter()
        {
            if (_password.Distinct().Count() != _password.Length)
            {
                _result = false;
            }
        }
        public void hasSpecialCharacter()
        {
            if (!_password.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                _result = false;
            }
        }
        public void hasUppercase()
        {
            if (!_password.Any(char.IsUpper))
            {
                _result = false;
            }
        }

        public void sizeValidation()
        {
            if (_password.Length < 9 )
            {
                _result = false;
            }
        }

        public bool validate()
        {
            return _result;
        }
    }
}
