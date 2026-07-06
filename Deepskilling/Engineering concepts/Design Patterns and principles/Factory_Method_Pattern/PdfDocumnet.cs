namespace Factory_Method_Pattern
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document...");
        }
    }
}