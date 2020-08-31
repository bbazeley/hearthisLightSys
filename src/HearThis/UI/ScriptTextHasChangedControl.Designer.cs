using System;

namespace HearThis.UI
{
    partial class ScriptTextHasChangedControl
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._lblProblemSummary = new System.Windows.Forms.Label();
			this._flowLayoutPanelThen = new System.Windows.Forms.FlowLayoutPanel();
			this._lblThen = new System.Windows.Forms.Label();
			this._lblRecordedDate = new System.Windows.Forms.Label();
			this._lblNow = new System.Windows.Forms.Label();
			this._chkIgnoreProblem = new System.Windows.Forms.CheckBox();
			this._txtThen = new System.Windows.Forms.TextBox();
			this._txtNow = new System.Windows.Forms.TextBox();
			this._audioButtonsControl = new HearThis.UI.AudioButtonsControl();
			this.l10NSharpExtender1 = new L10NSharp.UI.L10NSharpExtender(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this._flowLayoutPanelThen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this._lblProblemSummary, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._flowLayoutPanelThen, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._lblNow, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._chkIgnoreProblem, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this._txtThen, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this._txtNow, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this._audioButtonsControl, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(571, 216);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _lblProblemSummary
			// 
			this._lblProblemSummary.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this._lblProblemSummary, 2);
			this._lblProblemSummary.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblProblemSummary, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblProblemSummary, null);
			this.l10NSharpExtender1.SetLocalizingId(this._lblProblemSummary, "ScriptTextHasChangedControl._lblProblemSummary");
			this._lblProblemSummary.Location = new System.Drawing.Point(3, 0);
			this._lblProblemSummary.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
			this._lblProblemSummary.Name = "_lblProblemSummary";
			this._lblProblemSummary.Size = new System.Drawing.Size(429, 25);
			this._lblProblemSummary.TabIndex = 0;
			this._lblProblemSummary.Text = "Problem: The text has changed since it was recorded.";
			// 
			// _flowLayoutPanelThen
			// 
			this._flowLayoutPanelThen.Controls.Add(this._lblThen);
			this._flowLayoutPanelThen.Controls.Add(this._lblRecordedDate);
			this._flowLayoutPanelThen.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flowLayoutPanelThen.Location = new System.Drawing.Point(0, 33);
			this._flowLayoutPanelThen.Margin = new System.Windows.Forms.Padding(0);
			this._flowLayoutPanelThen.Name = "_flowLayoutPanelThen";
			this._flowLayoutPanelThen.Size = new System.Drawing.Size(534, 25);
			this._flowLayoutPanelThen.TabIndex = 3;
			// 
			// _lblThen
			// 
			this._lblThen.AutoSize = true;
			this._lblThen.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblThen, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblThen, null);
			this.l10NSharpExtender1.SetLocalizingId(this._lblThen, "ScriptTextHasChangedControl._lblThen");
			this._lblThen.Location = new System.Drawing.Point(3, 0);
			this._lblThen.Name = "_lblThen";
			this._lblThen.Size = new System.Drawing.Size(55, 25);
			this._lblThen.TabIndex = 2;
			this._lblThen.Text = "Then";
			// 
			// _lblRecordedDate
			// 
			this._lblRecordedDate.AutoSize = true;
			this._lblRecordedDate.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblRecordedDate, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblRecordedDate, null);
			this.l10NSharpExtender1.SetLocalizingId(this._lblRecordedDate, "ScriptTextHasChangedControl._lblRecordedDate");
			this._lblRecordedDate.Location = new System.Drawing.Point(64, 0);
			this._lblRecordedDate.Name = "_lblRecordedDate";
			this._lblRecordedDate.Size = new System.Drawing.Size(42, 25);
			this._lblRecordedDate.TabIndex = 3;
			this._lblRecordedDate.Text = "({0})";
			// 
			// _lblNow
			// 
			this._lblNow.AutoSize = true;
			this._lblNow.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblNow, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblNow, null);
			this.l10NSharpExtender1.SetLocalizingId(this._lblNow, "ScriptTextHasChangedControl._lblNow");
			this._lblNow.Location = new System.Drawing.Point(3, 109);
			this._lblNow.Name = "_lblNow";
			this._lblNow.Size = new System.Drawing.Size(51, 25);
			this._lblNow.TabIndex = 4;
			this._lblNow.Text = "Now";
			// 
			// _chkIgnoreProblem
			// 
			this._chkIgnoreProblem.AutoSize = true;
			this._chkIgnoreProblem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l10NSharpExtender1.SetLocalizableToolTip(this._chkIgnoreProblem, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._chkIgnoreProblem, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._chkIgnoreProblem, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._chkIgnoreProblem, "ScriptTextHasChangedControl._chkIgnoreProblem");
			this._chkIgnoreProblem.Location = new System.Drawing.Point(8, 188);
			this._chkIgnoreProblem.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this._chkIgnoreProblem.Name = "_chkIgnoreProblem";
			this._chkIgnoreProblem.Size = new System.Drawing.Size(260, 25);
			this._chkIgnoreProblem.TabIndex = 5;
			this._chkIgnoreProblem.Text = "Ignore this problem for this block";
			this._chkIgnoreProblem.UseVisualStyleBackColor = true;
			this._chkIgnoreProblem.CheckedChanged += new System.EventHandler(this._chkIgnoreProblem_CheckedChanged);
			// 
			// _txtThen
			// 
			this._txtThen.BackColor = System.Drawing.SystemColors.Window;
			this._txtThen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._txtThen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._txtThen, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._txtThen, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._txtThen, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._txtThen, "ScriptTextHasChangedControl._txtThen");
			this._txtThen.Location = new System.Drawing.Point(9, 64);
			this._txtThen.Margin = new System.Windows.Forms.Padding(9, 6, 3, 3);
			this._txtThen.Multiline = true;
			this._txtThen.Name = "_txtThen";
			this._txtThen.ReadOnly = true;
			this._txtThen.Size = new System.Drawing.Size(522, 42);
			this._txtThen.TabIndex = 6;
			// 
			// _txtNow
			// 
			this._txtNow.BackColor = System.Drawing.SystemColors.Window;
			this._txtNow.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._txtNow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._txtNow, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._txtNow, null);
			this.l10NSharpExtender1.SetLocalizingId(this._txtNow, "textBox1");
			this._txtNow.Location = new System.Drawing.Point(9, 140);
			this._txtNow.Margin = new System.Windows.Forms.Padding(9, 6, 3, 3);
			this._txtNow.Multiline = true;
			this._txtNow.Name = "_txtNow";
			this._txtNow.ReadOnly = true;
			this._txtNow.Size = new System.Drawing.Size(522, 42);
			this._txtNow.TabIndex = 7;
			// 
			// _audioButtonsControl
			// 
			this._audioButtonsControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._audioButtonsControl.AutoSize = true;
			this._audioButtonsControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._audioButtonsControl.BackColor = System.Drawing.Color.Transparent;
			this._audioButtonsControl.ButtonHighlightMode = HearThis.UI.AudioButtonsControl.ButtonHighlightModes.Default;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._audioButtonsControl, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._audioButtonsControl, null);
			this.l10NSharpExtender1.SetLocalizingId(this._audioButtonsControl, "AudioButtonsControl");
			this._audioButtonsControl.Location = new System.Drawing.Point(534, 63);
			this._audioButtonsControl.Margin = new System.Windows.Forms.Padding(0);
			this._audioButtonsControl.Name = "_audioButtonsControl";
			this._audioButtonsControl.RecordingDevice = null;
			this._audioButtonsControl.ShowNextButton = false;
			this._audioButtonsControl.ShowPlayButton = true;
			this._audioButtonsControl.ShowRecordButton = false;
			this._audioButtonsControl.Size = new System.Drawing.Size(37, 40);
			this._audioButtonsControl.TabIndex = 8;
			// 
			// l10NSharpExtender1
			// 
			this.l10NSharpExtender1.LocalizationManagerId = "HearThis";
			this.l10NSharpExtender1.PrefixForNewItems = "";
			// 
			// ScriptTextHasChangedControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.tableLayoutPanel1);
			this.ForeColor = System.Drawing.Color.DarkGray;
			this.l10NSharpExtender1.SetLocalizableToolTip(this, null);
			this.l10NSharpExtender1.SetLocalizationComment(this, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this, "ScriptTextHasChangedControl.ScriptChangedControl");
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Name = "ScriptTextHasChangedControl";
			this.Size = new System.Drawing.Size(571, 216);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this._flowLayoutPanelThen.ResumeLayout(false);
			this._flowLayoutPanelThen.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label _lblProblemSummary;
		private L10NSharp.UI.L10NSharpExtender l10NSharpExtender1;
		private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanelThen;
		private System.Windows.Forms.Label _lblThen;
		private System.Windows.Forms.Label _lblRecordedDate;
		private System.Windows.Forms.Label _lblNow;
		private System.Windows.Forms.CheckBox _chkIgnoreProblem;
		private System.Windows.Forms.TextBox _txtThen;
		private System.Windows.Forms.TextBox _txtNow;
		private AudioButtonsControl _audioButtonsControl;
	}
}
