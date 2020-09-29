using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using GControls.Properties;

namespace GControls
{
    public class GMessage : Label
    {
        // Types
        public enum MessageState { SUCESS, Error, INFORMATION }

        // Fields
        private GButton btn_close;
        private string _title;
        private MessageState _state;

        // Properites
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public MessageState State
        {
            get { return _state; }
            set { _state = value; }
        }

        // Constructors
        public GMessage()
        {

            init();
            Createmessage();
            MessageBox.Show(this.Text);

        }

        public GMessage(string title, string text, MessageState state)
        {
            init();
            this.Title = title;
            this.Text = text;
            SizeF sz = CreateGraphics().MeasureString(text, Font);
            this.Height += (int)sz.Height;
            this.TextAlign = ContentAlignment.MiddleCenter;
            Createmessage();
        }



        // Methodes
        public void init ()
        {
            this.AutoSize = false;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Width = 180;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.ForeColor = Color.White;
            this.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            this.BackColor = Color.FromArgb(80, 80, 80);
            this.BringToFront(); 
        }
        private void Createmessage()
        {
            this.TextChanged += GMessage_TextChanged;

            ResourceManager res = Resources.ResourceManager;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            btn_close = new GButton()
            {
                ImageAlign = ContentAlignment.MiddleCenter
            };

            

            switch (this.State)
            {
                case MessageState.Error:
                    btn_close.Image = Resources.close_window_16px;
                    break;
                case MessageState.INFORMATION:
                    btn_close.Image = Resources.info_squared_16px;
                    break;
                case MessageState.SUCESS:
                    btn_close.Image = Resources.ok_16px;
                    break;
            }
            this.Controls.Add(btn_close);
            this.btn_close.Click += CloseButtonClicked;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.AutoSize = false;
        }

        public void CloseButtonClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GMessage_TextChanged(object sender, EventArgs e)
        {
            string txt = this.Text;
            SizeF sz = CreateGraphics().MeasureString(txt, Font);
            this.Height += (int)sz.Height;
            this.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
