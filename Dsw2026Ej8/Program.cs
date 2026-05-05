namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World");
            Sale retailSale = new RetailSale(100);
            Sale wholeSale = new WholesaleSale(100);

            Console.WriteLine(Problema5.ObtenerImporteFinal(retailSale));
            Console.WriteLine(Problema5.ObtenerImporteFinal(wholeSale));
        }
    }   
}
