using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QuickTypeJsonToDocumentation
{
    public partial class JsonToDocumentation : Form
    {
        public JsonToDocumentation()
        {
            InitializeComponent();
        }

        private void GenerateDocBtn_Click(object sender, EventArgs e)
        {
            //var inputText = InputRichTextBox.Text;
            GenerateDoc(true);
        }

        private void GenerateDoc(bool isInputMode = false)
        {
            var inputText = InputRichTextBox.Text;
            var lines = inputText.Replace("\tlet ", "")
                                  .Replace("    let ", "")
                                  .Replace(" ", "")
                                  .Split('\r','\n')
                                  .Where(x=>!string.IsNullOrWhiteSpace(x));
            StringBuilder outputDoc = new StringBuilder();
            foreach (var line in lines)
            {
                var properties = line.Split(':');
                var dataType = properties.Last();
                if (dataType.Contains("["))
                {
                    dataType = $"{dataType.Trim('[', ']')}Array";
                }
                foreach (var property in properties.First().Split(','))
                {
                    var propertySentence = ToSentenceCase(property);
                    var documentLine = $"{propertySentence}\t{dataType}\t{GetExpectedValue(dataType)}\t{GetTypeDescription(dataType, propertySentence, isInputDescription: isInputMode)}";
                    outputDoc.AppendLine(documentLine);
                }
            }

            OutputRichTextBox.Text = outputDoc.ToString();
        }

        private string GetTypeDescription(string dataType, string propertyName, bool isInputDescription)
        {
            var entityText = EntityName.Text;
            var result = dataType;
            var idString = string.IsNullOrWhiteSpace(propertyName.Replace("Id", "")) ? entityText : propertyName.Replace("Id", "");
            if (dataType.StartsWith("Int"))
                result = isInputDescription ? $"Integer value to be assigned as {propertyName} for {entityText}"
                    : $"{dataType} value for {propertyName} "
                    + (propertyName.Contains("Id") ? $"Id for {idString}" : "")
                    + (propertyName.Contains("Is") || propertyName.ToLower().Contains("status") ? $"Can be 0 or 1" : "")
                    + (propertyName.Contains("By") ? $"References user who {propertyName.Replace("By", "")} the {entityText}" : "");
            if (dataType.StartsWith("String"))
                result = isInputDescription ? $"String text value to be assigned as {propertyName} for {entityText}"
                    : $"{propertyName} value for {entityText} "
                    + (propertyName.Contains("Date") ? $"{propertyName.Replace("Date", "")} Date in UTC \"yyyy-MM-ddTHH:mm:ss.fffZ\" format" : "");

            return result;
        }

        /// <summary>
        /// does not consider the culture and locale
        /// </summary>
        /// <param name="dataType"></param>
        /// <returns></returns>
        private string GetExpectedValue(string dataType)
        {
            var result = dataType;
            if (dataType.StartsWith("Int"))
                result = "Positive Integer or Zero";
            if (dataType.StartsWith("String"))
                result = "Text or unicode characters";
            if (dataType.StartsWith("Bool"))
                result = "Boolean or truthy value";

            if (dataType.EndsWith("Array"))
                result = "Array of " + result.Replace("Array","");
            return result;
        }

        private string ToSentenceCase(string source)
        {

            return source.First().ToString().ToUpper() + source.Substring(1); //capitalize first letter
        }


        string sampleText = @"    let channel, objectID, title, comment: String
    let settings: String";

        private void GenerateOutputDocBtn_Click(object sender, EventArgs e)
        {
            GenerateDoc();
        }
    }
}
