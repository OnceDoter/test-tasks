using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using elcomplus.Infrastructure;
using MaterialSkin.Controls;

namespace elcomplus
{
    public sealed partial class Form : MaterialForm
    {
        private const string temp = "foo.xml";
        public Form()
        {
            InitializeComponent();
            lable.Text = @"""...""";
            MinimumSize = new Size(600, 500);
            MaximumSize = new Size(1600, 900);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                MaterialMessageBox.Show("Небходимо выбрать фаил!");

            else if (Path.GetExtension(dialog.FileName) != ".xml")
                    MaterialMessageBox.Show("Неверное расширение фаила");

            else
            {
                treeView.TreeFromXmlFile(dialog.FileName);
                lable.Text = 
                    @"""" + 
                    dialog.FileName.Substring
                    (
                        dialog.FileName.LastIndexOf("\\", StringComparison.Ordinal) + 1
                    ) +
                    @"""";
            }
        }
        private void download_Click(object sender, EventArgs e)
        {
            if (textBox.Text == string.Empty)
                MaterialMessageBox.Show("Небходимо указать ссылку!");

            else if (!Uri.IsWellFormedUriString(textBox.Text, UriKind.RelativeOrAbsolute))
                MaterialMessageBox.Show("неправильная ссылка!");

            else treeView.TreeFromXmlUrl(textBox.Text);
        }
    }
}
