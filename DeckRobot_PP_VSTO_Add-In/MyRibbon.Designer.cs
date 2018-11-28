namespace DeckRobot_PP_VSTO_Add_In
{
    partial class TestRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TestRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestRibbon));
            this.AddInTab = this.Factory.CreateRibbonTab();
            this.testGroup = this.Factory.CreateRibbonGroup();
            this.ToRightBoldRed_Button = this.Factory.CreateRibbonButton();
            this.AddInTab.SuspendLayout();
            this.testGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddInTab
            // 
            this.AddInTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.AddInTab.Groups.Add(this.testGroup);
            this.AddInTab.Label = "Add-Ins Tab";
            this.AddInTab.Name = "AddInTab";
            // 
            // testGroup
            // 
            this.testGroup.Items.Add(this.ToRightBoldRed_Button);
            this.testGroup.Label = "DeckRobot C# Test";
            this.testGroup.Name = "testGroup";
            // 
            // ToRightBoldRed_Button
            // 
            this.ToRightBoldRed_Button.Image = ((System.Drawing.Image)(resources.GetObject("ToRightBoldRed_Button.Image")));
            this.ToRightBoldRed_Button.Label = "ToRightBoldRed";
            this.ToRightBoldRed_Button.Name = "ToRightBoldRed_Button";
            this.ToRightBoldRed_Button.ShowImage = true;
            this.ToRightBoldRed_Button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToRightBoldRed_Button_Click);
            // 
            // TestRibbon
            // 
            this.Name = "TestRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.AddInTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MyRibbon_Load);
            this.AddInTab.ResumeLayout(false);
            this.AddInTab.PerformLayout();
            this.testGroup.ResumeLayout(false);
            this.testGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab AddInTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup testGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ToRightBoldRed_Button;
    }

    partial class ThisRibbonCollection
    {
        internal TestRibbon MyRibbon
        {
            get { return this.GetRibbon<TestRibbon>(); }
        }
    }
}
