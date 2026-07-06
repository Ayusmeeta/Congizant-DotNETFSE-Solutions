namespace Factory_Method_Pattern
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel Document...");
        }
    }
}
