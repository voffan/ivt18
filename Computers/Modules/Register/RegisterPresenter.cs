using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Modules.Register
{
    public interface IRegisterPresenter
    {
        IRegisterView View { get; set; }
        void PresentRegisterError(FirebaseAuthException e);
        void PresentValidationError(bool isValidEmail, bool isValidPassword);
    }
    class RegisterPresenter : IRegisterPresenter
    {
        public IRegisterView View { get; set; }

        public void PresentRegisterError(FirebaseAuthException e)
        {
            string localizedReason = "Ошибка";
            switch (e.Reason)
            {
                case AuthErrorReason.UnknownEmailAddress:
                    localizedReason = "Пользователя с таким email не существует";
                    break;
                case AuthErrorReason.UserDisabled:
                    localizedReason = "Пользователь заблокирован";
                    break;
                case AuthErrorReason.WrongPassword:
                    localizedReason = "Неверный пароль";
                    break;
                case AuthErrorReason.TooManyAttemptsTryLater:
                    localizedReason = "Слишком много попыток. Повторите позже.";
                    break;
                case AuthErrorReason.WeakPassword:
                    localizedReason = "Слишком простой пароль";
                    break;
                case AuthErrorReason.SystemError:
                    localizedReason = "Что то пошло не так";
                    break;
            }
            View.ShowRegisterError(localizedReason);
        }

        public void PresentValidationError(bool isValidEmail, bool isValidPassword)
        {
            string localizedMessage = null;
            if (!isValidPassword)
            {
                localizedMessage = "Простой пароль";
            }
            if (!isValidEmail)
            {
                localizedMessage = "Не Email";
            }
            View.ShowValidationError(localizedMessage);
        }
    }
}
