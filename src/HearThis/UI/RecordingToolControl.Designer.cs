using Palaso.Media.Naudio;
using Palaso.Media.Naudio.UI;

namespace HearThis.UI
{
    partial class RecordingToolControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordingToolControl));
            this._bookFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._chapterFlow = new System.Windows.Forms.FlowLayoutPanel();
            this._bookLabel = new System.Windows.Forms.Label();
            this._chapterLabel = new System.Windows.Forms.Label();
            this._segmentLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._smallerButton = new System.Windows.Forms.Button();
            this._largerButton = new System.Windows.Forms.Button();
            this._instantToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.recordingDeviceButton1 = new Palaso.Media.Naudio.UI.RecordingDeviceButton();
            this._peakMeter = new Palaso.Media.Naudio.UI.PeakMeterCtrl();
            this._lineCountLabel = new System.Windows.Forms.Label();
            this._audioButtonsControl = new HearThis.UI.AudioButtonsControl();
            this._scriptControl = new HearThis.UI.ScriptControl();
            this._scriptLineSlider = new HearThis.UI.DiscontiguousProgressTrackBar();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scriptLineSlider)).BeginInit();
            this._toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bookFlow
            // 
            this._bookFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bookFlow.Location = new System.Drawing.Point(3, 34);
            this._bookFlow.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this._bookFlow.Name = "_bookFlow";
            this._bookFlow.Size = new System.Drawing.Size(664, 44);
            this._bookFlow.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this._bookFlow, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._chapterFlow, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._bookLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._chapterLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 198);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _chapterFlow
            // 
            this._chapterFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chapterFlow.Location = new System.Drawing.Point(6, 122);
            this._chapterFlow.Margin = new System.Windows.Forms.Padding(6, 0, 3, 3);
            this._chapterFlow.Name = "_chapterFlow";
            this._chapterFlow.Size = new System.Drawing.Size(661, 89);
            this._chapterFlow.TabIndex = 5;
            // 
            // _bookLabel
            // 
            this._bookLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._bookLabel.AutoSize = true;
            this._bookLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bookLabel.ForeColor = System.Drawing.Color.DarkGray;
            this._bookLabel.Location = new System.Drawing.Point(0, 0);
            this._bookLabel.Margin = new System.Windows.Forms.Padding(0);
            this._bookLabel.Name = "_bookLabel";
            this._bookLabel.Size = new System.Drawing.Size(79, 31);
            this._bookLabel.TabIndex = 3;
            this._bookLabel.Text = "label1";
            // 
            // _chapterLabel
            // 
            this._chapterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._chapterLabel.AutoSize = true;
            this._chapterLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chapterLabel.ForeColor = System.Drawing.Color.DarkGray;
            this._chapterLabel.Location = new System.Drawing.Point(0, 91);
            this._chapterLabel.Margin = new System.Windows.Forms.Padding(0);
            this._chapterLabel.Name = "_chapterLabel";
            this._chapterLabel.Size = new System.Drawing.Size(79, 31);
            this._chapterLabel.TabIndex = 4;
            this._chapterLabel.Text = "label1";
            // 
            // _segmentLabel
            // 
            this._segmentLabel.AutoSize = true;
            this._segmentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this._segmentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._segmentLabel.ForeColor = System.Drawing.Color.DarkGray;
            this._segmentLabel.Location = new System.Drawing.Point(16, 242);
            this._segmentLabel.Margin = new System.Windows.Forms.Padding(0);
            this._segmentLabel.Name = "_segmentLabel";
            this._segmentLabel.Size = new System.Drawing.Size(92, 32);
            this._segmentLabel.TabIndex = 12;
            this._segmentLabel.Text = "Line 11";
            // 
            // _smallerButton
            // 
            this._smallerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._smallerButton.FlatAppearance.BorderSize = 0;
            this._smallerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._smallerButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._smallerButton.ForeColor = System.Drawing.Color.DimGray;
            this._smallerButton.Location = new System.Drawing.Point(5, 484);
            this._smallerButton.Margin = new System.Windows.Forms.Padding(0);
            this._smallerButton.Name = "_smallerButton";
            this._smallerButton.Size = new System.Drawing.Size(33, 37);
            this._smallerButton.TabIndex = 32;
            this._smallerButton.Text = "A";
            this._smallerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this._smallerButton, "Smaller text");
            this._smallerButton.UseVisualStyleBackColor = true;
            this._smallerButton.Click += new System.EventHandler(this.OnSmallerClick);
            // 
            // _largerButton
            // 
            this._largerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._largerButton.FlatAppearance.BorderSize = 0;
            this._largerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._largerButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._largerButton.ForeColor = System.Drawing.Color.DimGray;
            this._largerButton.Location = new System.Drawing.Point(44, 478);
            this._largerButton.Name = "_largerButton";
            this._largerButton.Size = new System.Drawing.Size(27, 43);
            this._largerButton.TabIndex = 33;
            this._largerButton.Text = "A";
            this._largerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this._largerButton, "Larger Text");
            this._largerButton.UseVisualStyleBackColor = true;
            this._largerButton.Click += new System.EventHandler(this.OnLargerClick);
            // 
            // _instantToolTip
            // 
            this._instantToolTip.AutomaticDelay = 0;
            this._instantToolTip.UseAnimation = false;
            this._instantToolTip.UseFading = false;
            // 
            // recordingDeviceButton1
            // 
            this.recordingDeviceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recordingDeviceButton1.BackColor = System.Drawing.Color.Transparent;
            this.recordingDeviceButton1.Location = new System.Drawing.Point(651, 484);
            this.recordingDeviceButton1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.recordingDeviceButton1.Name = "recordingDeviceButton1";
            this.recordingDeviceButton1.Recorder = null;
            this.recordingDeviceButton1.Size = new System.Drawing.Size(22, 25);
            this.recordingDeviceButton1.TabIndex = 23;
            // 
            // _peakMeter
            // 
            this._peakMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._peakMeter.BandsCount = 1;
            this._peakMeter.ColorHigh = System.Drawing.Color.Red;
            this._peakMeter.ColorHighBack = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this._peakMeter.ColorMedium = System.Drawing.Color.Yellow;
            this._peakMeter.ColorMediumBack = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this._peakMeter.ColorNormal = System.Drawing.Color.Green;
            this._peakMeter.ColorNormalBack = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this._peakMeter.FalloffColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._peakMeter.FalloffEffect = false;
            this._peakMeter.GridColor = System.Drawing.Color.Gainsboro;
            this._peakMeter.LEDCount = 15;
            this._peakMeter.Location = new System.Drawing.Point(650, 366);
            this._peakMeter.Name = "_peakMeter";
            this._peakMeter.ShowGrid = false;
            this._peakMeter.Size = new System.Drawing.Size(20, 109);
            this._peakMeter.TabIndex = 22;
            this._peakMeter.Text = "peakMeterCtrl1";
            // 
            // _lineCountLabel
            // 
            this._lineCountLabel.AutoSize = true;
            this._lineCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this._lineCountLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lineCountLabel.ForeColor = System.Drawing.Color.DarkGray;
            this._lineCountLabel.Location = new System.Drawing.Point(638, 249);
            this._lineCountLabel.Name = "_lineCountLabel";
            this._lineCountLabel.Size = new System.Drawing.Size(42, 25);
            this._lineCountLabel.TabIndex = 25;
            this._lineCountLabel.Text = "997";
            this._lineCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _audioButtonsControl
            // 
            this._audioButtonsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._audioButtonsControl.BackColor = System.Drawing.Color.Transparent;
            this._audioButtonsControl.ButtonHighlightMode = HearThis.UI.AudioButtonsControl.ButtonHighlightModes.Default;
            this._audioButtonsControl.Location = new System.Drawing.Point(557, 308);
            this._audioButtonsControl.Name = "_audioButtonsControl";
            this._audioButtonsControl.Path = "";
            this._audioButtonsControl.RecordingDevice = null;
            this._audioButtonsControl.Size = new System.Drawing.Size(123, 43);
            this._audioButtonsControl.TabIndex = 20;
            this._audioButtonsControl.NextClick += new System.EventHandler(this.OnNextButton);
            // 
            // _scriptControl
            // 
            this._scriptControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._scriptControl.BackColor = System.Drawing.Color.Transparent;
            this._scriptControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scriptControl.ForeColor = System.Drawing.Color.White;
            this._scriptControl.Location = new System.Drawing.Point(19, 312);
            this._scriptControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._scriptControl.Name = "_scriptControl";
            this._scriptControl.Size = new System.Drawing.Size(531, 173);
            this._scriptControl.TabIndex = 15;
            this._scriptControl.ZoomFactor = 1F;
            // 
            // _scriptLineSlider
            // 
            this._scriptLineSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._scriptLineSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this._scriptLineSlider.Location = new System.Drawing.Point(19, 280);
            this._scriptLineSlider.Maximum = 50;
            this._scriptLineSlider.Minimum = 1;
            this._scriptLineSlider.Name = "_scriptLineSlider";
            this._scriptLineSlider.Size = new System.Drawing.Size(661, 25);
            this._scriptLineSlider.TabIndex = 11;
            this._scriptLineSlider.Value = 4;
            this._scriptLineSlider.ValueChanged += new System.EventHandler(this.OnLineSlider_ValueChanged);
            // 
            // _toolStrip
            // 
            this._toolStrip.BackColor = System.Drawing.Color.Transparent;
            this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(698, 25);
            this._toolStrip.TabIndex = 34;
            this._toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::HearThis.Properties.Resources.save;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "About...";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.OnAboutClick);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::HearThis.Properties.Resources.folder;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.OnChangeProjectButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::HearThis.Properties.Resources.sabber;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.OnPublishClick);
            // 
            // RecordingToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this._largerButton);
            this.Controls.Add(this._smallerButton);
            this.Controls.Add(this._lineCountLabel);
            this.Controls.Add(this.recordingDeviceButton1);
            this.Controls.Add(this._peakMeter);
            this.Controls.Add(this._audioButtonsControl);
            this.Controls.Add(this._scriptControl);
            this.Controls.Add(this._segmentLabel);
            this.Controls.Add(this._scriptLineSlider);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecordingToolControl";
            this.Size = new System.Drawing.Size(698, 518);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RecordingToolControl_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecordingToolControl_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scriptLineSlider)).EndInit();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _bookFlow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _bookLabel;
        private System.Windows.Forms.Label _chapterLabel;
        private System.Windows.Forms.FlowLayoutPanel _chapterFlow;
        private DiscontiguousProgressTrackBar _scriptLineSlider;
        private System.Windows.Forms.Label _segmentLabel;
        private ScriptControl _scriptControl;
        private AudioButtonsControl _audioButtonsControl;
        private System.Windows.Forms.ToolTip toolTip1;
        private PeakMeterCtrl _peakMeter;
        private System.Windows.Forms.ToolTip _instantToolTip;
        private RecordingDeviceButton recordingDeviceButton1;
        private System.Windows.Forms.Label _lineCountLabel;
        private System.Windows.Forms.Button _smallerButton;
        private System.Windows.Forms.Button _largerButton;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
