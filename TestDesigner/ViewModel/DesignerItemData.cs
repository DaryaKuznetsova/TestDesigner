using DiagramDesigner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesigner
{
    public class DesignerItemData: INPCBase
    {
        private double width = 0;
        private double height = 0;

        public DesignerItemData(object designerItemViewModel)
        {
            DesignerItemViewModel model = (DesignerItemViewModel)designerItemViewModel;
            width = model.ItemWidth;
            height = model.ItemHeight;
        }


        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (width != value)
                {
                    width = value;
                    NotifyChanged("Width");
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (height != value)
                {
                    width = value;
                    NotifyChanged("Height");
                }
            }
        }
    }
}
