using System;
using TestBusinessLib;

class Program
{
    static void Main(string[] args)
    {
        TestService service = new TestService();

        ProductModel model = ProductModel.UUT1;
        double measuredValue = 4.2;

        TestResult result = service.EvaluateResult(model, measuredValue);

        Console.WriteLine($"Model: {result.ProductModel}");
        Console.WriteLine($"Measured: {result.MeasuredValue}");
        Console.WriteLine($"Range: [{result.MinLimit}, {result.MaxLimit}]");
        Console.WriteLine($"Result: {result.Message}");

        string path = service.ExportReport(result, "result.json");
        Console.WriteLine($"Report saved: {path}");
    }
}