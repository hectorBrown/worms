namespace Worms2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PB_main = new System.Windows.Forms.PictureBox();
            this.TIM_animate = new System.Windows.Forms.Timer(this.components);
            this.PNL_constEditor = new System.Windows.Forms.Panel();
            this.TB_speed = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_no = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_trail = new System.Windows.Forms.TrackBar();
            this.TB_turn = new System.Windows.Forms.TrackBar();
            this.TB_zoom = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PB_main)).BeginInit();
            this.PNL_constEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_trail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_main
            // 
            this.PB_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_main.Location = new System.Drawing.Point(0, 74);
            this.PB_main.Name = "PB_main";
            this.PB_main.Size = new System.Drawing.Size(1442, 429);
            this.PB_main.TabIndex = 0;
            this.PB_main.TabStop = false;
            this.PB_main.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_main_Paint);
            // 
            // TIM_animate
            // 
            this.TIM_animate.Enabled = true;
            this.TIM_animate.Interval = 10;
            this.TIM_animate.Tick += new System.EventHandler(this.TIM_animate_Tick);
            // 
            // PNL_constEditor
            // 
            this.PNL_constEditor.Controls.Add(this.TB_speed);
            this.PNL_constEditor.Controls.Add(this.label5);
            this.PNL_constEditor.Controls.Add(this.TB_no);
            this.PNL_constEditor.Controls.Add(this.label4);
            this.PNL_constEditor.Controls.Add(this.label3);
            this.PNL_constEditor.Controls.Add(this.label2);
            this.PNL_constEditor.Controls.Add(this.label1);
            this.PNL_constEditor.Controls.Add(this.TB_trail);
            this.PNL_constEditor.Controls.Add(this.TB_turn);
            this.PNL_constEditor.Controls.Add(this.TB_zoom);
            this.PNL_constEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_constEditor.Location = new System.Drawing.Point(0, 0);
            this.PNL_constEditor.Name = "PNL_constEditor";
            this.PNL_constEditor.Size = new System.Drawing.Size(1442, 68);
            this.PNL_constEditor.TabIndex = 1;
            // 
            // TB_speed
            // 
            this.TB_speed.Location = new System.Drawing.Point(1285, 12);
            this.TB_speed.Minimum = 1;
            this.TB_speed.Name = "TB_speed";
            this.TB_speed.Size = new System.Drawing.Size(145, 45);
            this.TB_speed.TabIndex = 9;
            this.TB_speed.Value = 1;
            this.TB_speed.Scroll += new System.EventHandler(this.TB_speed_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1241, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Speed";
            // 
            // TB_no
            // 
            this.TB_no.Location = new System.Drawing.Point(888, 12);
            this.TB_no.Maximum = 1000;
            this.TB_no.Name = "TB_no";
            this.TB_no.Size = new System.Drawing.Size(330, 45);
            this.TB_no.TabIndex = 7;
            this.TB_no.Scroll += new System.EventHandler(this.TB_no_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trail Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Erraticism";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zoom";
            // 
            // TB_trail
            // 
            this.TB_trail.Location = new System.Drawing.Point(585, 12);
            this.TB_trail.Maximum = 200;
            this.TB_trail.Minimum = 1;
            this.TB_trail.Name = "TB_trail";
            this.TB_trail.Size = new System.Drawing.Size(247, 45);
            this.TB_trail.TabIndex = 2;
            this.TB_trail.Value = 1;
            this.TB_trail.Scroll += new System.EventHandler(this.TB_trail_Scroll);
            // 
            // TB_turn
            // 
            this.TB_turn.Location = new System.Drawing.Point(220, 12);
            this.TB_turn.Maximum = 90;
            this.TB_turn.Name = "TB_turn";
            this.TB_turn.Size = new System.Drawing.Size(290, 45);
            this.TB_turn.TabIndex = 1;
            this.TB_turn.Scroll += new System.EventHandler(this.TB_turn_Scroll);
            // 
            // TB_zoom
            // 
            this.TB_zoom.Location = new System.Drawing.Point(52, 12);
            this.TB_zoom.Minimum = 2;
            this.TB_zoom.Name = "TB_zoom";
            this.TB_zoom.Size = new System.Drawing.Size(104, 45);
            this.TB_zoom.TabIndex = 0;
            this.TB_zoom.Value = 2;
            this.TB_zoom.Scroll += new System.EventHandler(this.TB_zoom_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 503);
            this.Controls.Add(this.PNL_constEditor);
            this.Controls.Add(this.PB_main);
            this.Name = "Form1";
            this.Text = "Worms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.PB_main)).EndInit();
            this.PNL_constEditor.ResumeLayout(false);
            this.PNL_constEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_trail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_zoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_main;
        private System.Windows.Forms.Timer TIM_animate;
        private System.Windows.Forms.Panel PNL_constEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TB_trail;
        private System.Windows.Forms.TrackBar TB_turn;
        private System.Windows.Forms.TrackBar TB_zoom;
        private System.Windows.Forms.TrackBar TB_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TB_speed;
        private System.Windows.Forms.Label label5;
    }
}

