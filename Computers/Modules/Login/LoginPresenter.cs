﻿using Computers.Modules.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;

namespace Computers.Modules
{
    public interface ILoginPresenter
    {
        ILoginView View { get; set; }
        void PresentAuthError(FirebaseAuthException e);
        void PresentValidationError(bool isValidEmail, bool isValidPassword);
    }
    public class LoginPresenter : ILoginPresenter
    {
        public ILoginView View { get; set; }

        public void PresentAuthError(FirebaseAuthException e)
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
            }
            View.ShowAuthError(localizedReason);
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
