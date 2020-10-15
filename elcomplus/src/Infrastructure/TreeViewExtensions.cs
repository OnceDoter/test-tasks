using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MaterialSkin.Controls;

namespace elcomplus.Infrastructure
{
    internal static class TreeViewExtensions
    {
        public static void TreeFromXmlFile(this TreeView tree, string path)
        {
            try
            {
                var xml = File.ReadAllText(path, Encoding.UTF8);
                tree.TreeFromXml(xml);
            }
            catch (UnauthorizedAccessException e)
            {
                MaterialMessageBox.Show($"У вас недостаточно прав\n{e.Message}");
            }
        }

        public static void TreeFromXmlUrl(this TreeView tree, string url)
        {

            using var client = new WebClient();
            tree.TreeFromXml(client.DownloadString(url));
            
        }

        private static void Add(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            if (inXmlNode.HasChildNodes)
                for (var i = 0; i <= inXmlNode.ChildNodes.Count - 1; i++)
                {
                    var xmlNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xmlNode.Name));
                    var treeNode = inTreeNode.Nodes[i];
                    Add(xmlNode, treeNode);
                }
            else inTreeNode.Text = (inXmlNode.OuterXml).Trim();
        }

        private static void TreeFromXml(this TreeView tree, string xml)
        {
            try
            {
                var dom = new XmlDocument();
                dom.LoadXml(xml);
                tree.Nodes.Clear();
                var tNode = dom.DocumentElement != null
                    ? new TreeNode(dom.DocumentElement.Name)
                    : new TreeNode("root");
                tree.Nodes.Add(tNode);
                Add(dom.DocumentElement, tNode);
            }
            catch (XmlException e)
            {
                MaterialMessageBox.Show(e.Message);
            }
        }
    }
}
