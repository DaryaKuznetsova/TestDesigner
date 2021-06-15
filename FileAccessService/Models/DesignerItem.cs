using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileService
{
    public class DesignerItem: DesignerItemBase
    {
        public DesignerItem(int id, double left, double top, double itemWidth, double itemHeight,
            Guid parentId, int zIndex, object content, bool isGroup)
           : base(id, left, top, itemWidth, itemHeight)
        {
            this.ParentId = parentId;
            this.ZIndex = zIndex;
            this.Content = content;
            this.IsGroup = IsGroup;
        }

        public Guid ParentId { get; private set; }
        public int ZIndex { get; private set; }
        public object Content { get; private set; }
        public double IsGroup { get; private set; }
    }
}
