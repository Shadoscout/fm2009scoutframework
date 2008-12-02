using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Young3.FMSearch.Business.Entities.InGame;
using Young3.FMSearch.Interface;

namespace OpenSE
{
    public partial class MainForm : Form
    {
        public delegate void UpdateDataDelegate(Player player);
        public delegate void SetDataContextDelegate(FMDataContext dataContext);
        public delegate FMDataContext GetDataContextDelegate();
        public delegate int GetLastActiveObjectDelegate();
        public delegate void SetLastActiveObjectDelegate(int value);

        public int LastActiveObject = 0;

        public FMDataContext fmDataContext = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BackgroundWorker.RunWorkerAsync();
        }

        public void UpdateData(Player player)
        {
            CALabel.Text = player.CurrentPlayingAbility.ToString();
            PALabel.Text = player.PotentialPlayingAbility.ToString();
            ValueLabel.Text = string.Format("{0:N}", player.Value).Replace(",00", "");
            SaleValueLabel.Text = string.Format("{0:N}", player.SaleValue).Replace(",00", "");
            FitnessLabel.Text = player.Fitness.ToString();
        }

        public FMDataContext GetDataContext()
        {
            return fmDataContext;
        }

        public void SetDataContext(FMDataContext dataContext)
        {
            this.fmDataContext = dataContext;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                FMDataContext currentDataContext = (FMDataContext)this.Invoke(new GetDataContextDelegate(GetDataContext));

                if (currentDataContext == null)
                {
                    currentDataContext = new FMDataContext();
                    this.Invoke(new SetDataContextDelegate(SetDataContext), new object[] { currentDataContext });
                }

                if (((int)this.Invoke(new GetLastActiveObjectDelegate(GetLastActiveObject))) != currentDataContext.ActiveObject.MemoryAddress)
                {
                    this.Invoke(new UpdateDataDelegate(UpdateData), new object[] { (Player)fmDataContext.ActiveObject });
                    this.Invoke(new SetLastActiveObjectDelegate(SetLastActiveObject), new object[] { currentDataContext.ActiveObject.MemoryAddress });
                }
            }
            catch (Exception ex) { }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker.RunWorkerAsync();
        }

        public void SetLastActiveObject(int value)
        {
            LastActiveObject = value;
        }

        public int GetLastActiveObject()
        {
            return LastActiveObject;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackgroundWorker.CancelAsync();
        }

        private void FitnessLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
