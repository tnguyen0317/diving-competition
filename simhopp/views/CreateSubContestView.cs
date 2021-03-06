﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simhopp
{
    public class CreateSubContestView : PanelViewControl , ICreateSubContestView
    {
        #region Fields
        private TextBox textBoxName;
        private Button buttonFinalizeContest;
        private Button buttonAddSubContest;
        private Button buttonRemoveContestantFromSubContest;
        private Button buttonAddContestantToSubContest;
        private Label labelContestName;
        private Button buttonCancelEdit;
        private Button buttonUpdateSubContest;
        private Label labelSubContestContestants;
        private Label labelContestContestants;
        private ListView listViewContestContestants;
        private ListView listViewSubContestConstestants;
        private ColumnHeader columnSubContestContestantFirstName;
        private ColumnHeader columnSubContestContestantLastName;
        private ListView listViewSubContests;
        private ColumnHeader columnSubContest;
        private ColumnHeader columnContestContestantFirstName;
        private ColumnHeader columnContestContestantLastName;
        private Button buttonRemoveSubContest;
        private Label labelSubContestName;
        #endregion

        #region Delegates

        public event DelegateAddContestantToSubContest EventAddContestantToSubContest;
        public event DelegateRemoveContestantFromSubContest EventRemoveContestantFromSubContest;
        public event DelegateAddSubContest EventAddSubContest;
        public event DelegateFinalizeContest EventFinalizeContest;
        public event DelegateSubContestSelected EventSubContestSelected;
        public event DelegateUpdateSubContest EventUpdateSubContest;
        public event DelegateCancelEdit EventCancelEdit;
        public event DelegateRemoveSubContest EventRemoveSubContest;
        #endregion

        #region Properties

        public TextBox TextBoxName { get { return textBoxName; } set { textBoxName = value; } }

        public Label LabelContestName { get { return labelContestName; } set { labelContestName = value; } }

        public Button ButtonUpdateSubContest { get { return buttonUpdateSubContest; } set { buttonUpdateSubContest = value; } }

        public Button ButtonCancelEdit { get { return buttonCancelEdit; } set { buttonCancelEdit = value; } }

        public Button ButtonAddSubContest { get { return buttonAddSubContest; } set { buttonAddSubContest = value; } }

        public Button ButtonRemoveSubContest { get { return buttonRemoveSubContest; } set { buttonRemoveSubContest = value; } }

        public ListView ListViewContestContestants { get { return listViewContestContestants; } set { listViewContestContestants = value; } }
        public ListView ListViewSubContestContestants { get { return listViewSubContestConstestants; } set { listViewSubContestConstestants = value; } }
        public ListView ListViewSubContests { get { return listViewSubContests; } set { listViewSubContests = value; } }
        #endregion

        #region Constructor
        public CreateSubContestView()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        private void InitializeComponent()
        {
            this.labelSubContestName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonFinalizeContest = new System.Windows.Forms.Button();
            this.buttonAddSubContest = new System.Windows.Forms.Button();
            this.buttonRemoveContestantFromSubContest = new System.Windows.Forms.Button();
            this.buttonAddContestantToSubContest = new System.Windows.Forms.Button();
            this.labelContestName = new System.Windows.Forms.Label();
            this.buttonUpdateSubContest = new System.Windows.Forms.Button();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.labelContestContestants = new System.Windows.Forms.Label();
            this.labelSubContestContestants = new System.Windows.Forms.Label();
            this.listViewContestContestants = new System.Windows.Forms.ListView();
            this.columnContestContestantFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContestContestantLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSubContests = new System.Windows.Forms.ListView();
            this.columnSubContest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSubContestConstestants = new System.Windows.Forms.ListView();
            this.columnSubContestContestantFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubContestContestantLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemoveSubContest = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttonRemoveSubContest);
            this.mainPanel.Controls.Add(this.listViewSubContestConstestants);
            this.mainPanel.Controls.Add(this.listViewSubContests);
            this.mainPanel.Controls.Add(this.listViewContestContestants);
            this.mainPanel.Controls.Add(this.labelSubContestContestants);
            this.mainPanel.Controls.Add(this.labelContestContestants);
            this.mainPanel.Controls.Add(this.buttonCancelEdit);
            this.mainPanel.Controls.Add(this.buttonUpdateSubContest);
            this.mainPanel.Controls.Add(this.labelContestName);
            this.mainPanel.Controls.Add(this.buttonFinalizeContest);
            this.mainPanel.Controls.Add(this.buttonAddSubContest);
            this.mainPanel.Controls.Add(this.buttonRemoveContestantFromSubContest);
            this.mainPanel.Controls.Add(this.buttonAddContestantToSubContest);
            this.mainPanel.Controls.Add(this.textBoxName);
            this.mainPanel.Controls.Add(this.labelSubContestName);
            // 
            // labelSubContestName
            // 
            this.labelSubContestName.AutoSize = true;
            this.labelSubContestName.Location = new System.Drawing.Point(26, 52);
            this.labelSubContestName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSubContestName.Name = "labelSubContestName";
            this.labelSubContestName.Size = new System.Drawing.Size(85, 13);
            this.labelSubContestName.TabIndex = 0;
            this.labelSubContestName.Text = "Deltävlingsnamn";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(29, 67);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(104, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonFinalizeContest
            // 
            this.buttonFinalizeContest.Location = new System.Drawing.Point(443, 315);
            this.buttonFinalizeContest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFinalizeContest.Name = "buttonFinalizeContest";
            this.buttonFinalizeContest.Size = new System.Drawing.Size(68, 43);
            this.buttonFinalizeContest.TabIndex = 7;
            this.buttonFinalizeContest.Text = "Skapa Tävling";
            this.buttonFinalizeContest.UseVisualStyleBackColor = true;
            this.buttonFinalizeContest.Click += new System.EventHandler(this.ButtonFinalizeContest_Click);
            // 
            // buttonAddSubContest
            // 
            this.buttonAddSubContest.Location = new System.Drawing.Point(187, 10);
            this.buttonAddSubContest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSubContest.Name = "buttonAddSubContest";
            this.buttonAddSubContest.Size = new System.Drawing.Size(125, 23);
            this.buttonAddSubContest.TabIndex = 5;
            this.buttonAddSubContest.Text = "Lägg till deltävling";
            this.buttonAddSubContest.UseVisualStyleBackColor = true;
            this.buttonAddSubContest.Click += new System.EventHandler(this.ButtonAddSubContest_Click);
            // 
            // buttonRemoveContestantFromSubContest
            // 
            this.buttonRemoveContestantFromSubContest.Location = new System.Drawing.Point(158, 298);
            this.buttonRemoveContestantFromSubContest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveContestantFromSubContest.Name = "buttonRemoveContestantFromSubContest";
            this.buttonRemoveContestantFromSubContest.Size = new System.Drawing.Size(154, 29);
            this.buttonRemoveContestantFromSubContest.TabIndex = 4;
            this.buttonRemoveContestantFromSubContest.Text = "Ta bort från deltävling";
            this.buttonRemoveContestantFromSubContest.UseVisualStyleBackColor = true;
            this.buttonRemoveContestantFromSubContest.Click += new System.EventHandler(this.ButtonRemoveContestantFromSubContest_Click);
            // 
            // buttonAddContestantToSubContest
            // 
            this.buttonAddContestantToSubContest.Location = new System.Drawing.Point(158, 265);
            this.buttonAddContestantToSubContest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddContestantToSubContest.Name = "buttonAddContestantToSubContest";
            this.buttonAddContestantToSubContest.Size = new System.Drawing.Size(154, 29);
            this.buttonAddContestantToSubContest.TabIndex = 3;
            this.buttonAddContestantToSubContest.Text = "Lägg till i deltävling";
            this.buttonAddContestantToSubContest.UseVisualStyleBackColor = true;
            this.buttonAddContestantToSubContest.Click += new System.EventHandler(this.ButtonAddContestantToSubContest_Click);
            // 
            // labelContestName
            // 
            this.labelContestName.AutoSize = true;
            this.labelContestName.Location = new System.Drawing.Point(26, 10);
            this.labelContestName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContestName.Name = "labelContestName";
            this.labelContestName.Size = new System.Drawing.Size(0, 13);
            this.labelContestName.TabIndex = 11;
            // 
            // buttonUpdateSubContest
            // 
            this.buttonUpdateSubContest.Location = new System.Drawing.Point(187, 37);
            this.buttonUpdateSubContest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateSubContest.Name = "buttonUpdateSubContest";
            this.buttonUpdateSubContest.Size = new System.Drawing.Size(125, 22);
            this.buttonUpdateSubContest.TabIndex = 9;
            this.buttonUpdateSubContest.Text = "Uppdatera";
            this.buttonUpdateSubContest.UseVisualStyleBackColor = true;
            this.buttonUpdateSubContest.Visible = false;
            this.buttonUpdateSubContest.Click += new System.EventHandler(this.ButtonUpdateSubContest_Click);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Location = new System.Drawing.Point(187, 87);
            this.buttonCancelEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(125, 20);
            this.buttonCancelEdit.TabIndex = 10;
            this.buttonCancelEdit.Text = "Cancel";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Visible = false;
            this.buttonCancelEdit.Click += new System.EventHandler(this.ButtonCancelEdit_Click);
            // 
            // labelContestContestants
            // 
            this.labelContestContestants.AutoSize = true;
            this.labelContestContestants.Location = new System.Drawing.Point(17, 220);
            this.labelContestContestants.Name = "labelContestContestants";
            this.labelContestContestants.Size = new System.Drawing.Size(92, 13);
            this.labelContestContestants.TabIndex = 12;
            this.labelContestContestants.Text = "Deltagare i tävling";
            // 
            // labelSubContestContestants
            // 
            this.labelSubContestContestants.AutoSize = true;
            this.labelSubContestContestants.Location = new System.Drawing.Point(313, 219);
            this.labelSubContestContestants.Name = "labelSubContestContestants";
            this.labelSubContestContestants.Size = new System.Drawing.Size(106, 13);
            this.labelSubContestContestants.TabIndex = 13;
            this.labelSubContestContestants.Text = "Deltagare i deltävling";
            // 
            // listViewContestContestants
            // 
            this.listViewContestContestants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnContestContestantFirstName,
            this.columnContestContestantLastName});
            this.listViewContestContestants.Location = new System.Drawing.Point(19, 237);
            this.listViewContestContestants.Name = "listViewContestContestants";
            this.listViewContestContestants.Size = new System.Drawing.Size(125, 121);
            this.listViewContestContestants.TabIndex = 2;
            this.listViewContestContestants.UseCompatibleStateImageBehavior = false;
            this.listViewContestContestants.View = System.Windows.Forms.View.Details;
            // 
            // columnContestContestantFirstName
            // 
            this.columnContestContestantFirstName.Text = "Förnamn";
            // 
            // columnContestContestantLastName
            // 
            this.columnContestContestantLastName.Text = "Efternamn";
            // 
            // listViewSubContests
            // 
            this.listViewSubContests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubContest});
            this.listViewSubContests.Location = new System.Drawing.Point(317, 10);
            this.listViewSubContests.Name = "listViewSubContests";
            this.listViewSubContests.Size = new System.Drawing.Size(125, 121);
            this.listViewSubContests.TabIndex = 34;
            this.listViewSubContests.UseCompatibleStateImageBehavior = false;
            this.listViewSubContests.View = System.Windows.Forms.View.Details;
            this.listViewSubContests.SelectedIndexChanged += new System.EventHandler(this.ListViewSubContests_SelectedIndexChanged);
            // 
            // columnSubContest
            // 
            this.columnSubContest.Text = "Deltävling";
            this.columnSubContest.Width = 67;
            // 
            // listViewSubContestConstestants
            // 
            this.listViewSubContestConstestants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubContestContestantFirstName,
            this.columnSubContestContestantLastName});
            this.listViewSubContestConstestants.Location = new System.Drawing.Point(317, 237);
            this.listViewSubContestConstestants.Name = "listViewSubContestConstestants";
            this.listViewSubContestConstestants.Size = new System.Drawing.Size(125, 121);
            this.listViewSubContestConstestants.TabIndex = 4;
            this.listViewSubContestConstestants.UseCompatibleStateImageBehavior = false;
            this.listViewSubContestConstestants.View = System.Windows.Forms.View.Details;
            // 
            // columnSubContestContestantFirstName
            // 
            this.columnSubContestContestantFirstName.Text = "Förnamn";
            // 
            // columnSubContestContestantLastName
            // 
            this.columnSubContestContestantLastName.Text = "Efternamn";
            // 
            // buttonRemoveSubContest
            // 
            this.buttonRemoveSubContest.Location = new System.Drawing.Point(187, 63);
            this.buttonRemoveSubContest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveSubContest.Name = "buttonRemoveSubContest";
            this.buttonRemoveSubContest.Size = new System.Drawing.Size(125, 20);
            this.buttonRemoveSubContest.TabIndex = 3;
            this.buttonRemoveSubContest.Text = "Ta bort";
            this.buttonRemoveSubContest.UseVisualStyleBackColor = true;
            this.buttonRemoveSubContest.Visible = false;
            this.buttonRemoveSubContest.Click += new System.EventHandler(this.ButtonRemoveSubContest_Click);
            // 
            // CreateSubContestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateSubContestView";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void ButtonFinalizeContest_Click(object sender, EventArgs e)
        {
            this.EventFinalizeContest?.Invoke();
        }

        private void ButtonAddContestantToSubContest_Click(object sender, EventArgs e)
        {
            this.EventAddContestantToSubContest?.Invoke();
        }

        private void ButtonAddSubContest_Click(object sender, EventArgs e)
        {
            this.EventAddSubContest?.Invoke();
        }

        private void ButtonRemoveContestantFromSubContest_Click(object sender, EventArgs e)
        {
            this.EventRemoveContestantFromSubContest?.Invoke();
        }

        private void ButtonUpdateSubContest_Click(object sender, EventArgs e)
        {
            this.EventUpdateSubContest?.Invoke();
        }

        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            this.EventCancelEdit?.Invoke();
        }

        private void ListViewSubContests_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EventSubContestSelected?.Invoke();
        }

        private void ButtonRemoveSubContest_Click(object sender, EventArgs e)
        {
            this.EventRemoveSubContest?.Invoke();
        }

#endregion
    }
}
