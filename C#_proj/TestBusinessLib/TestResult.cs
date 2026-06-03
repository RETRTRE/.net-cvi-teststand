using System;

namespace TestBusinessLib
{
    public class TestResult
    {
        public string ProductModel { get; set; }
        public double MeasuredValue { get; set; }
        public double MinLimit { get; set; }
        public double MaxLimit { get; set; }
        public bool Passed { get; set; }
        public string Message { get; set; }
    }
}
