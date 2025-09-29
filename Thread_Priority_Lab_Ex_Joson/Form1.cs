using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Priority_Lab_Ex_Joson
{
    public partial class frmTrackThread : Form
    {
        private Thread threadA, threadB, threadC, threadD;
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblThread.Text = "-Start Thread-";
            Console.WriteLine("-Thread 1 Start-");
            ThreadStart thread1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart thread2 = new ThreadStart(MyThreadClass.Thread2);

            threadA = new Thread(new ThreadStart(thread1));
            threadA.Name = "Thread A process";
            threadA.Priority = ThreadPriority.Highest;

            threadB = new Thread(new ThreadStart(thread1));
            threadB.Name = "Thread B process";
            threadB.Priority = ThreadPriority.Normal;

            threadC = new Thread(new ThreadStart(thread2));
            threadC.Name = "Thread C process";
            threadC.Priority = ThreadPriority.AboveNormal;

            threadD = new Thread(new ThreadStart(thread2));
            threadD.Name = "Thread D process";
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();


            lblThread.Text = "- End of Thread -";
            Console.WriteLine("-End of Thread-");
        }
    }

}
    }
}
