using System;
using System.Windows.Forms;
using TestBusinessLib;

namespace TestBusinessDemo
{
    public partial class Form1 : Form
    {
        private TestService _testService;
        private TestResult _lastResult;

        public Form1()
        {
            InitializeComponent();
            _testService = new TestService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbModel.SelectedIndex = 0;
        }

        private ProductModel GetSelectedModel()
        {
            if (cmbModel.SelectedItem == null)
            {
                throw new Exception("请先选择产品型号。");
            }

            return (ProductModel)Enum.Parse(typeof(ProductModel), cmbModel.SelectedItem.ToString());
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProductModel model = GetSelectedModel();
                RangeInfo range = _testService.GetRangeByModel(model);
                lblRange.Text = $"当前范围：{range.MinValue} V ~ {range.MaxValue} V";
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新范围失败：" + ex.Message);
            }
        }

        private void btnLoadRange_Click(object sender, EventArgs e)
        {
            try
            {
                ProductModel model = GetSelectedModel();
                RangeInfo range = _testService.GetRangeByModel(model);
                lblRange.Text = $"当前范围：{range.MinValue} V ~ {range.MaxValue} V";
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取范围失败：" + ex.Message);
            }
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                double measuredValue;
                if (!double.TryParse(txtMeasuredValue.Text, out measuredValue))
                {
                    MessageBox.Show("请输入有效的测量值。");
                    return;
                }

                ProductModel model = GetSelectedModel();
                _lastResult = _testService.EvaluateResult(model, measuredValue);

                lblResult.Text =
                    $"结论：{_lastResult.Message}，测量值：{_lastResult.MeasuredValue} V";
            }
            catch (Exception ex)
            {
                MessageBox.Show("结果判断失败：" + ex.Message);
            }
        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {
            try
            {
                if (_lastResult == null)
                {
                    MessageBox.Show("请先执行结果判断。");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON Files (*.json)|*.json";
                saveFileDialog.FileName = "TestResult.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = _testService.ExportReport(_lastResult, saveFileDialog.FileName);
                    MessageBox.Show("JSON 导出成功：" + path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出 JSON 失败：" + ex.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtMeasuredValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}