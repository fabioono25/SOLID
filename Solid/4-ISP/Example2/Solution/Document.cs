using System;

namespace Solid.ISP.Example2.Solution
{
    public class Document
    {
        
    }

    public interface IPrinter{
        void Print(Document d);
    }

    public interface IScanner{
        void Scan(Document d);
    }

    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IMultiFunctionDevice: IScanner, IPrinter { //, ...

    }

    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if (printer == null)
                throw new ArgumentNullException(paramName: nameof(printer));

            if (scanner == null)
                throw new ArgumentNullException(paramName: nameof(scanner));                
        
            this.printer = printer;
            this.scanner = scanner;
        }
        
        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        } //decorator pattern
    }
}