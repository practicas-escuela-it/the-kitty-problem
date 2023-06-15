namespace TheKittyProblem
{
    internal class Controller : IController
    {
        private IRepository _respository;

        public Controller(IRepository respository)
        {
            this._respository = respository;
        }

        public void doSome()
        {
            throw new NotImplementedException();
        }
    }
}