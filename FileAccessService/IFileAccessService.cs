using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileService
{
    public interface IFileAccessService
    {

        //save methods
        int SaveDiagram(DiagramItem diagram);

        DiagramItem FetchDiagram(int diagramId);
        //PersistDesignerItem is pecific to the DemoApp example
        DesignerItem FetchDesignerItem(int designerItemId);
        //SettingsDesignerItem is pecific to the DemoApp example
        Connection FetchConnection(int connectionId);
    }
}
