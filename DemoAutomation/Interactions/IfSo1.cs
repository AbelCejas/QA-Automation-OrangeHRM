using Boa.Constrictor.Screenplay;

namespace DemoAutomation.Interactions
{
    internal class IfSo1 : ITask
    {
        #region properties
        IQuestion<bool> Cond { get; set; }
        ITask So { get; }
        #endregion

        public IfSo1(IQuestion<bool> condition, ITask then)
        {
            Cond = condition;
            So = then;
        }
        public static IfSo1 Then(IQuestion<bool> condition, ITask then)
        {
            return new IfSo1(condition, then);
        }
        public void PerformAs(IActor actor)
        {
            if (actor.AskingFor(Cond))
            {
                actor.AttemptsTo(So);
            }

        }
    }
}