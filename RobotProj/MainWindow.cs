using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RobotProj
{
    public partial class MainWindow : DockContent
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            myCompList.Show(MainDock, DockState.DockLeft);
            myCodeWins.Show(MainDock, DockState.DockRight);
            myDrawTable.Show(MainDock);
        }

        private CompList myCompList = new CompList();
        private CodeWindow myCodeWins = new CodeWindow();
        private DrawTable myDrawTable = new DrawTable();
    }

    
}
