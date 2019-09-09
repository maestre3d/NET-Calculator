using View;

namespace Presenter
{
    public class OperationPresenter : IOperationPresenter
    {
        private readonly IMainView _view;

        public OperationPresenter(IMainView view) {
            // Inject dependencies from DI IoC Container
            this._view = view;
        }

        public void Addition(Model.Operation operation)
        {
            double result = operation.operator1 + operation.operator2;
            this._view.Print($"{operation.operator1} + {operation.operator2} = {result}");
        }

        public void Division(Model.Operation operation)
        {
            double result = operation.operator1 / operation.operator2;
            this._view.Print($"{operation.operator1} / {operation.operator2} = {result}");
        }

        public void Multiplication(Model.Operation operation)
        {
            double result = operation.operator1 * operation.operator2;
            this._view.Print($"{operation.operator1} * {operation.operator2} = {result}");
        }

        public void Substraction(Model.Operation operation)
        {
            double result = operation.operator1 - operation.operator2;
            this._view.Print($"{operation.operator1} - {operation.operator2} = {result}");
        }
    }
}
