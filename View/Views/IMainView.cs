///////////////////////////////////////////////////////////////////////////////
//  Calculator
//
//  Copyright (c) 2019, Alonso R.
//  License GNU Affero v3

namespace View
{
    public interface IMainView
    {
        /// <summary>
        /// Print an output
        /// </summary>
        /// <param name="args"></param>
        void Print(string args);

        /// <summary>
        /// Clear all outputs
        /// </summary>
        void Clear();
    }
}
