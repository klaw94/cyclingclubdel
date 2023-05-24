using CyclingClub.Data;
using CyclingClub.FieldValidators;
using CyclingClub.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingClub
{
    public static class Factory
    {
        public static IView GetMainViewObject()
        {
            ILogin login = new LoginUser();
            IRegister register = new RegisterUser();
            IFieldValidator userRegistrationValidator = new UserRegistrationValidator(register);
            userRegistrationValidator.InitialiseValidatorDelegates();

            IView registerView = new UserRegistrationView(userRegistrationValidator, register);
            IView loginView = new UserLoginView(login);
            IView mainView = new MainView(registerView, loginView);

            return mainView;

        }
    }
}
