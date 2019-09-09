///////////////////////////////////////////////////////////////////////////////
//  Calculator
//
//  Copyright (c) 2019, Alonso R.
//  License GNU Affero v3

using System;
using Presenter;
using Resources;

namespace View
{
    public class MainView: IMainView
    {
        private readonly IOperationPresenter _presenter;

        public MainView()
        {
            _presenter = new OperationPresenter(this);
            Initialize();
        }

        public void Print(string args)
        {
            Console.WriteLine(args);
        }

        public void Clear()
        {
            Console.Clear();
        }

        protected void Initialize()
        {
            bool OUTPUT = false;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(Resource.HEADER);
                    Console.WriteLine(Resource.MENU.Replace("\\n", "\n"));
                    int option = int.Parse(Console.ReadLine());

                    if ( option >= 1 && option < 5 )
                    {
                        Console.WriteLine(Resource.PRE_VALUES);
                        Console.Write("X = ");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Y = ");
                        double y = double.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (option)
                        {
                            case 1:
                                _presenter.Addition(x, y);
                                break;
                            case 2:
                                _presenter.Substraction(x, y);
                                break;
                            case 3:
                                _presenter.Multiplication(x, y);
                                break;
                            case 4:
                                _presenter.Division(x, y);
                                break;
                            default:
                                throw new Exception(Resource.GENERIC_ERROR);
                        }
                    }
                    else if ( option == 5 )
                    {
                        _presenter.ShowInformation();
                    }

                    string response;

                    do
                    {
                        Console.WriteLine(Resource.LOOP_QUESTION);
                        response = Console.ReadLine();

                        if (response.ToLower() == "y" || response.ToLower() == "n")
                        {
                            OUTPUT = response.ToLower() == "y" ? true : false;
                        }
                        else
                        {
                            Console.WriteLine(Resource.GENERIC_ERROR);
                        }
                    } while (response == null && (response != "y" || response != "n"));
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format(Resource.ERROR, e.Message));
                    Console.ReadLine();
                    OUTPUT = true;
                    continue;
                }
            } while ( OUTPUT == true );
        }
    }
}
