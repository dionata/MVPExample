using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVPApplication.View
{
    public partial class ListViewForm : Form, IView
    {
        public event EventHandler<StringListEventArgs> MoveToDestinationRequested;
        public event EventHandler<StringListEventArgs> MoveToSourceRequested;
        public event EventHandler<StringEventArgs> FolderSelected;
        public event EventHandler AllCleared;
        
        public void UpdateSource(Dictionary<string, IEnumerable<string>> data)
        {
            sourceListView.Items.Clear();
            sourceListView.Groups.Clear();

            foreach (var key in data.Keys)
            {
                var groupIndex = sourceListView.Groups.Add(new ListViewGroup(key, HorizontalAlignment.Left));

                foreach (var l in data[key].Select(item => new ListViewItem(item)))
                {
                    sourceListView.Items.Add(l);
                    sourceListView.Groups[groupIndex].Items.Add(l);
                }
            }
        }

        public void UpdateDestination(Dictionary<string, IEnumerable<string>> data)
        {
            destListView.Items.Clear();
            destListView.Groups.Clear();

            foreach (var key in data.Keys)
            {
                var groupIndex = destListView.Groups.Add(new ListViewGroup(key, HorizontalAlignment.Left));

                foreach (var l in data[key].Select(item => new ListViewItem(item)))
                {
                    destListView.Items.Add(l);
                    destListView.Groups[groupIndex].Items.Add(l);
                }
            }
        }

        public ListViewForm()
        {
            InitializeComponent();

            sourceListView.View = System.Windows.Forms.View.Details;
            sourceListView.AllowDrop = true;
            sourceListView.ShowGroups = true;
            sourceListView.ShowItemToolTips = true;
            var col1 = new ColumnHeader { Text = "File", Width = 400 };
            sourceListView.Columns.Add(col1);

            destListView.View = System.Windows.Forms.View.Details;
            destListView.ShowItemToolTips = true;
            destListView.ShowGroups = true;
            var col2 = new ColumnHeader { Text = "File", Width = 400 };
            destListView.Columns.Add(col2);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog { Description = "Browse for folder" };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FolderSelected(this, new StringEventArgs(fbd.SelectedPath));
            }
        }

        private void toDestinationButton_Click(object sender, EventArgs e)
        {
            var selected = (from ListViewItem item in sourceListView.SelectedItems select item.Text).ToList();
            MoveToDestinationRequested(this, new StringListEventArgs(selected));
        }

        private void toSourceButton_Click(object sender, EventArgs e)
        {
            var selected = (from ListViewItem item in destListView.SelectedItems select item.Text).ToList();
            MoveToSourceRequested(this, new StringListEventArgs(selected));
        }

        private void clearSourceButton_Click(object sender, EventArgs e)
        {
            AllCleared(this, EventArgs.Empty);
        }
    }
}
