using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileService
{
    public interface IDiagramItem 
    {
        List<DiagramItemData> DesignerItems { get; set; }
        List<int> ConnectionIds { get; set; }
    }
}
