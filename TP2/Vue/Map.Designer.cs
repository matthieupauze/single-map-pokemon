namespace TP2.Vue
{
    partial class Map
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrWalk = new System.Windows.Forms.Timer(this.components);
            this.msgGuerrison = new TP2.Vue.Message();
            this.lblMessage = new System.Windows.Forms.Label();
            this.msgGuerrison.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrWalk
            // 
            this.tmrWalk.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // msgGuerrison
            // 
            this.msgGuerrison.BackColor = System.Drawing.SystemColors.Control;
            this.msgGuerrison.Controls.Add(this.lblMessage);
            this.msgGuerrison.Enabled = false;
            this.msgGuerrison.Location = new System.Drawing.Point(0, 502);
            this.msgGuerrison.Name = "msgGuerrison";
            this.msgGuerrison.Size = new System.Drawing.Size(672, 170);
            this.msgGuerrison.TabIndex = 0;
            this.msgGuerrison.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMessage.Location = new System.Drawing.Point(26, 21);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(621, 128);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.UseCompatibleTextRendering = true;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.msgGuerrison);
            this.DoubleBuffered = true;
            this.Name = "Map";
            this.Size = new System.Drawing.Size(672, 672);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Moving);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Map_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Allowing_Arrow_Keys);
            this.msgGuerrison.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrWalk;
        private Message msgGuerrison;
        private System.Windows.Forms.Label lblMessage;
    }
}
