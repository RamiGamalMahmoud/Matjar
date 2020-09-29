using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GControls
{
    public class GMessagesPanel : Panel
    {
        private Timer MessagesStacker = new Timer() { Interval = 1000 };
        private Timer OpenMeTimer = new Timer() { Interval = 10 };
        private Timer CloseMeTimer = new Timer() { Interval = 10 };
        GButton menu_open = new GButton();
        GButton menu_close = new GButton();

        private List<Label> MessagesStack = new List<Label>();

        public GMessagesPanel()
        {
        }


        public void AddMessage(GMessage message)
        {
            this.Width = 200;
            if (this.Controls.Count == 0)
                message.Location = new Point(message.Location.X + 10, this.Location.Y + 5);
            else message.Location = new Point(message.Location.X + 10, this.Controls[this.Controls.Count - 1].Location.Y + this.Controls[this.Controls.Count - 1].Height + 5);
            this.Controls.Add(message);
        }
        
        private void RemoveMessage(Label message)
        {
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);

            foreach(Control ctrl in Controls)
            {
                if ( ctrl.TabIndex > e.Control.TabIndex)
                {
                    ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - e.Control.Height - 5);
                }
            }
            if (Controls.Count == 0)
            {
                CloseMeTimer.Start();
            }
        }
        private void RemoveMessageImmediately(Label message)
        {

        }

        private void OpenMeTimer_Tick(object sender, EventArgs e)
        {
            if ( this.Width < 200 )
            {
                this.Width += 20;
            }
        }

        private void CloseMeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Width > 20)
            {
                this.Width -= 20;
            }
            else CloseMeTimer.Stop();
        }
        protected override void OnMouseLeave(EventArgs e)
        {

            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            else
            {
                base.OnMouseLeave(e);
            }
        }
    }
}
