using System;

namespace TestBusinessLib
{
    public class TestService
    {
        private readonly RangeManager _rangeManager;
        private readonly ReportManager _reportManager;

        public TestService()
        {
            _rangeManager = new RangeManager();
            _reportManager = new ReportManager();
        }

        /// <summary>
        /// 获取指定型号的范围
        /// </summary>
        public RangeInfo GetRangeByModel(ProductModel model)
        {
            return _rangeManager.GetRange(model);
        }

        /// <summary>
        /// 根据型号和采集值进行测试判定
        /// </summary>
        public TestResult EvaluateResult(ProductModel model, double measuredValue)
        {
            return _rangeManager.Evaluate(model, measuredValue);
        }

        /// <summary>
        /// 导出 JSON 报告
        /// </summary>
        public string ExportReport(TestResult result, string filePath)
        {
            return _reportManager.ExportToJson(result, filePath);
        }
    }
}