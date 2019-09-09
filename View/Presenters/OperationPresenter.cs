///////////////////////////////////////////////////////////////////////////////
//  Calculator
//
//  Copyright (c) 2019, Alonso R.
//  License GNU Affero v3

using System.Collections.Generic;
using View;

namespace Presenter
{
    public class OperationPresenter : IOperationPresenter
    {
        private readonly IMainView _view;
        private static Model.Operation _model;
        private static List<string> operationCache;

        public OperationPresenter(IMainView view) {
            // Inject dependencies from DI IoC Container
            this._view = view;
            _model = new Model.Operation();
            operationCache = new List<string>();
        }

        public void Addition(double x, double y)
        {
            _model.operator1 = x;
            _model.operator2 = y;

            double result = _model.operator1 + _model.operator2;
            this._view.Print($"{x} + {y} = {result}");

            // Save to cache
            operationCache.Add($"{x} + {y} = {result}");
        }

        public void Substraction(double x, double y)
        {
            _model.operator1 = x;
            _model.operator2 = y;

            double result = _model.operator1 - _model.operator2;
            this._view.Print($"{x} - {y} = {result}");

            // Save to cache
            operationCache.Add($"{x} - {y} = {result}");
        }

        public void Multiplication(double x, double y)
        {
            _model.operator1 = x;
            _model.operator2 = y;

            double result = _model.operator1 * _model.operator2;
            this._view.Print($"{x} * {y} = {result}");

            // Save to cache
            operationCache.Add($"{x} * {y} = {result}");
        }

        public void Division(double x, double y)
        {
            _model.operator1 = x;
            _model.operator2 = y;

            double result = _model.operator1 / _model.operator2;
            this._view.Print($"{x} / {y} = {result}");

            // Save to cache
            operationCache.Add($"{x} / {y} = {result}");
        }

        public void ShowInformation()
        {
            this._view.Clear();

            operationCache.ForEach(x =>
            {
                this._view.Print(x);
            });
        }
    }
}
