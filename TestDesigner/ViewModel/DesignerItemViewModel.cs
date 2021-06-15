using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiagramDesigner;
using System.Windows.Input;

namespace TestDesigner
{
    public class DesignerItemViewModel : DesignerItemViewModelBase, ISupportDataChanges
    {
       
        public DesignerItemViewModel(int id, IDiagramViewModel parent, double left, double top) : base(id,parent, left,top)
        {
            Init();
        }
        public DesignerItemViewModel(int id, IDiagramViewModel parent, double left, double top, double itemWidth, double itemHeight) : base(id, parent, left, top, itemWidth, itemHeight)
        {
            Init();
        }

        public DesignerItemViewModel() : base()
        {
            Init();
        }


        public String HostUrl { get; set; }
        public ICommand ShowDataChangeWindowCommand { get; private set; }

        public void ExecuteShowDataChangeWindowCommand(object parameter)
        {
            if (parameter is DesignerItemViewModel)
            {
                DesignerItemData designerItemData = new DesignerItemData(parameter);
                designerItemData.Width = 100;
            }
                
        }
      


        private void Init()
        {          
            ShowDataChangeWindowCommand = new SimpleCommand(ExecuteShowDataChangeWindowCommand);
            this.ShowConnectors = false;

        }
    }
}
