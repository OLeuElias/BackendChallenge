using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itau.Validators
{
    public interface IPassword
    {
        void sizeValidation();
        void hasUppercase();
        void hasLowercase();
        void hasNumber();
        void hasSpecialCharacter();
        void hasRepeatedCharacter();
        bool validate();

    }
}
