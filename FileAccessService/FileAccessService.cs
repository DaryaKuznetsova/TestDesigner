using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows;
using Microsoft.Win32;
using System.Globalization;
using System.Windows.Markup;
using System.Xml;
using System.IO;
using System.Windows.Controls;

namespace FileService
{
    public class FileAccessService : IFileAccessService
    {
        public FileAccessService()
        {

        }

        public void SaveFile(XElement xElement)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (saveFile.ShowDialog() == true)
            {
                try
                {
                    xElement.Save(saveFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }



        private XElement LoadSerializedDataFromFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Designer Files (*.xml)|*.xml|All Files (*.*)|*.*";

            if (openFile.ShowDialog() == true)
            {
                try
                {
                    return XElement.Load(openFile.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace, e.Message, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            return null;
        }


        private static DesignerItem DeserializeDesignerItem(XElement itemXML, Guid guid, double OffsetX, double OffsetY)
        {
            int id = Convert.ToInt32(guid);
            double width = Double.Parse(itemXML.Element("Width").Value, CultureInfo.InvariantCulture);
            double height = Double.Parse(itemXML.Element("Height").Value, CultureInfo.InvariantCulture);
            double left = Double.Parse(itemXML.Element("Left").Value, CultureInfo.InvariantCulture) + OffsetX;
            double top = Double.Parse(itemXML.Element("Top").Value, CultureInfo.InvariantCulture) + OffsetY;
            Guid parentId = new Guid(itemXML.Element("ParentID").Value);
            int zIndex = Int32.Parse(itemXML.Element("zIndex").Value);
            object content = XamlReader.Load(XmlReader.Create(new StringReader(itemXML.Element("Content").Value)));
            bool isGroup = Boolean.Parse(itemXML.Element("IsGroup").Value);
            
            DesignerItem item = new DesignerItem(id, left, top, width, height, parentId, zIndex, content, isGroup);

            return item;
        }

        private static Connection DeserializeConnection()
        {
            return null;
        }

        public int SaveDiagram(DiagramItem diagram)
        {
            MessageBox.Show("SAving...");
            return 1;
        }

        public IEnumerable<DiagramItem> FetchAllDiagram()
        {
            throw new NotImplementedException();
        }

        public DiagramItem FetchDiagram(int diagramId)
        {
            throw new NotImplementedException();
        }

        public DesignerItem FetchDesignerItem(int designerItemId)
        {
            throw new NotImplementedException();
        }

        public Connection FetchConnection(int connectionId)
        {
            throw new NotImplementedException();
        }
    }
}
