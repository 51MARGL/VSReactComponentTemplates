using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReactComponentWizard
{
    public class ReactComponentWizard : IWizard
    {
        private ReactComponentWizardWindow form;

        public void BeforeOpeningFile(ProjectItem projectItem) { }
        public void ProjectFinishedGenerating(EnvDTE.Project project) { }
        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }
        public void RunFinished() { }
        public bool ShouldAddProjectItem(string filePath) => filePath switch
        {
            var x when x.EndsWith(".tsx") => true,
            var x when x.EndsWith(".scss") => form.CreateScss.IsChecked == true,
            var x when x.EndsWith("index.ts") => form.CreateIndex.IsChecked == true,
            _ => true
        };

        public void RunStarted(object automationObject,
                               Dictionary<string, string> replacementsDictionary,
                               WizardRunKind runKind,
                               object[] customParams)
        {
            form = new ReactComponentWizardWindow();
            var res = form.ShowDialog();
            if (res == true)
            {
                var safeName = replacementsDictionary["$safeitemname$"];
                replacementsDictionary.Add("$module$", safeName);
                replacementsDictionary.Add("$folder$", form.CreateFolder.IsChecked == true ? $@"{safeName}\" : "");
                replacementsDictionary.Add("$scss$", form.CreateScss.IsChecked == true ? "1" : "0");
                replacementsDictionary.Add("$index$", form.CreateIndex.IsChecked == true ? "1" : "0");
                replacementsDictionary.Add("$props$", form.WithProps.IsChecked == true ? "1" : "0");
                replacementsDictionary.Add("$bemname$",
                    Regex.Replace(safeName, @"(.+?)([A-Z])", m => m.Groups[1].Value + "-" + m.Groups[2].Value.ToLower()).ToLower());
            }
            else
            {
                throw new WizardCancelledException();
            }
        }
    }
}
