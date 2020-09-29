using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GControls
{
    public class MessageArgs : EventArgs
    {
        string _message_title;
        string _text;
        GMessage.MessageState _stat;


        public GMessage.MessageState State
        {
            get { return this._stat; }
            set { this._stat = value; }
        }
        public string MessageTitle 
        {
            get { return this._message_title; }
            set { this._message_title = value; }
        }

        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }
    }
}
