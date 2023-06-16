
namespace TheKittyProblem
{
    internal class View
    {
        private IController _controller;

        public View(IController controller)
        {
            this._controller = controller;
        }

        internal void interact()
        {
            this._controller.doSome();
        }
    }
}