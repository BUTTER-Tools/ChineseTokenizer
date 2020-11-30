using System.Text;
using System.Windows.Forms;
using System.IO;






namespace ChineseTokenizerCoreNLP
{
    internal partial class SettingsForm_ChineseTokenizer_CoreNLP : Form
    {


        #region Get and Set Options

        public string modelFile { get; set; }

        #endregion



        public SettingsForm_ChineseTokenizer_CoreNLP(string modelFileInput)
        {
            InitializeComponent();

            switch(modelFileInput)
            {
                case @"\ctb.gz":
                    CTBRadioButton.Checked = true;
                    PKURadioButton.Checked = false;
                    break;
                case @"\pku.gz":
                    CTBRadioButton.Checked = false;
                    PKURadioButton.Checked = true;
                    break;
            }

        }




                                   
        private void OKButton_Click(object sender, System.EventArgs e)
        {

            if (CTBRadioButton.Checked)
            {
                modelFile = @"\ctb.gz";
            }
            else if (PKURadioButton.Checked)
            {
                modelFile = @"\pku.gz";
            }
            
            this.DialogResult = DialogResult.OK;

        }
    }
}
