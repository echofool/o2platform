// This file is part of the OWASP O2 Platform (http://www.owasp.org/index.php/OWASP_O2_Platform) and is released under the Apache 2.0 License (http://www.apache.org/licenses/LICENSE-2.0)
namespace O2.Core.XRules.Ascx
{
    partial class ascx_XRules_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ascx_XRules_Editor));
            this.scTopLevel = new System.Windows.Forms.SplitContainer();
            this.cbShowFileContentsOnMouseOver = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.directoryWithLocalXRules = new O2.Views.ASCX.CoreControls.ascx_Directory();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCreateRuleFromTemplate = new System.Windows.Forms.Button();
            this.tbNewRuleName = new System.Windows.Forms.TextBox();
            this.lbCurrentXRulesTemplates = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.directoryWithXRulesDatabase = new O2.Views.ASCX.CoreControls.ascx_Directory();
            this.llReloadSelectedSourceCodeFile = new System.Windows.Forms.LinkLabel();
            this.llRemoveSelectedSourceCodeFile = new System.Windows.Forms.LinkLabel();
            this.tcTabControlWithRulesSource = new System.Windows.Forms.TabControl();
            this.tpNoRulesLoaded = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btLoadXRulesUnitTests = new System.Windows.Forms.ToolStripButton();
            this.btLoadUnitTestFromLocalO2Development = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbFileToOpen = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.llReloadLocalXRulesDatabase = new System.Windows.Forms.LinkLabel();
            this.scTopLevel.Panel1.SuspendLayout();
            this.scTopLevel.Panel2.SuspendLayout();
            this.scTopLevel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tcTabControlWithRulesSource.SuspendLayout();
            this.tpNoRulesLoaded.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scTopLevel
            // 
            this.scTopLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scTopLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTopLevel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scTopLevel.Location = new System.Drawing.Point(0, 0);
            this.scTopLevel.Name = "scTopLevel";
            // 
            // scTopLevel.Panel1
            // 
            this.scTopLevel.Panel1.Controls.Add(this.cbShowFileContentsOnMouseOver);
            this.scTopLevel.Panel1.Controls.Add(this.splitContainer1);
            // 
            // scTopLevel.Panel2
            // 
            this.scTopLevel.Panel2.Controls.Add(this.llReloadSelectedSourceCodeFile);
            this.scTopLevel.Panel2.Controls.Add(this.llRemoveSelectedSourceCodeFile);
            this.scTopLevel.Panel2.Controls.Add(this.tcTabControlWithRulesSource);
            this.scTopLevel.Size = new System.Drawing.Size(812, 460);
            this.scTopLevel.SplitterDistance = 329;
            this.scTopLevel.TabIndex = 10;
            // 
            // cbShowFileContentsOnMouseOver
            // 
            this.cbShowFileContentsOnMouseOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowFileContentsOnMouseOver.AutoSize = true;
            this.cbShowFileContentsOnMouseOver.Location = new System.Drawing.Point(7, 436);
            this.cbShowFileContentsOnMouseOver.Name = "cbShowFileContentsOnMouseOver";
            this.cbShowFileContentsOnMouseOver.Size = new System.Drawing.Size(186, 17);
            this.cbShowFileContentsOnMouseOver.TabIndex = 5;
            this.cbShowFileContentsOnMouseOver.Text = "Show file contents on mouse over";
            this.cbShowFileContentsOnMouseOver.UseVisualStyleBackColor = true;
            this.cbShowFileContentsOnMouseOver.CheckedChanged += new System.EventHandler(this.cbShowFileContentsOnMouseOver_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(330, 436);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.llReloadLocalXRulesDatabase);
            this.groupBox3.Controls.Add(this.directoryWithLocalXRules);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.menuStrip2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 281);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XRules (From LOCAL XRules database)";
            // 
            // directoryWithLocalXRules
            // 
            this.directoryWithLocalXRules._FileFilter = "*.*";
            this.directoryWithLocalXRules._ProcessDroppedObjects = true;
            this.directoryWithLocalXRules._ShowFileContentsOnTopTip = false;
            this.directoryWithLocalXRules._ShowFileSize = false;
            this.directoryWithLocalXRules._ShowLinkToUpperFolder = true;
            this.directoryWithLocalXRules._ViewMode = O2.Views.ASCX.CoreControls.ascx_Directory.ViewMode.Simple_With_LocationBar;
            this.directoryWithLocalXRules._WatchFolder = true;
            this.directoryWithLocalXRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryWithLocalXRules.BackColor = System.Drawing.SystemColors.Control;
            this.directoryWithLocalXRules.ForeColor = System.Drawing.Color.Black;
            this.directoryWithLocalXRules.Location = new System.Drawing.Point(3, 64);
            this.directoryWithLocalXRules.Name = "directoryWithLocalXRules";
            this.directoryWithLocalXRules.Size = new System.Drawing.Size(324, 137);
            this.directoryWithLocalXRules.TabIndex = 0;
            this.directoryWithLocalXRules._onDirectoryClick += new O2.Kernel.CodeUtils.Callbacks.dMethod_String(this.directoryWithLocalXRules__onDirectoryClick);
            this.directoryWithLocalXRules._onDirectoryDoubleClick += new O2.Kernel.CodeUtils.Callbacks.dMethod_String(this.directoryWithLocalXRules__onDirectoryDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btCreateRuleFromTemplate);
            this.groupBox1.Controls.Add(this.tbNewRuleName);
            this.groupBox1.Controls.Add(this.lbCurrentXRulesTemplates);
            this.groupBox1.Location = new System.Drawing.Point(1, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Rule from template";
            // 
            // btCreateRuleFromTemplate
            // 
            this.btCreateRuleFromTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateRuleFromTemplate.Location = new System.Drawing.Point(210, 46);
            this.btCreateRuleFromTemplate.Name = "btCreateRuleFromTemplate";
            this.btCreateRuleFromTemplate.Size = new System.Drawing.Size(116, 23);
            this.btCreateRuleFromTemplate.TabIndex = 2;
            this.btCreateRuleFromTemplate.Text = "create rule";
            this.btCreateRuleFromTemplate.UseVisualStyleBackColor = true;
            this.btCreateRuleFromTemplate.Click += new System.EventHandler(this.btCreateRuleFromTemplate_Click);
            // 
            // tbNewRuleName
            // 
            this.tbNewRuleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewRuleName.Location = new System.Drawing.Point(210, 13);
            this.tbNewRuleName.Name = "tbNewRuleName";
            this.tbNewRuleName.Size = new System.Drawing.Size(116, 20);
            this.tbNewRuleName.TabIndex = 1;
            // 
            // lbCurrentXRulesTemplates
            // 
            this.lbCurrentXRulesTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCurrentXRulesTemplates.FormattingEnabled = true;
            this.lbCurrentXRulesTemplates.Location = new System.Drawing.Point(6, 13);
            this.lbCurrentXRulesTemplates.Name = "lbCurrentXRulesTemplates";
            this.lbCurrentXRulesTemplates.Size = new System.Drawing.Size(197, 56);
            this.lbCurrentXRulesTemplates.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.directoryWithXRulesDatabase);
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XRules (From O2\'s database)";
            // 
            // directoryWithXRulesDatabase
            // 
            this.directoryWithXRulesDatabase._FileFilter = "*.*";
            this.directoryWithXRulesDatabase._ProcessDroppedObjects = true;
            this.directoryWithXRulesDatabase._ShowFileContentsOnTopTip = false;
            this.directoryWithXRulesDatabase._ShowFileSize = false;
            this.directoryWithXRulesDatabase._ShowLinkToUpperFolder = true;
            this.directoryWithXRulesDatabase._ViewMode = O2.Views.ASCX.CoreControls.ascx_Directory.ViewMode.Simple_With_LocationBar;
            this.directoryWithXRulesDatabase._WatchFolder = true;
            this.directoryWithXRulesDatabase.BackColor = System.Drawing.SystemColors.Control;
            this.directoryWithXRulesDatabase.ForeColor = System.Drawing.Color.Black;
            this.directoryWithXRulesDatabase.Location = new System.Drawing.Point(3, 75);
            this.directoryWithXRulesDatabase.Name = "directoryWithXRulesDatabase";
            this.directoryWithXRulesDatabase.Size = new System.Drawing.Size(319, 73);
            this.directoryWithXRulesDatabase.TabIndex = 0;
            this.directoryWithXRulesDatabase._onDirectoryClick += new O2.Kernel.CodeUtils.Callbacks.dMethod_String(this.directoryWithXRulesDatabase__onDirectoryClick);
            this.directoryWithXRulesDatabase._onDirectoryDoubleClick += new O2.Kernel.CodeUtils.Callbacks.dMethod_String(this.directoryWithXRulesDatabase__onDirectoryDoubleClick);
            // 
            // llReloadSelectedSourceCodeFile
            // 
            this.llReloadSelectedSourceCodeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llReloadSelectedSourceCodeFile.AutoSize = true;
            this.llReloadSelectedSourceCodeFile.Location = new System.Drawing.Point(270, 1);
            this.llReloadSelectedSourceCodeFile.Name = "llReloadSelectedSourceCodeFile";
            this.llReloadSelectedSourceCodeFile.Size = new System.Drawing.Size(95, 13);
            this.llReloadSelectedSourceCodeFile.TabIndex = 2;
            this.llReloadSelectedSourceCodeFile.TabStop = true;
            this.llReloadSelectedSourceCodeFile.Text = "reload selected file";
            this.llReloadSelectedSourceCodeFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llReloadSelectedSourceCodeFile_LinkClicked);
            // 
            // llRemoveSelectedSourceCodeFile
            // 
            this.llRemoveSelectedSourceCodeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llRemoveSelectedSourceCodeFile.AutoSize = true;
            this.llRemoveSelectedSourceCodeFile.Location = new System.Drawing.Point(371, 1);
            this.llRemoveSelectedSourceCodeFile.Name = "llRemoveSelectedSourceCodeFile";
            this.llRemoveSelectedSourceCodeFile.Size = new System.Drawing.Size(101, 13);
            this.llRemoveSelectedSourceCodeFile.TabIndex = 1;
            this.llRemoveSelectedSourceCodeFile.TabStop = true;
            this.llRemoveSelectedSourceCodeFile.Text = "remove selected file";
            this.llRemoveSelectedSourceCodeFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveSelectedSourceCodeFile_LinkClicked);
            // 
            // tcTabControlWithRulesSource
            // 
            this.tcTabControlWithRulesSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTabControlWithRulesSource.Controls.Add(this.tpNoRulesLoaded);
            this.tcTabControlWithRulesSource.Location = new System.Drawing.Point(3, 17);
            this.tcTabControlWithRulesSource.Name = "tcTabControlWithRulesSource";
            this.tcTabControlWithRulesSource.SelectedIndex = 0;
            this.tcTabControlWithRulesSource.Size = new System.Drawing.Size(475, 436);
            this.tcTabControlWithRulesSource.TabIndex = 0;
            // 
            // tpNoRulesLoaded
            // 
            this.tpNoRulesLoaded.Controls.Add(this.label1);
            this.tpNoRulesLoaded.Location = new System.Drawing.Point(4, 22);
            this.tpNoRulesLoaded.Name = "tpNoRulesLoaded";
            this.tpNoRulesLoaded.Padding = new System.Windows.Forms.Padding(3);
            this.tpNoRulesLoaded.Size = new System.Drawing.Size(467, 410);
            this.tpNoRulesLoaded.TabIndex = 0;
            this.tpNoRulesLoaded.Text = "no rules loaded";
            this.tpNoRulesLoaded.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose rule to edit from XRules Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btLoadXRulesUnitTests,
            this.btLoadUnitTestFromLocalO2Development,
            this.toolStripLabel2,
            this.tbFileToOpen,
            this.toolStripLabel1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(324, 27);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btLoadXRulesUnitTests
            // 
            this.btLoadXRulesUnitTests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btLoadXRulesUnitTests.Image = ((System.Drawing.Image)(resources.GetObject("btLoadXRulesUnitTests.Image")));
            this.btLoadXRulesUnitTests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLoadXRulesUnitTests.Name = "btLoadXRulesUnitTests";
            this.btLoadXRulesUnitTests.Size = new System.Drawing.Size(23, 20);
            this.btLoadXRulesUnitTests.Text = "Load XRules Units test (from O2 source code)";
            // 
            // btLoadUnitTestFromLocalO2Development
            // 
            this.btLoadUnitTestFromLocalO2Development.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btLoadUnitTestFromLocalO2Development.Image = ((System.Drawing.Image)(resources.GetObject("btLoadUnitTestFromLocalO2Development.Image")));
            this.btLoadUnitTestFromLocalO2Development.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLoadUnitTestFromLocalO2Development.Name = "btLoadUnitTestFromLocalO2Development";
            this.btLoadUnitTestFromLocalO2Development.Size = new System.Drawing.Size(23, 20);
            this.btLoadUnitTestFromLocalO2Development.Text = "Load Unit test (from O2 source code)";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 20);
            this.toolStripLabel1.Text = "reload XRules";
            this.toolStripLabel1.Click += new System.EventHandler(this.llReloadLocalXRulesDatabase_LinkClicked);
            // 
            // tbFileToOpen
            // 
            this.tbFileToOpen.Name = "tbFileToOpen";
            this.tbFileToOpen.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 20);
            this.toolStripLabel2.Text = "Open File:";
            // 
            // llReloadLocalXRulesDatabase
            // 
            this.llReloadLocalXRulesDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llReloadLocalXRulesDatabase.AutoSize = true;
            this.llReloadLocalXRulesDatabase.Location = new System.Drawing.Point(226, 48);
            this.llReloadLocalXRulesDatabase.Name = "llReloadLocalXRulesDatabase";
            this.llReloadLocalXRulesDatabase.Size = new System.Drawing.Size(98, 13);
            this.llReloadLocalXRulesDatabase.TabIndex = 2;
            this.llReloadLocalXRulesDatabase.TabStop = true;
            this.llReloadLocalXRulesDatabase.Text = "reload local XRules";
            this.llReloadLocalXRulesDatabase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llReloadLocalXRulesDatabase_LinkClicked);
            // 
            // ascx_XRules_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scTopLevel);
            this.Name = "ascx_XRules_Editor";
            this.Size = new System.Drawing.Size(812, 460);
            this.Load += new System.EventHandler(this.ascx_XRules_Editor_Load);
            this.scTopLevel.Panel1.ResumeLayout(false);
            this.scTopLevel.Panel1.PerformLayout();
            this.scTopLevel.Panel2.ResumeLayout(false);
            this.scTopLevel.Panel2.PerformLayout();
            this.scTopLevel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tcTabControlWithRulesSource.ResumeLayout(false);
            this.tpNoRulesLoaded.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scTopLevel;
        private O2.Views.ASCX.CoreControls.ascx_Directory directoryWithXRulesDatabase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCreateRuleFromTemplate;
        private System.Windows.Forms.TextBox tbNewRuleName;
        private System.Windows.Forms.ListBox lbCurrentXRulesTemplates;
        private System.Windows.Forms.TabControl tcTabControlWithRulesSource;
        private System.Windows.Forms.TabPage tpNoRulesLoaded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private O2.Views.ASCX.CoreControls.ascx_Directory directoryWithLocalXRules;
        private System.Windows.Forms.LinkLabel llRemoveSelectedSourceCodeFile;
        private System.Windows.Forms.LinkLabel llReloadSelectedSourceCodeFile;
        private System.Windows.Forms.CheckBox cbShowFileContentsOnMouseOver;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripButton btLoadXRulesUnitTests;
        private System.Windows.Forms.ToolStripButton btLoadUnitTestFromLocalO2Development;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbFileToOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.LinkLabel llReloadLocalXRulesDatabase;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}
