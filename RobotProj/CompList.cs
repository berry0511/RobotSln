using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotProj
{
    public partial class CompList : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public CompList()
        {
            InitializeComponent();
        }

        private void CompList_Load(object sender, EventArgs e)
        {
            this.CompTree.ExpandAll();
        }

        private void CompTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }

        }

        private void CompTree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
