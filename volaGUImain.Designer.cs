using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VolaGUI_Final
{
    partial class volaguiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
               

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(volaguiForm));
            this.imageStatus = new System.Windows.Forms.Label();
            this.profileStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.commandGBox = new System.Windows.Forms.GroupBox();
            this.commandDescription = new System.Windows.Forms.TextBox();
            this.commandSelection = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.commandGBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageStatus
            // 
            this.imageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageStatus.AutoSize = true;
            this.imageStatus.Location = new System.Drawing.Point(2, 477);
            this.imageStatus.MaximumSize = new System.Drawing.Size(200, 20);
            this.imageStatus.MinimumSize = new System.Drawing.Size(200, 20);
            this.imageStatus.Name = "imageStatus";
            this.imageStatus.Size = new System.Drawing.Size(200, 20);
            this.imageStatus.TabIndex = 1;
            this.imageStatus.Text = "Image: ";
            this.imageStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // profileStatus
            // 
            this.profileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.profileStatus.AutoSize = true;
            this.profileStatus.Location = new System.Drawing.Point(421, 476);
            this.profileStatus.MaximumSize = new System.Drawing.Size(200, 20);
            this.profileStatus.MinimumSize = new System.Drawing.Size(200, 20);
            this.profileStatus.Name = "profileStatus";
            this.profileStatus.Size = new System.Drawing.Size(200, 20);
            this.profileStatus.TabIndex = 2;
            this.profileStatus.Text = "Profile:";
            this.profileStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tabControl1
            // COMMENT OUT ONLY THE "this.tabControl1.Controls.Add(this.tabPage1);" LINE
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 447);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // COMMENT OUT
            //
            this.tabPage1.Controls.Add(this.optionsGBox);
            this.tabPage1.Controls.Add(this.commandGBox);
            this.tabPage1.Controls.Add(this.executionBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;




            this.optionsGBox = new GroupBox();
            this.optionsGBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsGBox.Location = new System.Drawing.Point(3, 74);
            this.optionsGBox.Name = "optionsGBox";
            this.optionsGBox.Size = new System.Drawing.Size(585, 108);
            this.optionsGBox.TabIndex = 2;
            this.optionsGBox.TabStop = false;
            this.optionsGBox.Text = "Command Options";
            // 
            // commandGBox
            // COMMENT OUT
            //
            
            this.commandGBox.Controls.Add(this.commandDescription);
            this.commandGBox.Controls.Add(this.commandSelection);
            this.commandGBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandGBox.Location = new System.Drawing.Point(3, 3);
            this.commandGBox.Name = "commandGBox";
            this.commandGBox.Size = new System.Drawing.Size(585, 71);
            this.commandGBox.TabIndex = 1;
            this.commandGBox.TabStop = false;
            this.commandGBox.Text = "Command";
            
            // 
            // commandDescription
            // COMMENT OUT
            //
            
            this.commandDescription.Location = new System.Drawing.Point(168, 16);
            this.commandDescription.MaximumSize = new System.Drawing.Size(411, 45);
            this.commandDescription.MinimumSize = new System.Drawing.Size(411, 45);
            this.commandDescription.Multiline = true;
            this.commandDescription.Name = "commandDescription";
            this.commandDescription.Size = new System.Drawing.Size(411, 45);
            this.commandDescription.TabIndex = 1;
            this.commandDescription.Text = "Description";
            
            // 
            // commandSelection
            // COMMENT OUT
            //
            
            this.commandSelection.FormattingEnabled = true;
            this.commandSelection.Location = new System.Drawing.Point(3, 16);
            this.commandSelection.Name = "commandSelection";
            this.commandSelection.Size = new System.Drawing.Size(158, 21);
            this.commandSelection.TabIndex = 0;
            




            this.executionBox = new GroupBox( );
            this.executionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            this.executionBox.Location = new System.Drawing.Point(3, 188);
            this.executionBox.Name = "executionBox";
            this.executionBox.Size = new System.Drawing.Size(585, 227);
            this.executionBox.TabIndex = 0;
            this.executionBox.TabStop = false;
            this.executionBox.Text = "Command Execution";



            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCaseToolStripMenuItem,
            this.loadCaseToolStripMenuItem,
            this.saveCaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCaseToolStripMenuItem
            // 
            this.newCaseToolStripMenuItem.Name = "newCaseToolStripMenuItem";
            this.newCaseToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.newCaseToolStripMenuItem.Text = "New Case";
            // 
            // loadCaseToolStripMenuItem
            // 
            this.loadCaseToolStripMenuItem.Name = "loadCaseToolStripMenuItem";
            this.loadCaseToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.loadCaseToolStripMenuItem.Text = "Load Case";
            // 
            // saveCaseToolStripMenuItem
            // 
            this.saveCaseToolStripMenuItem.Name = "saveCaseToolStripMenuItem";
            this.saveCaseToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saveCaseToolStripMenuItem.Text = "Save Case";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // volaguiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.profileStatus);
            this.Controls.Add(this.imageStatus);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "volaguiForm";
            this.Text = "VolaGUI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.commandGBox.ResumeLayout(false);
            this.commandGBox.PerformLayout();
            this.optionsGBox.ResumeLayout(false);
            this.optionsGBox.PerformLayout();
            this.executionBox.ResumeLayout(false);
            this.executionBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label imageStatus;
        private Label profileStatus;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox optionsGBox;
        private GroupBox commandGBox;
        private GroupBox executionBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newCaseToolStripMenuItem;
        private ToolStripMenuItem loadCaseToolStripMenuItem;
        private ToolStripMenuItem saveCaseToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ComboBox commandSelection;
        private TextBox commandDescription;
    }
    partial class commandBox
    {
        public GroupBox commandGBox = new GroupBox();
        private ComboBox commandSelection = new ComboBox();
        private TextBox commandDescription = new TextBox();
        List<string> commands;
     

        public void initiate(List<string> commands)
        {
            this.commands = commands;
            commandGBox.Controls.Add(commandDescription);
            commandGBox.Controls.Add(commandSelection);
            commandGBox.Dock = System.Windows.Forms.DockStyle.Top;
            commandGBox.Location = new System.Drawing.Point(3, 3);
            commandGBox.Name = "commandGBox";
            commandGBox.Size = new System.Drawing.Size(585, 71);
            commandGBox.TabIndex = 1;
            commandGBox.TabStop = false;
            commandGBox.Text = "Command";

            //
            //commandDescription
            //
            this.commandDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandDescription.Location = new System.Drawing.Point(168, 16);
            this.commandDescription.MinimumSize = new System.Drawing.Size(0, 45);
            this.commandDescription.Multiline = true;
            this.commandDescription.Name = "commandDescription";
            this.commandDescription.Size = new System.Drawing.Size(411, 45);
            this.commandDescription.TabIndex = 1;
            this.commandDescription.Text = "";
            this.commandDescription.ReadOnly = true;
            // 
            // commandSelection
            // 
            this.commandSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commandSelection.FormattingEnabled = true;
            this.commandSelection.Location = new System.Drawing.Point(3, 16);
            this.commandSelection.Name = "commandSelection";
            this.commandSelection.Size = new System.Drawing.Size(158, 21);
            this.commandSelection.TabIndex = 0;
            this.commandSelection.SelectedIndexChanged += new System.EventHandler(this.commandSelection_SelectedIndexChanged);
            

            this.commandGBox.SuspendLayout();
            this.commandGBox.ResumeLayout(false);
            this.commandGBox.PerformLayout();
        }
    }
        
    class optionBox
    {
        public GroupBox optionsGBox = new GroupBox( );

        public void initiate ( )
        {
            this.optionsGBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsGBox.Location = new System.Drawing.Point(3, 74);
            this.optionsGBox.Name = "optionsGBox";
            this.optionsGBox.Size = new System.Drawing.Size(585, 108);
            this.optionsGBox.TabIndex = 2;
            this.optionsGBox.TabStop = false;
            this.optionsGBox.Text = "Command Options";

            //this.optionsGBox.SuspendLayout();
            this.optionsGBox.ResumeLayout(false);
            this.optionsGBox.PerformLayout();
        }
    }



    class executionBox
    {
        public GroupBox executionGBox = new GroupBox( );

        public void initiate ( )
        {
            this.executionGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executionGBox.Location = new System.Drawing.Point(3, 188);
            this.executionGBox.Name = "executionBox";
            this.executionGBox.Size = new System.Drawing.Size(585, 227);
            this.executionGBox.TabIndex = 0;
            this.executionGBox.TabStop = false;
            this.executionGBox.Text = "Command Execution";

            this.executionGBox.SuspendLayout();
            this.executionGBox.ResumeLayout(false);
            this.executionGBox.PerformLayout();
        }
    }
}

