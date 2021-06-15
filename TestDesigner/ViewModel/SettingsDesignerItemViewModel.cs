using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiagramDesigner;
using System.Windows.Input;


namespace TestDesigner
{
    public class SettingsDesignerItemViewModel : DesignerItemViewModelBase, ISupportDataChanges
    {

        public SettingsDesignerItemViewModel(int id, IDiagramViewModel parent, double left, double top, string setting1)
            : base(id, parent, left, top)
        {

            this.Setting1 = setting1;
            Init();
        }

        public SettingsDesignerItemViewModel(int id, IDiagramViewModel parent, double left, double top, double itemWidth, double itemHeight, string setting1)
             : base(id, parent, left, top, itemWidth, itemHeight)
        {

            this.Setting1 = setting1;
            Init();
        }

        public SettingsDesignerItemViewModel()
        {
            Init();
        }

        public String Setting1 { get; set; }
        public ICommand ShowDataChangeWindowCommand { get; private set; }

        public void ExecuteShowDataChangeWindowCommand(object parameter)
        {
            SettingsDesignerItemData data = new SettingsDesignerItemData(Setting1);
        }

        private void Init()
        {
            ShowDataChangeWindowCommand = new SimpleCommand(ExecuteShowDataChangeWindowCommand);
            this.ShowConnectors = false;
        }
    }
}
