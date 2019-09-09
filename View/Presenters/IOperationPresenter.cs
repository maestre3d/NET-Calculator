namespace Presenter
{
    public interface IOperationPresenter
    {
        /// <summary>
        /// Addition operation
        /// </summary>
        /// <param name="x">Value 1</param>
        /// <param name="y">Value 2</param>
        void Addition(Model.Operation operation);
        /// <summary>
        /// Subtract operation
        /// </summary>
        /// <param name="x">Value 1</param>
        /// <param name="y">Value 2</param>
        void Substraction(Model.Operation operation);
        /// <summary>
        /// Multiply operation
        /// </summary>
        /// <param name="x">Value 1</param>
        /// <param name="y">Value 2</param>
        void Multiplication(Model.Operation operation);
        /// <summary>
        /// Division operation
        /// </summary>
        /// <param name="x">Value 1</param>
        /// <param name="y">Value 2</param>
        void Division(Model.Operation operation);
    }
}
