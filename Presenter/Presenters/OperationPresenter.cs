namespace Presenter
{
    public class OperationPresenter : IOperationPresenter
    {
        
        public OperationPresenter() { 
            // Inject dependencies from DI IoC Container
        }

        public void Addition(double x, double y)
        {
            double result = x + y;

        }

        public void Division(double x, double y)
        {
            throw new System.NotImplementedException();
        }

        public void Multiplication(double x, double y)
        {
            throw new System.NotImplementedException();
        }

        public void Substraction(double x, double y)
        {
            throw new System.NotImplementedException();
        }
    }
}
