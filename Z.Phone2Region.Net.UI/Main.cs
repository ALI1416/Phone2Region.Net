using System.Windows.Forms;

namespace Z.Phone2Region.Net.UI
{

    /// <summary>
    /// 主界面
    /// </summary>
    public partial class Main : Form
    {

        /// <summary>
        /// 主程序
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置加载状态
        /// </summary>
        /// <param name="status">true开始加载 false加载失败</param>
        private void SetLoadStatus(bool status)
        {
            if (status)
            {
                urlTextBox.ReadOnly = true;
                urlLoadBtn.Enabled = false;
                fileTextBox.ReadOnly = true;
                fileSelectBtn.Enabled = false;
                fileLoadBtn.Enabled = false;
            }
            else
            {
                urlTextBox.ReadOnly = false;
                urlLoadBtn.Enabled = true;
                fileTextBox.ReadOnly = false;
                fileSelectBtn.Enabled = true;
                fileLoadBtn.Enabled = true;
            }
        }

        /// <summary>
        /// 点击加载URL按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UrlLoadBtn_Click(object sender, System.EventArgs e)
        {
            SetLoadStatus(true);
            try
            {
                Phone2Region.initByUrl(urlTextBox.Text);
            }
            catch (Phone2RegionException e1)
            {
                MessageBox.Show(e1.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetLoadStatus(false);
                return;
            }
            urlLoadBtn.Text = "加载成功";
            queryBtn.Enabled = true;
        }

        /// <summary>
        /// 点击选择文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSelectBtn_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// 点击加载文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileLoadBtn_Click(object sender, System.EventArgs e)
        {
            SetLoadStatus(true);
            try
            {
                Phone2Region.initByFile(fileTextBox.Text);
            }
            catch (Phone2RegionException e1)
            {
                MessageBox.Show(e1.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetLoadStatus(false);
                return;
            }
            fileLoadBtn.Text = "加载成功";
            queryBtn.Enabled = true;
        }

        /// <summary>
        /// 点击查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                Region region = Phone2Region.parse(phoneTextBox.Text);
                if (region == null)
                {
                    resultTextBox.Text = "未找到";
                }
                else
                {
                    resultTextBox.Text = "省份\t城市\t邮编\t区号\tISP\r\n" + region.province + "\t" + region.city + "\t" + region.zipCode + "\t" + region.areaCode + "\t" + region.isp + "\t";
                }
            }
            catch (Phone2RegionException e1)
            {
                MessageBox.Show(e1.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
