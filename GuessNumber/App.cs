using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class App
    {
        readonly IInputReader inputPromt;
        readonly IMatrixBuilder builder;
        readonly IPrinter printer;

        public App(IInputReader inputPromt, IMatrixBuilder builder, IPrinter printer)
        {
            this.inputPromt = inputPromt;
            this.builder = builder;
            this.printer = printer;
        }

        public void Run()
        {
            inputPromt.ReadInput();
            builder.BuildMatrix(inputPromt.RowsInput, inputPromt.ColsInput);
            printer.Print(builder.MatrixArray);
            printer.Print(builder.MatrixTrail);
        }

    }

}
