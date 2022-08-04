using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using DemoAutomation.Pages;

namespace DemoAutomation.Interactions
{
    internal class Login
    {
        public static ITask With (string user, string password)
        {
            return RunTasks.InOrder(
            SendKeys.To(LoginPage.TxtUser, user),
            SendKeys.To(LoginPage.TxtPassword, password),
            Click.On(LoginPage.BtnIngresar)
            );
        }
    }
}
