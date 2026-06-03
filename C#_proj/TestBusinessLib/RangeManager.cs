using System;

namespace TestBusinessLib
{
    public class RangeManager
    {
        /// <summary>
        /// 根据产品型号返回量程范围
        /// UUT1: ±5V
        /// UUT2: ±10V
        /// </summary>
        public RangeInfo GetRange(ProductModel model)
        {
            switch (model)
            {
                case ProductModel.UUT1:
                    return new RangeInfo
                    {
                        ModelName = "UUT1",
                        MinValue = -5.0,
                        MaxValue = 5.0
                    };

                case ProductModel.UUT2:
                    return new RangeInfo
                    {
                        ModelName = "UUT2",
                        MinValue = -10.0,
                        MaxValue = 10.0
                    };

                default:
                    throw new ArgumentOutOfRangeException(nameof(model), "未知产品型号");
            }
        }

        /// <summary>
        /// 根据产品型号和测量值判断是否合格
        /// </summary>
        public TestResult Evaluate(ProductModel model, double measuredValue)
        {
            RangeInfo range = GetRange(model);

            bool passed = measuredValue >= range.MinValue && measuredValue <= range.MaxValue;

            return new TestResult
            {
                ProductModel = range.ModelName,
                MeasuredValue = measuredValue,
                MinLimit = range.MinValue,
                MaxLimit = range.MaxValue,
                Passed = passed,
                Message = passed ? "PASS" : "FAIL"
            };
        }
    }
}