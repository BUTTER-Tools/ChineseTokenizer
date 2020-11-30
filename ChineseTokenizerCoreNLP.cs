using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;
using edu.stanford.nlp.ie.crf;
using System.IO;
using System.Linq;

namespace ChineseTokenizerCoreNLP
{
    public class ChineseTokenizerCoreNLP : Plugin
    {

        public string[] InputType { get; } = { "String" };
        public string OutputType { get; } = "Tokens";

        public Dictionary<int, string> OutputHeaderData { get; set; } = new Dictionary<int, string>() { { 0, "TokenizedText" } };
        public bool InheritHeader { get; } = false;

        private CRFClassifier segmenter { get; set; }
        private string DataFolder { get; } = @"Plugins\Dependencies\ZhTokenData";

        private string modelFile { get; set; } = @"\ctb.gz";


        #region Plugin Details and Info

        public string PluginName { get; } = "Chinese (CoreNLP)";
        public string PluginType { get; } = "Tokenizers/Segmenters";
        public string PluginVersion { get; } = "1.0.3";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "Tokenize Chinese texts into individual units. This is a very common preprocessing step for texts in the Chinese language. Based on the CoreNLP framework and pre-trained segmentation model." + Environment.NewLine + Environment.NewLine +
            "Manning, Christopher D., Mihai Surdeanu, John Bauer, Jenny Finkel, Steven J. Bethard, and David McClosky. 2014. The Stanford CoreNLP Natural Language Processing Toolkit In Proceedings of the 52nd Annual Meeting of the Association for Computational Linguistics: System Demonstrations, pp. 55-60.";

        public bool TopLevel { get; } = false;
        public string PluginTutorial { get; } = "Coming Soon";

        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion



        public void ChangeSettings()
        {

            using (var form = new SettingsForm_ChineseTokenizer_CoreNLP(modelFile))
            {


                form.Icon = Properties.Resources.icon;

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    modelFile = form.modelFile;
                }
            }

        }





        public Payload RunPlugin(Payload Input)
        {
            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;

            for (int counter = 0; counter < Input.StringList.Count; counter++)
            {

                string[] TokenizedText = segmenter.classifyToString(Input.StringList[counter]).Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                pData.StringArrayList.Add(TokenizedText);
                pData.SegmentNumber.Add(Input.SegmentNumber[counter]);

                //List<string> TokenizedText = new List<string>();
                //int tokenCount = TokenResults.Count();
                //for (int i = 0; i < tokenCount; i++)
                //{
                //    TokenizedText.Add(TokenResults.ElementAt(i).Text);
                //}
                //pData.DataListStrArr.Add(TokenizedText.ToArray());
            }

            return (pData);
        }



        public void Initialize()
        {

            var segmenterData = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), DataFolder);

            var props = new java.util.Properties();
            props.setProperty("sighanCorporaDict", segmenterData);
            props.setProperty("serDictionary", segmenterData + @"\dict-chris6.ser.gz");
            // Lines below are needed because CTBSegDocumentIteratorFactory accesses it
            //props.setProperty("inputEncoding", SelectedEncoding.ToString());
            props.setProperty("sighanPostProcessing", "true");

            segmenter = new CRFClassifier(props);

            segmenter.loadClassifierNoExceptions(segmenterData + modelFile, props);

        }


        public bool InspectSettings()
        {
            return true;
        }


       
        public Payload FinishUp(Payload Input)
        {
            var segmenterData = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), DataFolder);
            var props = new java.util.Properties();
            props.setProperty("sighanCorporaDict", segmenterData);
            props.setProperty("serDictionary", segmenterData + @"\dict-chris6.ser.gz");
            props.setProperty("sighanPostProcessing", "true");
            segmenter = new CRFClassifier(props);
            return (Input);
        }




        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            modelFile = SettingsDict["modelFile"];
        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("modelFile", modelFile);
            return (SettingsDict);
        }
        #endregion



    }
}
