namespace EDS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labLabel = new System.Windows.Forms.Label();
            this.qError = new System.Windows.Forms.Label();
            this.pError = new System.Windows.Forms.Label();
            this.ErrorsLabel2 = new System.Windows.Forms.Label();
            this.ErrorLabel1 = new System.Windows.Forms.Label();
            this.InputPQLabel = new System.Windows.Forms.Label();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.QLabel = new System.Windows.Forms.Label();
            this.ApplyQAndPButton = new System.Windows.Forms.Button();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.PLabel = new System.Windows.Forms.Label();
            this.StartPrimalTestButton = new System.Windows.Forms.Button();
            this.PrimalTestResultLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.rResultLabel = new System.Windows.Forms.Label();
            this.FResultLabel = new System.Windows.Forms.Label();
            this.rValueLabel = new System.Windows.Forms.Label();
            this.FrValueLabel = new System.Windows.Forms.Label();
            this.CalculatedLabel = new System.Windows.Forms.Label();
            this.InputELabel = new System.Windows.Forms.Label();
            this.eError = new System.Windows.Forms.Label();
            this.ErrorLabel3 = new System.Windows.Forms.Label();
            this.ETextBox = new System.Windows.Forms.TextBox();
            this.ELabel = new System.Windows.Forms.Label();
            this.ApplyEButton = new System.Windows.Forms.Button();
            this.CalculatedDLavel = new System.Windows.Forms.Label();
            this.dValueLabel = new System.Windows.Forms.Label();
            this.dResultLabel = new System.Windows.Forms.Label();
            this.InputHashLabel = new System.Windows.Forms.Label();
            this.InputHashTextBox = new System.Windows.Forms.TextBox();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.GetHashButton = new System.Windows.Forms.Button();
            this.EDSValueLabel = new System.Windows.Forms.Label();
            this.EDSlabel = new System.Windows.Forms.Label();
            this.GetEDSButton = new System.Windows.Forms.Button();
            this.MessageHashCodeValueLabel = new System.Windows.Forms.Label();
            this.MessageHashCodeLabel = new System.Windows.Forms.Label();
            this.EDSPathTextBox = new System.Windows.Forms.TextBox();
            this.EDSPathLabel = new System.Windows.Forms.Label();
            this.ChooseEDSButton = new System.Windows.Forms.Button();
            this.SaveEDSButton = new System.Windows.Forms.Button();
            this.WorkingModeLabel = new System.Windows.Forms.Label();
            this.CheckingEDSModeButton = new System.Windows.Forms.Button();
            this.MakingEDSModeButton = new System.Windows.Forms.Button();
            this.GetSenderHashButton = new System.Windows.Forms.Button();
            this.ChooseSenderFileButton = new System.Windows.Forms.Button();
            this.CheckEDSButton = new System.Windows.Forms.Button();
            this.OpenKeyLabel = new System.Windows.Forms.Label();
            this.rSenderError = new System.Windows.Forms.Label();
            this.eSenderError = new System.Windows.Forms.Label();
            this.ErrorLabel5 = new System.Windows.Forms.Label();
            this.ErrorLabel4 = new System.Windows.Forms.Label();
            this.rSenderTextBox = new System.Windows.Forms.TextBox();
            this.r2Label = new System.Windows.Forms.Label();
            this.eSenderTextBox = new System.Windows.Forms.TextBox();
            this.e2Label = new System.Windows.Forms.Label();
            this.SubmitSenderButton = new System.Windows.Forms.Button();
            this.ChooseExistingEDSButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Font = new System.Drawing.Font("TechnicBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labLabel.Location = new System.Drawing.Point(260, 9);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(442, 32);
            this.labLabel.TabIndex = 0;
            this.labLabel.Text = "Electronic Digital Signature";
            // 
            // qError
            // 
            this.qError.AutoSize = true;
            this.qError.Location = new System.Drawing.Point(137, 205);
            this.qError.Name = "qError";
            this.qError.Size = new System.Drawing.Size(48, 20);
            this.qError.TabIndex = 36;
            this.qError.Text = "None.";
            // 
            // pError
            // 
            this.pError.AutoSize = true;
            this.pError.Location = new System.Drawing.Point(137, 140);
            this.pError.Name = "pError";
            this.pError.Size = new System.Drawing.Size(48, 20);
            this.pError.TabIndex = 35;
            this.pError.Text = "None.";
            // 
            // ErrorsLabel2
            // 
            this.ErrorsLabel2.AutoSize = true;
            this.ErrorsLabel2.Location = new System.Drawing.Point(90, 205);
            this.ErrorsLabel2.Name = "ErrorsLabel2";
            this.ErrorsLabel2.Size = new System.Drawing.Size(50, 20);
            this.ErrorsLabel2.TabIndex = 34;
            this.ErrorsLabel2.Text = "Errors:";
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel1.Location = new System.Drawing.Point(90, 141);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(50, 20);
            this.ErrorLabel1.TabIndex = 33;
            this.ErrorLabel1.Text = "Errors:";
            // 
            // InputPQLabel
            // 
            this.InputPQLabel.AutoSize = true;
            this.InputPQLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputPQLabel.Location = new System.Drawing.Point(117, 95);
            this.InputPQLabel.Name = "InputPQLabel";
            this.InputPQLabel.Size = new System.Drawing.Size(156, 31);
            this.InputPQLabel.TabIndex = 32;
            this.InputPQLabel.Text = "Input p And q";
            // 
            // QTextBox
            // 
            this.QTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QTextBox.Location = new System.Drawing.Point(90, 227);
            this.QTextBox.Multiline = true;
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(206, 36);
            this.QTextBox.TabIndex = 31;
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QLabel.Location = new System.Drawing.Point(22, 220);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(73, 41);
            this.QLabel.TabIndex = 30;
            this.QLabel.Text = "q = ";
            // 
            // ApplyQAndPButton
            // 
            this.ApplyQAndPButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ApplyQAndPButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApplyQAndPButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ApplyQAndPButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApplyQAndPButton.Location = new System.Drawing.Point(90, 279);
            this.ApplyQAndPButton.Name = "ApplyQAndPButton";
            this.ApplyQAndPButton.Size = new System.Drawing.Size(206, 36);
            this.ApplyQAndPButton.TabIndex = 29;
            this.ApplyQAndPButton.Text = "Apply";
            this.ApplyQAndPButton.UseVisualStyleBackColor = false;
            this.ApplyQAndPButton.Click += new System.EventHandler(this.ApplyQAndPButton_Click);
            // 
            // PTextBox
            // 
            this.PTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PTextBox.Location = new System.Drawing.Point(90, 163);
            this.PTextBox.Multiline = true;
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(206, 36);
            this.PTextBox.TabIndex = 28;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PLabel.Location = new System.Drawing.Point(21, 158);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(73, 41);
            this.PLabel.TabIndex = 27;
            this.PLabel.Text = "p = ";
            // 
            // StartPrimalTestButton
            // 
            this.StartPrimalTestButton.BackColor = System.Drawing.Color.Plum;
            this.StartPrimalTestButton.Enabled = false;
            this.StartPrimalTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartPrimalTestButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartPrimalTestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartPrimalTestButton.Location = new System.Drawing.Point(90, 321);
            this.StartPrimalTestButton.Name = "StartPrimalTestButton";
            this.StartPrimalTestButton.Size = new System.Drawing.Size(206, 36);
            this.StartPrimalTestButton.TabIndex = 37;
            this.StartPrimalTestButton.Text = "Start Primal Test";
            this.StartPrimalTestButton.UseVisualStyleBackColor = false;
            this.StartPrimalTestButton.Click += new System.EventHandler(this.StartPrimalTestButton_Click);
            // 
            // PrimalTestResultLabel
            // 
            this.PrimalTestResultLabel.AutoSize = true;
            this.PrimalTestResultLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrimalTestResultLabel.Location = new System.Drawing.Point(21, 419);
            this.PrimalTestResultLabel.Name = "PrimalTestResultLabel";
            this.PrimalTestResultLabel.Size = new System.Drawing.Size(74, 31);
            this.PrimalTestResultLabel.TabIndex = 39;
            this.PrimalTestResultLabel.Text = "None.";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(21, 388);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(198, 31);
            this.ResultLabel.TabIndex = 38;
            this.ResultLabel.Text = "Primal Test Result:";
            // 
            // rResultLabel
            // 
            this.rResultLabel.AutoSize = true;
            this.rResultLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rResultLabel.Location = new System.Drawing.Point(328, 133);
            this.rResultLabel.Name = "rResultLabel";
            this.rResultLabel.Size = new System.Drawing.Size(57, 41);
            this.rResultLabel.TabIndex = 40;
            this.rResultLabel.Text = "r =";
            // 
            // FResultLabel
            // 
            this.FResultLabel.AutoSize = true;
            this.FResultLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FResultLabel.Location = new System.Drawing.Point(328, 197);
            this.FResultLabel.Name = "FResultLabel";
            this.FResultLabel.Size = new System.Drawing.Size(97, 41);
            this.FResultLabel.TabIndex = 41;
            this.FResultLabel.Text = "Ф(r) =";
            // 
            // rValueLabel
            // 
            this.rValueLabel.AutoSize = true;
            this.rValueLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rValueLabel.Location = new System.Drawing.Point(378, 141);
            this.rValueLabel.Name = "rValueLabel";
            this.rValueLabel.Size = new System.Drawing.Size(74, 31);
            this.rValueLabel.TabIndex = 42;
            this.rValueLabel.Text = "None.";
            // 
            // FrValueLabel
            // 
            this.FrValueLabel.AutoSize = true;
            this.FrValueLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrValueLabel.Location = new System.Drawing.Point(414, 205);
            this.FrValueLabel.Name = "FrValueLabel";
            this.FrValueLabel.Size = new System.Drawing.Size(74, 31);
            this.FrValueLabel.TabIndex = 43;
            this.FrValueLabel.Text = "None.";
            // 
            // CalculatedLabel
            // 
            this.CalculatedLabel.AutoSize = true;
            this.CalculatedLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculatedLabel.Location = new System.Drawing.Point(326, 95);
            this.CalculatedLabel.Name = "CalculatedLabel";
            this.CalculatedLabel.Size = new System.Drawing.Size(226, 31);
            this.CalculatedLabel.TabIndex = 44;
            this.CalculatedLabel.Text = "Calculated r and Ф(r)";
            // 
            // InputELabel
            // 
            this.InputELabel.AutoSize = true;
            this.InputELabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputELabel.Location = new System.Drawing.Point(150, 477);
            this.InputELabel.Name = "InputELabel";
            this.InputELabel.Size = new System.Drawing.Size(88, 31);
            this.InputELabel.TabIndex = 45;
            this.InputELabel.Text = "Input d";
            // 
            // eError
            // 
            this.eError.AutoSize = true;
            this.eError.Location = new System.Drawing.Point(133, 517);
            this.eError.Name = "eError";
            this.eError.Size = new System.Drawing.Size(48, 20);
            this.eError.TabIndex = 49;
            this.eError.Text = "None.";
            // 
            // ErrorLabel3
            // 
            this.ErrorLabel3.AutoSize = true;
            this.ErrorLabel3.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel3.Location = new System.Drawing.Point(86, 518);
            this.ErrorLabel3.Name = "ErrorLabel3";
            this.ErrorLabel3.Size = new System.Drawing.Size(50, 20);
            this.ErrorLabel3.TabIndex = 48;
            this.ErrorLabel3.Text = "Errors:";
            // 
            // ETextBox
            // 
            this.ETextBox.Enabled = false;
            this.ETextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ETextBox.Location = new System.Drawing.Point(86, 540);
            this.ETextBox.Multiline = true;
            this.ETextBox.Name = "ETextBox";
            this.ETextBox.Size = new System.Drawing.Size(206, 36);
            this.ETextBox.TabIndex = 47;
            // 
            // ELabel
            // 
            this.ELabel.AutoSize = true;
            this.ELabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ELabel.Location = new System.Drawing.Point(17, 535);
            this.ELabel.Name = "ELabel";
            this.ELabel.Size = new System.Drawing.Size(73, 41);
            this.ELabel.TabIndex = 46;
            this.ELabel.Text = "d = ";
            // 
            // ApplyEButton
            // 
            this.ApplyEButton.BackColor = System.Drawing.Color.Aquamarine;
            this.ApplyEButton.Enabled = false;
            this.ApplyEButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApplyEButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ApplyEButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApplyEButton.Location = new System.Drawing.Point(86, 587);
            this.ApplyEButton.Name = "ApplyEButton";
            this.ApplyEButton.Size = new System.Drawing.Size(206, 36);
            this.ApplyEButton.TabIndex = 50;
            this.ApplyEButton.Text = "Apply";
            this.ApplyEButton.UseVisualStyleBackColor = false;
            this.ApplyEButton.Click += new System.EventHandler(this.ApplyEButton_Click);
            // 
            // CalculatedDLavel
            // 
            this.CalculatedDLavel.AutoSize = true;
            this.CalculatedDLavel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculatedDLavel.Location = new System.Drawing.Point(365, 269);
            this.CalculatedDLavel.Name = "CalculatedDLavel";
            this.CalculatedDLavel.Size = new System.Drawing.Size(140, 31);
            this.CalculatedDLavel.TabIndex = 53;
            this.CalculatedDLavel.Text = "Calculated e";
            // 
            // dValueLabel
            // 
            this.dValueLabel.AutoSize = true;
            this.dValueLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dValueLabel.Location = new System.Drawing.Point(388, 321);
            this.dValueLabel.Name = "dValueLabel";
            this.dValueLabel.Size = new System.Drawing.Size(74, 31);
            this.dValueLabel.TabIndex = 52;
            this.dValueLabel.Text = "None.";
            // 
            // dResultLabel
            // 
            this.dResultLabel.AutoSize = true;
            this.dResultLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dResultLabel.Location = new System.Drawing.Point(329, 313);
            this.dResultLabel.Name = "dResultLabel";
            this.dResultLabel.Size = new System.Drawing.Size(63, 41);
            this.dResultLabel.TabIndex = 51;
            this.dResultLabel.Text = "e =";
            // 
            // InputHashLabel
            // 
            this.InputHashLabel.AutoSize = true;
            this.InputHashLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputHashLabel.Location = new System.Drawing.Point(429, 376);
            this.InputHashLabel.Name = "InputHashLabel";
            this.InputHashLabel.Size = new System.Drawing.Size(194, 31);
            this.InputHashLabel.TabIndex = 55;
            this.InputHashLabel.Text = "Input Hash Codes";
            this.InputHashLabel.Click += new System.EventHandler(this.InputFileLabel_Click);
            // 
            // InputHashTextBox
            // 
            this.InputHashTextBox.Location = new System.Drawing.Point(333, 415);
            this.InputHashTextBox.Multiline = true;
            this.InputHashTextBox.Name = "InputHashTextBox";
            this.InputHashTextBox.ReadOnly = true;
            this.InputHashTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputHashTextBox.Size = new System.Drawing.Size(369, 352);
            this.InputHashTextBox.TabIndex = 54;
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Enabled = false;
            this.FilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilePathTextBox.Location = new System.Drawing.Point(712, 414);
            this.FilePathTextBox.Multiline = true;
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(385, 36);
            this.FilePathTextBox.TabIndex = 58;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChooseFileButton.Enabled = false;
            this.ChooseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseFileButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseFileButton.Location = new System.Drawing.Point(712, 461);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(190, 36);
            this.ChooseFileButton.TabIndex = 57;
            this.ChooseFileButton.Text = "Choose File";
            this.ChooseFileButton.UseVisualStyleBackColor = false;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilePathLabel.Location = new System.Drawing.Point(834, 370);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(136, 41);
            this.FilePathLabel.TabIndex = 56;
            this.FilePathLabel.Text = "File Path:";
            // 
            // GetHashButton
            // 
            this.GetHashButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GetHashButton.Enabled = false;
            this.GetHashButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetHashButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetHashButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetHashButton.Location = new System.Drawing.Point(712, 506);
            this.GetHashButton.Name = "GetHashButton";
            this.GetHashButton.Size = new System.Drawing.Size(190, 36);
            this.GetHashButton.TabIndex = 59;
            this.GetHashButton.Text = "Get Hash Codes";
            this.GetHashButton.UseVisualStyleBackColor = false;
            this.GetHashButton.Click += new System.EventHandler(this.GetHashButton_Click);
            // 
            // EDSValueLabel
            // 
            this.EDSValueLabel.AutoSize = true;
            this.EDSValueLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EDSValueLabel.Location = new System.Drawing.Point(425, 828);
            this.EDSValueLabel.Name = "EDSValueLabel";
            this.EDSValueLabel.Size = new System.Drawing.Size(74, 31);
            this.EDSValueLabel.TabIndex = 61;
            this.EDSValueLabel.Text = "None.";
            // 
            // EDSlabel
            // 
            this.EDSlabel.AutoSize = true;
            this.EDSlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EDSlabel.Location = new System.Drawing.Point(329, 820);
            this.EDSlabel.Name = "EDSlabel";
            this.EDSlabel.Size = new System.Drawing.Size(99, 41);
            this.EDSlabel.TabIndex = 60;
            this.EDSlabel.Text = "EDS =";
            // 
            // GetEDSButton
            // 
            this.GetEDSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GetEDSButton.Enabled = false;
            this.GetEDSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetEDSButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetEDSButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetEDSButton.Location = new System.Drawing.Point(712, 550);
            this.GetEDSButton.Name = "GetEDSButton";
            this.GetEDSButton.Size = new System.Drawing.Size(190, 36);
            this.GetEDSButton.TabIndex = 62;
            this.GetEDSButton.Text = "Get EDS";
            this.GetEDSButton.UseVisualStyleBackColor = false;
            this.GetEDSButton.Click += new System.EventHandler(this.GetEDSButton_Click);
            // 
            // MessageHashCodeValueLabel
            // 
            this.MessageHashCodeValueLabel.AutoSize = true;
            this.MessageHashCodeValueLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageHashCodeValueLabel.Location = new System.Drawing.Point(566, 788);
            this.MessageHashCodeValueLabel.Name = "MessageHashCodeValueLabel";
            this.MessageHashCodeValueLabel.Size = new System.Drawing.Size(74, 31);
            this.MessageHashCodeValueLabel.TabIndex = 64;
            this.MessageHashCodeValueLabel.Text = "None.";
            // 
            // MessageHashCodeLabel
            // 
            this.MessageHashCodeLabel.AutoSize = true;
            this.MessageHashCodeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageHashCodeLabel.Location = new System.Drawing.Point(333, 788);
            this.MessageHashCodeLabel.Name = "MessageHashCodeLabel";
            this.MessageHashCodeLabel.Size = new System.Drawing.Size(238, 30);
            this.MessageHashCodeLabel.TabIndex = 63;
            this.MessageHashCodeLabel.Text = "Message Hash Code = ";
            // 
            // EDSPathTextBox
            // 
            this.EDSPathTextBox.Enabled = false;
            this.EDSPathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EDSPathTextBox.Location = new System.Drawing.Point(712, 640);
            this.EDSPathTextBox.Multiline = true;
            this.EDSPathTextBox.Name = "EDSPathTextBox";
            this.EDSPathTextBox.Size = new System.Drawing.Size(385, 36);
            this.EDSPathTextBox.TabIndex = 65;
            // 
            // EDSPathLabel
            // 
            this.EDSPathLabel.AutoSize = true;
            this.EDSPathLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EDSPathLabel.Location = new System.Drawing.Point(812, 596);
            this.EDSPathLabel.Name = "EDSPathLabel";
            this.EDSPathLabel.Size = new System.Drawing.Size(196, 41);
            this.EDSPathLabel.TabIndex = 66;
            this.EDSPathLabel.Text = "EDS File Path:";
            // 
            // ChooseEDSButton
            // 
            this.ChooseEDSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChooseEDSButton.Enabled = false;
            this.ChooseEDSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseEDSButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseEDSButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseEDSButton.Location = new System.Drawing.Point(712, 684);
            this.ChooseEDSButton.Name = "ChooseEDSButton";
            this.ChooseEDSButton.Size = new System.Drawing.Size(190, 36);
            this.ChooseEDSButton.TabIndex = 67;
            this.ChooseEDSButton.Text = "Choose Empty EDS";
            this.ChooseEDSButton.UseVisualStyleBackColor = false;
            this.ChooseEDSButton.Click += new System.EventHandler(this.ChooseEDSButton_Click);
            // 
            // SaveEDSButton
            // 
            this.SaveEDSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaveEDSButton.Enabled = false;
            this.SaveEDSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveEDSButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveEDSButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveEDSButton.Location = new System.Drawing.Point(712, 731);
            this.SaveEDSButton.Name = "SaveEDSButton";
            this.SaveEDSButton.Size = new System.Drawing.Size(190, 36);
            this.SaveEDSButton.TabIndex = 68;
            this.SaveEDSButton.Text = "Save EDS";
            this.SaveEDSButton.UseVisualStyleBackColor = false;
            this.SaveEDSButton.Click += new System.EventHandler(this.SaveEDSButton_Click);
            // 
            // WorkingModeLabel
            // 
            this.WorkingModeLabel.AutoSize = true;
            this.WorkingModeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkingModeLabel.Location = new System.Drawing.Point(56, 670);
            this.WorkingModeLabel.Name = "WorkingModeLabel";
            this.WorkingModeLabel.Size = new System.Drawing.Size(180, 31);
            this.WorkingModeLabel.TabIndex = 69;
            this.WorkingModeLabel.Text = "Working Modes:";
            // 
            // CheckingEDSModeButton
            // 
            this.CheckingEDSModeButton.BackColor = System.Drawing.Color.Wheat;
            this.CheckingEDSModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckingEDSModeButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckingEDSModeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckingEDSModeButton.Location = new System.Drawing.Point(45, 755);
            this.CheckingEDSModeButton.Name = "CheckingEDSModeButton";
            this.CheckingEDSModeButton.Size = new System.Drawing.Size(206, 36);
            this.CheckingEDSModeButton.TabIndex = 71;
            this.CheckingEDSModeButton.Text = "Check EDS";
            this.CheckingEDSModeButton.UseVisualStyleBackColor = false;
            this.CheckingEDSModeButton.Click += new System.EventHandler(this.CheckingEDSModeButton_Click);
            // 
            // MakingEDSModeButton
            // 
            this.MakingEDSModeButton.BackColor = System.Drawing.Color.Thistle;
            this.MakingEDSModeButton.Enabled = false;
            this.MakingEDSModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MakingEDSModeButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MakingEDSModeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MakingEDSModeButton.Location = new System.Drawing.Point(45, 713);
            this.MakingEDSModeButton.Name = "MakingEDSModeButton";
            this.MakingEDSModeButton.Size = new System.Drawing.Size(206, 36);
            this.MakingEDSModeButton.TabIndex = 70;
            this.MakingEDSModeButton.Text = "Make EDS";
            this.MakingEDSModeButton.UseVisualStyleBackColor = false;
            this.MakingEDSModeButton.Click += new System.EventHandler(this.MakingEDSModeButton_Click);
            // 
            // GetSenderHashButton
            // 
            this.GetSenderHashButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GetSenderHashButton.Enabled = false;
            this.GetSenderHashButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetSenderHashButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetSenderHashButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetSenderHashButton.Location = new System.Drawing.Point(908, 506);
            this.GetSenderHashButton.Name = "GetSenderHashButton";
            this.GetSenderHashButton.Size = new System.Drawing.Size(189, 36);
            this.GetSenderHashButton.TabIndex = 73;
            this.GetSenderHashButton.Text = "Get Hash Codes";
            this.GetSenderHashButton.UseVisualStyleBackColor = false;
            this.GetSenderHashButton.Click += new System.EventHandler(this.GetSenderHashButton_Click);
            // 
            // ChooseSenderFileButton
            // 
            this.ChooseSenderFileButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ChooseSenderFileButton.Enabled = false;
            this.ChooseSenderFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseSenderFileButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseSenderFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseSenderFileButton.Location = new System.Drawing.Point(908, 461);
            this.ChooseSenderFileButton.Name = "ChooseSenderFileButton";
            this.ChooseSenderFileButton.Size = new System.Drawing.Size(189, 36);
            this.ChooseSenderFileButton.TabIndex = 72;
            this.ChooseSenderFileButton.Text = "Choose Sender File";
            this.ChooseSenderFileButton.UseVisualStyleBackColor = false;
            this.ChooseSenderFileButton.Click += new System.EventHandler(this.ChooseSenderFileButton_Click);
            // 
            // CheckEDSButton
            // 
            this.CheckEDSButton.BackColor = System.Drawing.Color.Yellow;
            this.CheckEDSButton.Enabled = false;
            this.CheckEDSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckEDSButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckEDSButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckEDSButton.Location = new System.Drawing.Point(908, 550);
            this.CheckEDSButton.Name = "CheckEDSButton";
            this.CheckEDSButton.Size = new System.Drawing.Size(190, 36);
            this.CheckEDSButton.TabIndex = 74;
            this.CheckEDSButton.Text = "Check EDS";
            this.CheckEDSButton.UseVisualStyleBackColor = false;
            this.CheckEDSButton.Click += new System.EventHandler(this.CheckEDSButton_Click);
            // 
            // OpenKeyLabel
            // 
            this.OpenKeyLabel.AutoSize = true;
            this.OpenKeyLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenKeyLabel.Location = new System.Drawing.Point(1217, 388);
            this.OpenKeyLabel.Name = "OpenKeyLabel";
            this.OpenKeyLabel.Size = new System.Drawing.Size(172, 31);
            this.OpenKeyLabel.TabIndex = 75;
            this.OpenKeyLabel.Text = "Open Key Input";
            // 
            // rSenderError
            // 
            this.rSenderError.AutoSize = true;
            this.rSenderError.Location = new System.Drawing.Point(1243, 488);
            this.rSenderError.Name = "rSenderError";
            this.rSenderError.Size = new System.Drawing.Size(48, 20);
            this.rSenderError.TabIndex = 83;
            this.rSenderError.Text = "None.";
            // 
            // eSenderError
            // 
            this.eSenderError.AutoSize = true;
            this.eSenderError.Location = new System.Drawing.Point(1243, 423);
            this.eSenderError.Name = "eSenderError";
            this.eSenderError.Size = new System.Drawing.Size(48, 20);
            this.eSenderError.TabIndex = 82;
            this.eSenderError.Text = "None.";
            // 
            // ErrorLabel5
            // 
            this.ErrorLabel5.AutoSize = true;
            this.ErrorLabel5.Location = new System.Drawing.Point(1196, 488);
            this.ErrorLabel5.Name = "ErrorLabel5";
            this.ErrorLabel5.Size = new System.Drawing.Size(50, 20);
            this.ErrorLabel5.TabIndex = 81;
            this.ErrorLabel5.Text = "Errors:";
            // 
            // ErrorLabel4
            // 
            this.ErrorLabel4.AutoSize = true;
            this.ErrorLabel4.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel4.Location = new System.Drawing.Point(1196, 424);
            this.ErrorLabel4.Name = "ErrorLabel4";
            this.ErrorLabel4.Size = new System.Drawing.Size(50, 20);
            this.ErrorLabel4.TabIndex = 80;
            this.ErrorLabel4.Text = "Errors:";
            // 
            // rSenderTextBox
            // 
            this.rSenderTextBox.Enabled = false;
            this.rSenderTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rSenderTextBox.Location = new System.Drawing.Point(1196, 510);
            this.rSenderTextBox.Multiline = true;
            this.rSenderTextBox.Name = "rSenderTextBox";
            this.rSenderTextBox.Size = new System.Drawing.Size(206, 36);
            this.rSenderTextBox.TabIndex = 79;
            // 
            // r2Label
            // 
            this.r2Label.AutoSize = true;
            this.r2Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.r2Label.Location = new System.Drawing.Point(1128, 503);
            this.r2Label.Name = "r2Label";
            this.r2Label.Size = new System.Drawing.Size(65, 41);
            this.r2Label.TabIndex = 78;
            this.r2Label.Text = "r = ";
            // 
            // eSenderTextBox
            // 
            this.eSenderTextBox.Enabled = false;
            this.eSenderTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eSenderTextBox.Location = new System.Drawing.Point(1196, 446);
            this.eSenderTextBox.Multiline = true;
            this.eSenderTextBox.Name = "eSenderTextBox";
            this.eSenderTextBox.Size = new System.Drawing.Size(206, 36);
            this.eSenderTextBox.TabIndex = 77;
            // 
            // e2Label
            // 
            this.e2Label.AutoSize = true;
            this.e2Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.e2Label.Location = new System.Drawing.Point(1127, 441);
            this.e2Label.Name = "e2Label";
            this.e2Label.Size = new System.Drawing.Size(71, 41);
            this.e2Label.TabIndex = 76;
            this.e2Label.Text = "e = ";
            // 
            // SubmitSenderButton
            // 
            this.SubmitSenderButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitSenderButton.Enabled = false;
            this.SubmitSenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitSenderButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitSenderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitSenderButton.Location = new System.Drawing.Point(1233, 554);
            this.SubmitSenderButton.Name = "SubmitSenderButton";
            this.SubmitSenderButton.Size = new System.Drawing.Size(138, 36);
            this.SubmitSenderButton.TabIndex = 84;
            this.SubmitSenderButton.Text = "Submit";
            this.SubmitSenderButton.UseVisualStyleBackColor = false;
            this.SubmitSenderButton.Click += new System.EventHandler(this.SubmitSenderButton_Click);
            // 
            // ChooseExistingEDSButton
            // 
            this.ChooseExistingEDSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ChooseExistingEDSButton.Enabled = false;
            this.ChooseExistingEDSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseExistingEDSButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseExistingEDSButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseExistingEDSButton.Location = new System.Drawing.Point(908, 693);
            this.ChooseExistingEDSButton.Name = "ChooseExistingEDSButton";
            this.ChooseExistingEDSButton.Size = new System.Drawing.Size(190, 65);
            this.ChooseExistingEDSButton.TabIndex = 85;
            this.ChooseExistingEDSButton.Text = "Choose Existing EDS";
            this.ChooseExistingEDSButton.UseVisualStyleBackColor = false;
            this.ChooseExistingEDSButton.Click += new System.EventHandler(this.ChooseExistingEDSButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 900);
            this.Controls.Add(this.ChooseExistingEDSButton);
            this.Controls.Add(this.SubmitSenderButton);
            this.Controls.Add(this.rSenderError);
            this.Controls.Add(this.eSenderError);
            this.Controls.Add(this.ErrorLabel5);
            this.Controls.Add(this.ErrorLabel4);
            this.Controls.Add(this.rSenderTextBox);
            this.Controls.Add(this.r2Label);
            this.Controls.Add(this.eSenderTextBox);
            this.Controls.Add(this.e2Label);
            this.Controls.Add(this.OpenKeyLabel);
            this.Controls.Add(this.CheckEDSButton);
            this.Controls.Add(this.GetSenderHashButton);
            this.Controls.Add(this.ChooseSenderFileButton);
            this.Controls.Add(this.CheckingEDSModeButton);
            this.Controls.Add(this.MakingEDSModeButton);
            this.Controls.Add(this.WorkingModeLabel);
            this.Controls.Add(this.SaveEDSButton);
            this.Controls.Add(this.ChooseEDSButton);
            this.Controls.Add(this.EDSPathLabel);
            this.Controls.Add(this.EDSPathTextBox);
            this.Controls.Add(this.MessageHashCodeValueLabel);
            this.Controls.Add(this.MessageHashCodeLabel);
            this.Controls.Add(this.GetEDSButton);
            this.Controls.Add(this.EDSValueLabel);
            this.Controls.Add(this.EDSlabel);
            this.Controls.Add(this.GetHashButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.InputHashLabel);
            this.Controls.Add(this.InputHashTextBox);
            this.Controls.Add(this.CalculatedDLavel);
            this.Controls.Add(this.dValueLabel);
            this.Controls.Add(this.dResultLabel);
            this.Controls.Add(this.ApplyEButton);
            this.Controls.Add(this.eError);
            this.Controls.Add(this.ErrorLabel3);
            this.Controls.Add(this.ETextBox);
            this.Controls.Add(this.ELabel);
            this.Controls.Add(this.InputELabel);
            this.Controls.Add(this.CalculatedLabel);
            this.Controls.Add(this.FrValueLabel);
            this.Controls.Add(this.rValueLabel);
            this.Controls.Add(this.FResultLabel);
            this.Controls.Add(this.rResultLabel);
            this.Controls.Add(this.PrimalTestResultLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.StartPrimalTestButton);
            this.Controls.Add(this.qError);
            this.Controls.Add(this.pError);
            this.Controls.Add(this.ErrorsLabel2);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.InputPQLabel);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.ApplyQAndPButton);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.labLabel);
            this.Name = "Form1";
            this.Text = "Электронная Цифровая Подпись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labLabel;
        private Label qError;
        private Label pError;
        private Label ErrorsLabel2;
        private Label ErrorLabel1;
        private Label InputPQLabel;
        private TextBox QTextBox;
        private Label QLabel;
        private Button ApplyQAndPButton;
        private TextBox PTextBox;
        private Label PLabel;
        private Button StartPrimalTestButton;
        private Label PrimalTestResultLabel;
        private Label ResultLabel;
        private Label rResultLabel;
        private Label FResultLabel;
        private Label rValueLabel;
        private Label FrValueLabel;
        private Label CalculatedLabel;
        private Label InputELabel;
        private Label eError;
        private Label ErrorLabel3;
        private TextBox ETextBox;
        private Label ELabel;
        private Button ApplyEButton;
        private Label CalculatedDLavel;
        private Label dValueLabel;
        private Label dResultLabel;
        private Label InputHashLabel;
        private TextBox InputHashTextBox;
        private TextBox FilePathTextBox;
        private Button ChooseFileButton;
        private Label FilePathLabel;
        private Button GetHashButton;
        private Label EDSValueLabel;
        private Label EDSlabel;
        private Button GetEDSButton;
        private Label MessageHashCodeValueLabel;
        private Label MessageHashCodeLabel;
        private TextBox EDSPathTextBox;
        private Label EDSPathLabel;
        private Button ChooseEDSButton;
        private Button SaveEDSButton;
        private Label WorkingModeLabel;
        private Button CheckingEDSModeButton;
        private Button MakingEDSModeButton;
        private Button GetSenderHashButton;
        private Button ChooseSenderFileButton;
        private Button CheckEDSButton;
        private Label OpenKeyLabel;
        private Label rSenderError;
        private Label eSenderError;
        private Label ErrorLabel5;
        private Label ErrorLabel4;
        private TextBox rSenderTextBox;
        private Label r2Label;
        private TextBox eSenderTextBox;
        private Label e2Label;
        private Button SubmitSenderButton;
        private Button ChooseExistingEDSButton;
    }
}