namespace Solid.ISP.Example2.Violation
{
    public class Document
    {
        
    }

    public interface IMachine{
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultiFunctionalPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new System.NotImplementedException();
        }
    }

    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //don't use this
            throw new System.NotImplementedException();            
        }

        public void Print(Document d)
        {
            //use this
        }

        public void Scan(Document d)
        {
            //don't use this
            throw new System.NotImplementedException();
        }
    }
}