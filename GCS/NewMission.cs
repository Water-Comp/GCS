using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
namespace GCS
{
    public partial class NewMission : Form
    {
        static Mision mission = new Mision();
        public NewMission()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, System.EventArgs e)
        {
            DBConnectionThread db = new DBConnectionThread(name.Text, server.Text, newm.Checked);
            Thread thread = new Thread(new ThreadStart(db.Run));
            thread.Start();
            this.Close();
        }
    }
}