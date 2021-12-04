using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducateApp.ViewModels.Disciplines
{
    public class FilterDisciplineViewModel
    {        
        public string SelectedIndexProfModule { get; private set; }
        public string SelectedProfModule { get; private set; }
        public string SelectedIndex { get; private set; }
        public string SelectedName { get; private set; }    // введенное имя
        public string SelectedShortName { get; private set; }

        public FilterDisciplineViewModel(string indexProfModule,
        string profModule, string index, string name, string shortName)
        {
            SelectedIndexProfModule = indexProfModule;
            SelectedProfModule = profModule;
            SelectedIndex = index;
            SelectedName = name;
            SelectedShortName = shortName;
        }
    }
}
