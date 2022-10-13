using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Threading;


namespace _5._2
{
    class Lift
    {
        public int aoaoaoa;
        public enum upd { Go, NotGo };
        public enum doors { Open, Closed };
        public upd apd;
        public doors dveri;
        public int curfl;
        public int destfl;
        DispatcherTimer timer;
        TextBox textBox;
        public Lift(int cf, int df, TextBox tb)
        {
            this.curfl = cf;
            this.destfl = df;
            this.apd = upd.NotGo;
            this.dveri = doors.Open;
            this.textBox = tb;

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (curfl < destfl)
            {
                curfl++;
                textBox.Text = Convert.ToString(curfl);
            }
            else if (curfl > destfl)
            {
                curfl--;
                textBox.Text = Convert.ToString(curfl);
            }
            else
            {
                timer.Stop();
                this.apd = upd.NotGo;
            }
        }
        public void timer_call(int cf, int df)
        {
            this.curfl = cf;
            this.destfl = df;
            timer.Start();
            this.apd = upd.Go;
            
        }
    }
}
