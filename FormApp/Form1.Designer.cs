
namespace FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.minBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.agrmtCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.genderGrpBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.genderSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            this.maleRadBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.filenameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clrBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roundCorners = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.femaleRadBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.titleBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.genderGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.titleBar.BorderColor = System.Drawing.Color.White;
            this.titleBar.Controls.Add(this.minBox);
            this.titleBar.Controls.Add(this.closeBox);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(348, 30);
            this.titleBar.TabIndex = 0;
            // 
            // minBox
            // 
            this.minBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBox.Animated = true;
            this.minBox.BackColor = System.Drawing.Color.Transparent;
            this.minBox.BorderRadius = 5;
            this.minBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.minBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minBox.FillColor = System.Drawing.Color.Transparent;
            this.minBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minBox.HoverState.Parent = this.minBox;
            this.minBox.IconColor = System.Drawing.Color.White;
            this.minBox.Location = new System.Drawing.Point(258, 0);
            this.minBox.Name = "minBox";
            this.minBox.ShadowDecoration.Parent = this.minBox;
            this.minBox.Size = new System.Drawing.Size(45, 30);
            this.minBox.TabIndex = 0;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.Animated = true;
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.BorderRadius = 5;
            this.closeBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.closeBox.FillColor = System.Drawing.Color.Transparent;
            this.closeBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBox.HoverState.Parent = this.closeBox;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(303, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.ShadowDecoration.Parent = this.closeBox;
            this.closeBox.Size = new System.Drawing.Size(45, 30);
            this.closeBox.TabIndex = 0;
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.titleBar;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.saveBtn);
            this.mainPanel.Controls.Add(this.agrmtCheckBox);
            this.mainPanel.Controls.Add(this.genderGrpBox);
            this.mainPanel.Controls.Add(this.dateTimePicker);
            this.mainPanel.Controls.Add(this.filenameTxtBox);
            this.mainPanel.Controls.Add(this.lastNameTxtBox);
            this.mainPanel.Controls.Add(this.phoneTxtBox);
            this.mainPanel.Controls.Add(this.usernameTxtBox);
            this.mainPanel.Controls.Add(this.firstNameTxtBox);
            this.mainPanel.Controls.Add(this.loadBtn);
            this.mainPanel.Controls.Add(this.clrBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(0, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(348, 468);
            this.mainPanel.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Animated = true;
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BorderRadius = 14;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.saveBtn.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Location = new System.Drawing.Point(16, 423);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(320, 30);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // agrmtCheckBox
            // 
            this.agrmtCheckBox.Animated = true;
            this.agrmtCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.agrmtCheckBox.CheckedState.BorderRadius = 2;
            this.agrmtCheckBox.CheckedState.BorderThickness = 0;
            this.agrmtCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.agrmtCheckBox.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agrmtCheckBox.Location = new System.Drawing.Point(16, 354);
            this.agrmtCheckBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.agrmtCheckBox.Name = "agrmtCheckBox";
            this.agrmtCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.agrmtCheckBox.Size = new System.Drawing.Size(320, 46);
            this.agrmtCheckBox.TabIndex = 6;
            this.agrmtCheckBox.Text = "I agree to the Form Terms of Service and Privacy Policy";
            this.agrmtCheckBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.agrmtCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.agrmtCheckBox.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.agrmtCheckBox.UncheckedState.BorderRadius = 2;
            this.agrmtCheckBox.UncheckedState.BorderThickness = 1;
            this.agrmtCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.agrmtCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderGrpBox
            // 
            this.genderGrpBox.BorderRadius = 7;
            this.genderGrpBox.Controls.Add(this.genderSeparator);
            this.genderGrpBox.Controls.Add(this.femaleRadBtn);
            this.genderGrpBox.Controls.Add(this.maleRadBtn);
            this.genderGrpBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.genderGrpBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.genderGrpBox.Font = new System.Drawing.Font("SF Pro Text", 9.75F);
            this.genderGrpBox.ForeColor = System.Drawing.Color.Black;
            this.genderGrpBox.Location = new System.Drawing.Point(16, 268);
            this.genderGrpBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.genderGrpBox.Name = "genderGrpBox";
            this.genderGrpBox.ShadowDecoration.Parent = this.genderGrpBox;
            this.genderGrpBox.Size = new System.Drawing.Size(320, 55);
            this.genderGrpBox.TabIndex = 5;
            this.genderGrpBox.Text = "Gender";
            this.genderGrpBox.TextOffset = new System.Drawing.Point(0, -10);
            // 
            // genderSeparator
            // 
            this.genderSeparator.Location = new System.Drawing.Point(145, 0);
            this.genderSeparator.Name = "genderSeparator";
            this.genderSeparator.Size = new System.Drawing.Size(32, 55);
            this.genderSeparator.TabIndex = 1;
            // 
            // maleRadBtn
            // 
            this.maleRadBtn.Animated = true;
            this.maleRadBtn.AutoSize = true;
            this.maleRadBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.maleRadBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.maleRadBtn.CheckedState.BorderThickness = 0;
            this.maleRadBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.maleRadBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.maleRadBtn.CheckedState.InnerOffset = -4;
            this.maleRadBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.maleRadBtn.Font = new System.Drawing.Font("SF Pro Text", 9.75F);
            this.maleRadBtn.Location = new System.Drawing.Point(15, 27);
            this.maleRadBtn.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.maleRadBtn.Name = "maleRadBtn";
            this.maleRadBtn.Size = new System.Drawing.Size(60, 21);
            this.maleRadBtn.TabIndex = 0;
            this.maleRadBtn.TabStop = true;
            this.maleRadBtn.Text = "Male";
            this.maleRadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maleRadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.maleRadBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.maleRadBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.maleRadBtn.UncheckedState.BorderThickness = 2;
            this.maleRadBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.maleRadBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.maleRadBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Animated = true;
            this.dateTimePicker.AutoRoundedCorners = true;
            this.dateTimePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dateTimePicker.BorderRadius = 14;
            this.dateTimePicker.BorderThickness = 1;
            this.dateTimePicker.CheckedState.Parent = this.dateTimePicker;
            this.dateTimePicker.FillColor = System.Drawing.Color.White;
            this.dateTimePicker.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.dateTimePicker.HoverState.FillColor = System.Drawing.Color.White;
            this.dateTimePicker.HoverState.Parent = this.dateTimePicker;
            this.dateTimePicker.Location = new System.Drawing.Point(16, 214);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShadowDecoration.Parent = this.dateTimePicker;
            this.dateTimePicker.Size = new System.Drawing.Size(320, 30);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.dateTimePicker.Value = new System.DateTime(2021, 7, 29, 1, 52, 53, 706);
            // 
            // filenameTxtBox
            // 
            this.filenameTxtBox.Animated = true;
            this.filenameTxtBox.AutoRoundedCorners = true;
            this.filenameTxtBox.BorderRadius = 14;
            this.filenameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filenameTxtBox.DefaultText = "";
            this.filenameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filenameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filenameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filenameTxtBox.DisabledState.Parent = this.filenameTxtBox;
            this.filenameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filenameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.filenameTxtBox.FocusedState.Parent = this.filenameTxtBox;
            this.filenameTxtBox.Font = new System.Drawing.Font("SF Pro Text", 9.75F);
            this.filenameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.filenameTxtBox.HoverState.Parent = this.filenameTxtBox;
            this.filenameTxtBox.Location = new System.Drawing.Point(16, 20);
            this.filenameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filenameTxtBox.Name = "filenameTxtBox";
            this.filenameTxtBox.PasswordChar = '\0';
            this.filenameTxtBox.PlaceholderText = "Filename";
            this.filenameTxtBox.SelectedText = "";
            this.filenameTxtBox.ShadowDecoration.Parent = this.filenameTxtBox;
            this.filenameTxtBox.Size = new System.Drawing.Size(158, 30);
            this.filenameTxtBox.TabIndex = 1;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Animated = true;
            this.lastNameTxtBox.AutoRoundedCorners = true;
            this.lastNameTxtBox.BorderRadius = 14;
            this.lastNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTxtBox.DefaultText = "";
            this.lastNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTxtBox.DisabledState.Parent = this.lastNameTxtBox;
            this.lastNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lastNameTxtBox.FocusedState.Parent = this.lastNameTxtBox;
            this.lastNameTxtBox.Font = new System.Drawing.Font("SF Pro Text", 9.75F);
            this.lastNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.lastNameTxtBox.HoverState.Parent = this.lastNameTxtBox;
            this.lastNameTxtBox.Location = new System.Drawing.Point(179, 68);
            this.lastNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.PasswordChar = '\0';
            this.lastNameTxtBox.PlaceholderText = "Last Name";
            this.lastNameTxtBox.SelectedText = "";
            this.lastNameTxtBox.ShadowDecoration.Parent = this.lastNameTxtBox;
            this.lastNameTxtBox.Size = new System.Drawing.Size(157, 30);
            this.lastNameTxtBox.TabIndex = 1;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Animated = true;
            this.phoneTxtBox.AutoRoundedCorners = true;
            this.phoneTxtBox.BorderRadius = 14;
            this.phoneTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxtBox.DefaultText = "";
            this.phoneTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxtBox.DisabledState.Parent = this.phoneTxtBox;
            this.phoneTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.phoneTxtBox.FocusedState.Parent = this.phoneTxtBox;
            this.phoneTxtBox.Font = new System.Drawing.Font("SF Pro Text", 9.75F);
            this.phoneTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.phoneTxtBox.HoverState.Parent = this.phoneTxtBox;
            this.phoneTxtBox.Location = new System.Drawing.Point(16, 164);
            this.phoneTxtBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.phoneTxtBox.MaxLength = 14;
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.PasswordChar = '\0';
            this.phoneTxtBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.phoneTxtBox.PlaceholderText = "Phone: +994552009999";
            this.phoneTxtBox.SelectedText = "";
            this.phoneTxtBox.ShadowDecoration.Parent = this.phoneTxtBox;
            this.phoneTxtBox.Size = new System.Drawing.Size(320, 30);
            this.phoneTxtBox.TabIndex = 1;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Animated = true;
            this.usernameTxtBox.AutoRoundedCorners = true;
            this.usernameTxtBox.BorderRadius = 14;
            this.usernameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxtBox.DefaultText = "";
            this.usernameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxtBox.DisabledState.Parent = this.usernameTxtBox;
            this.usernameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.usernameTxtBox.FocusedState.Parent = this.usernameTxtBox;
            this.usernameTxtBox.Font = new System.Drawing.Font("SF Pro Text", 9.75F);
            this.usernameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.usernameTxtBox.HoverState.Parent = this.usernameTxtBox;
            this.usernameTxtBox.Location = new System.Drawing.Point(16, 116);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.PasswordChar = '\0';
            this.usernameTxtBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameTxtBox.PlaceholderText = "Username";
            this.usernameTxtBox.SelectedText = "";
            this.usernameTxtBox.ShadowDecoration.Parent = this.usernameTxtBox;
            this.usernameTxtBox.Size = new System.Drawing.Size(320, 30);
            this.usernameTxtBox.TabIndex = 1;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Animated = true;
            this.firstNameTxtBox.AutoRoundedCorners = true;
            this.firstNameTxtBox.BorderRadius = 14;
            this.firstNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTxtBox.DefaultText = "";
            this.firstNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxtBox.DisabledState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.firstNameTxtBox.FocusedState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Font = new System.Drawing.Font("SF Pro Text", 9.75F);
            this.firstNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.firstNameTxtBox.HoverState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Location = new System.Drawing.Point(16, 68);
            this.firstNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.PasswordChar = '\0';
            this.firstNameTxtBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.firstNameTxtBox.PlaceholderText = "First Name";
            this.firstNameTxtBox.SelectedText = "";
            this.firstNameTxtBox.ShadowDecoration.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Size = new System.Drawing.Size(157, 30);
            this.firstNameTxtBox.TabIndex = 1;
            // 
            // loadBtn
            // 
            this.loadBtn.Animated = true;
            this.loadBtn.AutoRoundedCorners = true;
            this.loadBtn.BorderRadius = 14;
            this.loadBtn.CheckedState.Parent = this.loadBtn;
            this.loadBtn.CustomImages.Parent = this.loadBtn;
            this.loadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.loadBtn.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.HoverState.Parent = this.loadBtn;
            this.loadBtn.Location = new System.Drawing.Point(180, 20);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.ShadowDecoration.Parent = this.loadBtn;
            this.loadBtn.Size = new System.Drawing.Size(75, 30);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Animated = true;
            this.clrBtn.AutoRoundedCorners = true;
            this.clrBtn.BorderRadius = 14;
            this.clrBtn.CheckedState.Parent = this.clrBtn;
            this.clrBtn.CustomImages.Parent = this.clrBtn;
            this.clrBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.clrBtn.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold);
            this.clrBtn.ForeColor = System.Drawing.Color.White;
            this.clrBtn.HoverState.Parent = this.clrBtn;
            this.clrBtn.Location = new System.Drawing.Point(261, 20);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.ShadowDecoration.Parent = this.clrBtn;
            this.clrBtn.Size = new System.Drawing.Size(75, 30);
            this.clrBtn.TabIndex = 2;
            this.clrBtn.Text = "Clear";
            this.clrBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // roundCorners
            // 
            this.roundCorners.BorderRadius = 25;
            this.roundCorners.TargetControl = this;
            // 
            // femaleRadBtn
            // 
            this.femaleRadBtn.Animated = true;
            this.femaleRadBtn.AutoSize = true;
            this.femaleRadBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.femaleRadBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.femaleRadBtn.CheckedState.BorderThickness = 0;
            this.femaleRadBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(146)))), ((int)(((byte)(164)))));
            this.femaleRadBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.femaleRadBtn.CheckedState.InnerOffset = -4;
            this.femaleRadBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.femaleRadBtn.Font = new System.Drawing.Font("SF Pro Text", 9.75F);
            this.femaleRadBtn.Location = new System.Drawing.Point(224, 27);
            this.femaleRadBtn.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.femaleRadBtn.Name = "femaleRadBtn";
            this.femaleRadBtn.Size = new System.Drawing.Size(74, 21);
            this.femaleRadBtn.TabIndex = 0;
            this.femaleRadBtn.TabStop = true;
            this.femaleRadBtn.Text = "Female";
            this.femaleRadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.femaleRadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.femaleRadBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.femaleRadBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.femaleRadBtn.UncheckedState.BorderThickness = 2;
            this.femaleRadBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.femaleRadBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.femaleRadBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 498);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titleBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.titleBar.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.genderGrpBox.ResumeLayout(false);
            this.genderGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2ControlBox minBox;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Button clrBtn;
        private Guna.UI2.WinForms.Guna2TextBox filenameTxtBox;
        private Guna.UI2.WinForms.Guna2Button loadBtn;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTxtBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2TextBox phoneTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxtBox;
        private Guna.UI2.WinForms.Guna2GroupBox genderGrpBox;
        private Guna.UI2.WinForms.Guna2RadioButton maleRadBtn;
        private Guna.UI2.WinForms.Guna2RadioButton femaleRadBtn;
        private Guna.UI2.WinForms.Guna2VSeparator genderSeparator;
        private Guna.UI2.WinForms.Guna2CheckBox agrmtCheckBox;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Elipse roundCorners;
    }
}

