///////////////////////////////////////////////////////////////////////////////
//  Calculator
//
//  Copyright (c) 2019, Alonso R.
//  License GNU Affero v3

namespace Presenter
{
    public interface IOperationPresenter
    {
        /// <summary>
        /// Addition operation
        /// </summary>
        /// <param name="x">Value 1</param>
        /// <param name="y">Value 2</param>
        void Addition(double x, double y);
        /// <summary>
        /// Subtract operation
        /// </summary>
        /// <param name="x">Value 1</param>
        /// <param name="y">Value 2</param>
        void Substraction(double x, double y);
        /// <summary>
        /// Multiply operation
        /// </summary>
        /// <param name="x">Value 1</param>
        /// <param name="y">Value 2</param>
        void Multiplication(double x, double y);
        /// <summary>
        /// Division operation
        /// </summary>
        /// <param name="x">Value 1</param>
        /// <param name="y">Value 2</param>
        void Division(double x, double y);

        /// <summary>
        /// Show current operations in cache
        /// </summary>
        void ShowInformation();
    }
}
