using Boa.Constrictor.Screenplay;
using System.Threading;

namespace DemoAutomation.Interactions
{
    internal class Espera : ITask
    {
        #region metodos instanciadores
        public static Espera UnTiempo(string tiempo)
        {
            return new Espera(tiempo);
        }
        #endregion

        #region metodo constructor
        public Espera(string tiempo)
        {
            this.tiempo = tiempo;
        }
        #endregion

        #region variables

        readonly string tiempo;

        #endregion

        public void PerformAs(IActor cualquierActor)
        {
            Thread.Sleep( int.Parse(tiempo) );
        }

    }
}
