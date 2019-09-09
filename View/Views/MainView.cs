using System;
using Presenter;

namespace View
{
    public class MainView: IMainView
    {
        private readonly IOperationPresenter _presenter;
        private Model.Operation operation;

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
                    Console.WriteLine(" *** C A L C U L A T O R    0.1a *** ");
                    Console.WriteLine("Select an option:\n1.  Addition\n2.  Substraction\n3.  Multiplication\n4.  Division");
                    int option = int.Parse(Console.ReadLine());

                    if ( option >= 1 && option < 5 )
                    {
                        operation = new Model.Operation();

                        Console.WriteLine("Insert data (x , y):");
                        Console.Write("X = ");
                        operation.operator1 = double.Parse(Console.ReadLine());
                        Console.Write("Y = ");
                        operation.operator2 = double.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (option)
                        {
                            case 1:
                                _presenter.Addition(operation);
                                break;
                            case 2:
                                _presenter.Substraction(operation);
                                break;
                            case 3:
                                _presenter.Multiplication(operation);
                                break;
                            case 4:
                                _presenter.Division(operation);
                                break;
                            default:
                                throw new Exception("Select a valid option.");
                        }
                    }

                    string response;

                    do
                    {
                        Console.WriteLine("Do you want to do another operation? (Y\\n)");
                        response = Console.ReadLine();

                        if (response.ToLower() == "y" || response.ToLower() == "n")
                        {
                            OUTPUT = response.ToLower() == "y" ? true : false;
                        }
                        else
                        {
                            Console.WriteLine("Select a valid option.");
                        }
                    } while (response == null && (response != "y" || response != "n"));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR: {e.Message}");
                    Console.ReadLine();
                    OUTPUT = true;
                    continue;
                }
            } while ( OUTPUT == true );
        }
    }
}
