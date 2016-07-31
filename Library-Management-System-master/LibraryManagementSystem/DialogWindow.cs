

using System;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using LibraryManagementSystem.Properties;

namespace LibraryManagementSystem
{
     class DialogWindow : Form
    {
        private ToolTip _tooltip;
        private Label _dialogTitleLabel;
        private  Label _dialogMsgLabel;
        private readonly PictureBox _dialogCloseIconPic;
        private readonly PictureBox _dialogBoxIconsPic;
     
        public DialogWindow(string msg,string title,DialogBoxIconType icon)
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.White;
            AutoSize = true;
           StartPosition = FormStartPosition.CenterScreen;
            BackgroundImage = Resources.apple;
            BackgroundImageLayout = ImageLayout.Stretch;
            _dialogMsgLabel = new Label
            {
                Location = new Point(55, 94),
                Font = new Font("Arial", 14),
                AutoSize = true,
                Text = msg,BackColor =Color.Transparent
            };
        
            Controls.Add(_dialogMsgLabel);
            _dialogBoxIconsPic = new PictureBox
            {
                Location = new Point(13, 88),BackColor = Color.Transparent
            };
     
          
            
            var dialogHeaderPanel = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(this.Width+5, 50),
                BackColor = System.Drawing.Color.CornflowerBlue,
                AutoSize = true

            };
            _dialogCloseIconPic = new PictureBox
            {
                Location = new Point(this.Width - 40, 11),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(33, 33),
                Image = Resources.CloseIcona,
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent
            };
            _dialogCloseIconPic.Click += _DialogCloseIconPic_Click;
            _dialogCloseIconPic.MouseHover += _DialogCloseIconPic_MouseHover;
            _dialogCloseIconPic.MouseLeave += _DialogCloseIconPic_MouseLeave;
            this.Load += DialogWindow_Load;
            _dialogTitleLabel = new Label()
            {
                Location = new Point(6, 8),
                AutoSize = true,
                Font = new Font("Courier New", 14)
                ,
                Text = title,ForeColor = Color.White

            };
            this.Controls.Add(_dialogBoxIconsPic);
            dialogHeaderPanel.Controls.Add(_dialogCloseIconPic);
            dialogHeaderPanel.Controls.Add(_dialogTitleLabel);
            Controls.Add(dialogHeaderPanel);
            DialogBoxIcon(icon);
        }

        private void DialogWindow_Load(object sender, EventArgs e)
        {
            _dialogCloseIconPic.Image = Resources.CloseIcona;
        }

        public void DialogBoxIcon(DialogBoxIconType icon)
        {
        
            switch (icon)
            {
                case DialogBoxIconType.Application:
                _dialogBoxIconsPic.Image = SystemIcons.Application.ToBitmap();
                    break;

                case DialogBoxIconType.Exclamation:
                    _dialogBoxIconsPic.Image = SystemIcons.Exclamation.ToBitmap();
                    break;

                case DialogBoxIconType.Error:
                     _dialogBoxIconsPic.Image = SystemIcons.Error.ToBitmap();
                    break;

                case DialogBoxIconType.Info:
                 _dialogBoxIconsPic.Image = SystemIcons.Information.ToBitmap();
                    break;

                case DialogBoxIconType.Question:
              _dialogBoxIconsPic.Image = SystemIcons.Question.ToBitmap();
                    break;

                case DialogBoxIconType.Shield:
             _dialogBoxIconsPic.Image = SystemIcons.Shield.ToBitmap();
                    break;

                case DialogBoxIconType.Warning:
                    _dialogBoxIconsPic.Image = SystemIcons.Warning.ToBitmap();
                    break;
            }

        }

        internal enum DialogBoxIconType
        {
            Application = 1,
            Exclamation = 2,
            Error = 3,
            Warning = 4,
            Info = 5,
            Question = 6,
            Shield = 7,
            Search = 8
        }
        private void _DialogCloseIconPic_MouseHover(object sender, EventArgs e)
        {
            _dialogCloseIconPic.Image = Resources.CloseIconb;
        }

        private void _DialogCloseIconPic_MouseLeave(object sender, EventArgs e)
        {
            _dialogCloseIconPic.Image = Resources.CloseIcona;
        }

        private void _DialogCloseIconPic_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
