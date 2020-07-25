using System;
using System.Windows.Forms;

namespace MVPStopwatch
{
    public partial class StopWatchForm : Form
    {
        private readonly Model model;
        public StopWatchForm()
        {
            InitializeComponent();
            model = new Model();
            Start += ViewStart;
            Stop += ViewStop;
            Reset += ViewReset;
            timer.Tick += TimerTick;
            timer.Start();
            timer.Enabled = false;
        }

        //delegates
        private EventHandler start;
        private EventHandler stop;
        private EventHandler reset;

        //events
        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }

        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }

        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }

        //Event Handlers
        private void startButton_Click(object sender, EventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stop.Invoke(sender, e);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset.Invoke(sender, e);
        }

        //
        void ViewReset(object sender, EventArgs e)
        {
            timer.Stop();
            secondsTextBox.Clear();
            model.Reset();
        }

        private void ViewStop(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void ViewStart(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            secondsTextBox.Text = model.Tick();
        }
    }
}