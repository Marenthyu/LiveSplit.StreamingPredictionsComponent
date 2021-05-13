namespace LiveSplit.UI.Components
{
    partial class StreamingPredictionsSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOAuthToken = new System.Windows.Forms.TextBox();
            this.getTokenBtn = new System.Windows.Forms.Button();
            this.cancelOnResetCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yesOptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.noOptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.predictionTitleTextBox = new System.Windows.Forms.TextBox();
            this.createOnSplitNameTextBox = new System.Windows.Forms.TextBox();
            this.loclSplitNameTextBox = new System.Windows.Forms.TextBox();
            this.lockOnSplitCheckBox = new System.Windows.Forms.CheckBox();
            this.lockTimeInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resolveSplitNameTextBox = new System.Windows.Forms.TextBox();
            this.ResolveTimeInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.createOnSplitRadio = new System.Windows.Forms.RadioButton();
            this.createOnStartRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resolveOnBadSplitsRadio = new System.Windows.Forms.RadioButton();
            this.resolveOnGoodSplitsRadio = new System.Windows.Forms.RadioButton();
            this.resolveOnGoldRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resolveOnAmountSplitNameTextBox = new System.Windows.Forms.TextBox();
            this.resolveOnAmountSplitRadio = new System.Windows.Forms.RadioButton();
            this.resolveOnAmountEndOfRunRadio = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.resolveAmountInput = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resolveOnSplitReachedRadio = new System.Windows.Forms.RadioButton();
            this.resolveOnEndReachedRadio = new System.Windows.Forms.RadioButton();
            this.resolveOnEndTimedRadio = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.resolveEndTimeInput = new System.Windows.Forms.NumericUpDown();
            this.doNotResolveRadioButton = new System.Windows.Forms.RadioButton();
            this.resolveOnSplitTimedRadio = new System.Windows.Forms.RadioButton();
            this.resolveOnSplitRadio = new System.Windows.Forms.RadioButton();
            this.resolveOnPBRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize) (this.lockTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ResolveTimeInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.resolveAmountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.resolveEndTimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OAuth Token:";
            // 
            // txtOAuthToken
            // 
            this.txtOAuthToken.Location = new System.Drawing.Point(115, 4);
            this.txtOAuthToken.Name = "txtOAuthToken";
            this.txtOAuthToken.PasswordChar = '*';
            this.txtOAuthToken.Size = new System.Drawing.Size(233, 20);
            this.txtOAuthToken.TabIndex = 3;
            // 
            // getTokenBtn
            // 
            this.getTokenBtn.Location = new System.Drawing.Point(354, 2);
            this.getTokenBtn.Name = "getTokenBtn";
            this.getTokenBtn.Size = new System.Drawing.Size(95, 23);
            this.getTokenBtn.TabIndex = 4;
            this.getTokenBtn.Text = "Get New Token";
            this.getTokenBtn.UseVisualStyleBackColor = true;
            this.getTokenBtn.Click += new System.EventHandler(this.getTokenBtn_Click);
            // 
            // cancelOnResetCheckBox
            // 
            this.cancelOnResetCheckBox.Location = new System.Drawing.Point(10, 315);
            this.cancelOnResetCheckBox.Name = "cancelOnResetCheckBox";
            this.cancelOnResetCheckBox.Size = new System.Drawing.Size(439, 21);
            this.cancelOnResetCheckBox.TabIndex = 5;
            this.cancelOnResetCheckBox.Text = "Cancel Prediction on Reset (instead of resolving as \"No\") (This will refund point" + "s)";
            this.cancelOnResetCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOTE: This can only resolve Predictions it created!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "\"Yes\" Option Name:";
            // 
            // yesOptionTextBox
            // 
            this.yesOptionTextBox.Location = new System.Drawing.Point(115, 30);
            this.yesOptionTextBox.MaxLength = 25;
            this.yesOptionTextBox.Name = "yesOptionTextBox";
            this.yesOptionTextBox.Size = new System.Drawing.Size(233, 20);
            this.yesOptionTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "\"No\" Option Name:";
            // 
            // noOptionTextBox
            // 
            this.noOptionTextBox.Location = new System.Drawing.Point(115, 56);
            this.noOptionTextBox.MaxLength = 25;
            this.noOptionTextBox.Name = "noOptionTextBox";
            this.noOptionTextBox.Size = new System.Drawing.Size(233, 20);
            this.noOptionTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prediction Title:";
            // 
            // predictionTitleTextBox
            // 
            this.predictionTitleTextBox.Location = new System.Drawing.Point(115, 82);
            this.predictionTitleTextBox.MaxLength = 45;
            this.predictionTitleTextBox.Name = "predictionTitleTextBox";
            this.predictionTitleTextBox.Size = new System.Drawing.Size(233, 20);
            this.predictionTitleTextBox.TabIndex = 14;
            // 
            // createOnSplitNameTextBox
            // 
            this.createOnSplitNameTextBox.Location = new System.Drawing.Point(105, 48);
            this.createOnSplitNameTextBox.Name = "createOnSplitNameTextBox";
            this.createOnSplitNameTextBox.Size = new System.Drawing.Size(328, 20);
            this.createOnSplitNameTextBox.TabIndex = 16;
            // 
            // loclSplitNameTextBox
            // 
            this.loclSplitNameTextBox.Location = new System.Drawing.Point(10, 289);
            this.loclSplitNameTextBox.Name = "loclSplitNameTextBox";
            this.loclSplitNameTextBox.Size = new System.Drawing.Size(433, 20);
            this.loclSplitNameTextBox.TabIndex = 18;
            // 
            // lockOnSplitCheckBox
            // 
            this.lockOnSplitCheckBox.Location = new System.Drawing.Point(10, 259);
            this.lockOnSplitCheckBox.Name = "lockOnSplitCheckBox";
            this.lockOnSplitCheckBox.Size = new System.Drawing.Size(413, 24);
            this.lockOnSplitCheckBox.TabIndex = 17;
            this.lockOnSplitCheckBox.Text = "Lock Prediction when the following text is in the name of the current Split:";
            this.lockOnSplitCheckBox.UseVisualStyleBackColor = true;
            // 
            // lockTimeInput
            // 
            this.lockTimeInput.Location = new System.Drawing.Point(115, 108);
            this.lockTimeInput.Maximum = new decimal(new int[] {1800, 0, 0, 0});
            this.lockTimeInput.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.lockTimeInput.Name = "lockTimeInput";
            this.lockTimeInput.Size = new System.Drawing.Size(180, 20);
            this.lockTimeInput.TabIndex = 19;
            this.lockTimeInput.Value = new decimal(new int[] {600, 0, 0, 0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Prediction Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "seconds";
            // 
            // resolveSplitNameTextBox
            // 
            this.resolveSplitNameTextBox.Location = new System.Drawing.Point(77, 94);
            this.resolveSplitNameTextBox.Name = "resolveSplitNameTextBox";
            this.resolveSplitNameTextBox.Size = new System.Drawing.Size(356, 20);
            this.resolveSplitNameTextBox.TabIndex = 23;
            // 
            // ResolveTimeInput
            // 
            this.ResolveTimeInput.Location = new System.Drawing.Point(129, 170);
            this.ResolveTimeInput.Maximum = new decimal(new int[] {3686400, 0, 0, 0});
            this.ResolveTimeInput.Minimum = new decimal(new int[] {100000, 0, 0, -2147483648});
            this.ResolveTimeInput.Name = "ResolveTimeInput";
            this.ResolveTimeInput.Size = new System.Drawing.Size(56, 20);
            this.ResolveTimeInput.TabIndex = 26;
            this.ResolveTimeInput.Value = new decimal(new int[] {60, 0, 0, 0});
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(191, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "seconds on the Timer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.createOnSplitRadio);
            this.groupBox1.Controls.Add(this.createOnStartRadio);
            this.groupBox1.Controls.Add(this.createOnSplitNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 103);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Prediction when";
            // 
            // radioButton3
            // 
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 73);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(206, 24);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Do not automatically start a Prediction";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // createOnSplitRadio
            // 
            this.createOnSplitRadio.Location = new System.Drawing.Point(8, 47);
            this.createOnSplitRadio.Name = "createOnSplitRadio";
            this.createOnSplitRadio.Size = new System.Drawing.Size(95, 20);
            this.createOnSplitRadio.TabIndex = 17;
            this.createOnSplitRadio.Text = "this Split starts:";
            this.createOnSplitRadio.UseVisualStyleBackColor = true;
            // 
            // createOnStartRadio
            // 
            this.createOnStartRadio.Location = new System.Drawing.Point(8, 17);
            this.createOnStartRadio.Name = "createOnStartRadio";
            this.createOnStartRadio.Size = new System.Drawing.Size(104, 24);
            this.createOnStartRadio.TabIndex = 0;
            this.createOnStartRadio.Text = "the Timer starts";
            this.createOnStartRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resolveOnBadSplitsRadio);
            this.groupBox2.Controls.Add(this.resolveOnGoodSplitsRadio);
            this.groupBox2.Controls.Add(this.resolveOnGoldRadio);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.resolveAmountInput);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.resolveOnSplitReachedRadio);
            this.groupBox2.Controls.Add(this.resolveOnEndReachedRadio);
            this.groupBox2.Controls.Add(this.resolveOnEndTimedRadio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.resolveEndTimeInput);
            this.groupBox2.Controls.Add(this.doNotResolveRadioButton);
            this.groupBox2.Controls.Add(this.resolveOnSplitTimedRadio);
            this.groupBox2.Controls.Add(this.resolveOnSplitRadio);
            this.groupBox2.Controls.Add(this.resolveOnPBRadio);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.resolveSplitNameTextBox);
            this.groupBox2.Controls.Add(this.ResolveTimeInput);
            this.groupBox2.Location = new System.Drawing.Point(10, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 439);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resolve Prediction when";
            // 
            // resolveOnBadSplitsRadio
            // 
            this.resolveOnBadSplitsRadio.Location = new System.Drawing.Point(6, 285);
            this.resolveOnBadSplitsRadio.Name = "resolveOnBadSplitsRadio";
            this.resolveOnBadSplitsRadio.Size = new System.Drawing.Size(150, 24);
            this.resolveOnBadSplitsRadio.TabIndex = 45;
            this.resolveOnBadSplitsRadio.TabStop = true;
            this.resolveOnBadSplitsRadio.Text = "Splits lost Time";
            this.resolveOnBadSplitsRadio.UseVisualStyleBackColor = true;
            // 
            // resolveOnGoodSplitsRadio
            // 
            this.resolveOnGoodSplitsRadio.Location = new System.Drawing.Point(6, 255);
            this.resolveOnGoodSplitsRadio.Name = "resolveOnGoodSplitsRadio";
            this.resolveOnGoodSplitsRadio.Size = new System.Drawing.Size(150, 24);
            this.resolveOnGoodSplitsRadio.TabIndex = 44;
            this.resolveOnGoodSplitsRadio.TabStop = true;
            this.resolveOnGoodSplitsRadio.Text = "Splits saved Time";
            this.resolveOnGoodSplitsRadio.UseVisualStyleBackColor = true;
            // 
            // resolveOnGoldRadio
            // 
            this.resolveOnGoldRadio.Location = new System.Drawing.Point(6, 225);
            this.resolveOnGoldRadio.Name = "resolveOnGoldRadio";
            this.resolveOnGoldRadio.Size = new System.Drawing.Size(191, 24);
            this.resolveOnGoldRadio.TabIndex = 43;
            this.resolveOnGoldRadio.TabStop = true;
            this.resolveOnGoldRadio.Text = "Best Splits were achieved (or tied)";
            this.resolveOnGoldRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resolveOnAmountSplitNameTextBox);
            this.groupBox3.Controls.Add(this.resolveOnAmountSplitRadio);
            this.groupBox3.Controls.Add(this.resolveOnAmountEndOfRunRadio);
            this.groupBox3.Location = new System.Drawing.Point(6, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 87);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "by";
            // 
            // resolveOnAmountSplitNameTextBox
            // 
            this.resolveOnAmountSplitNameTextBox.Location = new System.Drawing.Point(123, 52);
            this.resolveOnAmountSplitNameTextBox.Name = "resolveOnAmountSplitNameTextBox";
            this.resolveOnAmountSplitNameTextBox.Size = new System.Drawing.Size(294, 20);
            this.resolveOnAmountSplitNameTextBox.TabIndex = 43;
            // 
            // resolveOnAmountSplitRadio
            // 
            this.resolveOnAmountSplitRadio.Location = new System.Drawing.Point(6, 49);
            this.resolveOnAmountSplitRadio.Name = "resolveOnAmountSplitRadio";
            this.resolveOnAmountSplitRadio.Size = new System.Drawing.Size(123, 24);
            this.resolveOnAmountSplitRadio.TabIndex = 1;
            this.resolveOnAmountSplitRadio.Text = "the start of this Split:";
            this.resolveOnAmountSplitRadio.UseVisualStyleBackColor = true;
            // 
            // resolveOnAmountEndOfRunRadio
            // 
            this.resolveOnAmountEndOfRunRadio.Checked = true;
            this.resolveOnAmountEndOfRunRadio.Location = new System.Drawing.Point(6, 19);
            this.resolveOnAmountEndOfRunRadio.Name = "resolveOnAmountEndOfRunRadio";
            this.resolveOnAmountEndOfRunRadio.Size = new System.Drawing.Size(123, 24);
            this.resolveOnAmountEndOfRunRadio.TabIndex = 0;
            this.resolveOnAmountEndOfRunRadio.TabStop = true;
            this.resolveOnAmountEndOfRunRadio.Text = "the end of the Run";
            this.resolveOnAmountEndOfRunRadio.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(0, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(439, 2);
            this.label14.TabIndex = 41;
            this.label14.Text = "label14";
            // 
            // resolveAmountInput
            // 
            this.resolveAmountInput.Location = new System.Drawing.Point(116, 199);
            this.resolveAmountInput.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.resolveAmountInput.Name = "resolveAmountInput";
            this.resolveAmountInput.Size = new System.Drawing.Size(317, 20);
            this.resolveAmountInput.TabIndex = 40;
            this.resolveAmountInput.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 18);
            this.label13.TabIndex = 39;
            this.label13.Text = "... at least this many:";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(439, 2);
            this.label12.TabIndex = 37;
            this.label12.Text = "label12";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(0, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(439, 2);
            this.label10.TabIndex = 36;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "... this Split:";
            // 
            // resolveOnSplitReachedRadio
            // 
            this.resolveOnSplitReachedRadio.Location = new System.Drawing.Point(6, 118);
            this.resolveOnSplitReachedRadio.Name = "resolveOnSplitReachedRadio";
            this.resolveOnSplitReachedRadio.Size = new System.Drawing.Size(129, 20);
            this.resolveOnSplitReachedRadio.TabIndex = 34;
            this.resolveOnSplitReachedRadio.Text = "starts";
            this.resolveOnSplitReachedRadio.UseVisualStyleBackColor = true;
            // 
            // resolveOnEndReachedRadio
            // 
            this.resolveOnEndReachedRadio.Location = new System.Drawing.Point(6, 40);
            this.resolveOnEndReachedRadio.Name = "resolveOnEndReachedRadio";
            this.resolveOnEndReachedRadio.Size = new System.Drawing.Size(104, 20);
            this.resolveOnEndReachedRadio.TabIndex = 33;
            this.resolveOnEndReachedRadio.TabStop = true;
            this.resolveOnEndReachedRadio.Text = "the Run finishes";
            this.resolveOnEndReachedRadio.UseVisualStyleBackColor = true;
            // 
            // resolveOnEndTimedRadio
            // 
            this.resolveOnEndTimedRadio.Location = new System.Drawing.Point(6, 66);
            this.resolveOnEndTimedRadio.Name = "resolveOnEndTimedRadio";
            this.resolveOnEndTimedRadio.Size = new System.Drawing.Size(168, 20);
            this.resolveOnEndTimedRadio.TabIndex = 30;
            this.resolveOnEndTimedRadio.Text = "the Run finishes with less than";
            this.resolveOnEndTimedRadio.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(242, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 18);
            this.label11.TabIndex = 32;
            this.label11.Text = "seconds on the Timer";
            // 
            // resolveEndTimeInput
            // 
            this.resolveEndTimeInput.Location = new System.Drawing.Point(180, 66);
            this.resolveEndTimeInput.Maximum = new decimal(new int[] {3686400, 0, 0, 0});
            this.resolveEndTimeInput.Minimum = new decimal(new int[] {100000, 0, 0, -2147483648});
            this.resolveEndTimeInput.Name = "resolveEndTimeInput";
            this.resolveEndTimeInput.Size = new System.Drawing.Size(56, 20);
            this.resolveEndTimeInput.TabIndex = 31;
            this.resolveEndTimeInput.Value = new decimal(new int[] {60, 0, 0, 0});
            // 
            // doNotResolveRadioButton
            // 
            this.doNotResolveRadioButton.Checked = true;
            this.doNotResolveRadioButton.Location = new System.Drawing.Point(8, 410);
            this.doNotResolveRadioButton.Name = "doNotResolveRadioButton";
            this.doNotResolveRadioButton.Size = new System.Drawing.Size(229, 24);
            this.doNotResolveRadioButton.TabIndex = 29;
            this.doNotResolveRadioButton.TabStop = true;
            this.doNotResolveRadioButton.Text = "Do not automatically resolve the Prediction";
            this.doNotResolveRadioButton.UseVisualStyleBackColor = true;
            // 
            // resolveOnSplitTimedRadio
            // 
            this.resolveOnSplitTimedRadio.Location = new System.Drawing.Point(6, 170);
            this.resolveOnSplitTimedRadio.Name = "resolveOnSplitTimedRadio";
            this.resolveOnSplitTimedRadio.Size = new System.Drawing.Size(117, 20);
            this.resolveOnSplitTimedRadio.TabIndex = 24;
            this.resolveOnSplitTimedRadio.Text = "starts with less than";
            this.resolveOnSplitTimedRadio.UseVisualStyleBackColor = true;
            // 
            // resolveOnSplitRadio
            // 
            this.resolveOnSplitRadio.Location = new System.Drawing.Point(6, 144);
            this.resolveOnSplitRadio.Name = "resolveOnSplitRadio";
            this.resolveOnSplitRadio.Size = new System.Drawing.Size(129, 20);
            this.resolveOnSplitRadio.TabIndex = 1;
            this.resolveOnSplitRadio.Text = "starts ahead";
            this.resolveOnSplitRadio.UseVisualStyleBackColor = true;
            // 
            // resolveOnPBRadio
            // 
            this.resolveOnPBRadio.Location = new System.Drawing.Point(6, 14);
            this.resolveOnPBRadio.Name = "resolveOnPBRadio";
            this.resolveOnPBRadio.Size = new System.Drawing.Size(107, 20);
            this.resolveOnPBRadio.TabIndex = 0;
            this.resolveOnPBRadio.Text = "the Run PB\'s";
            this.resolveOnPBRadio.UseVisualStyleBackColor = true;
            // 
            // StreamingPredictionsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lockTimeInput);
            this.Controls.Add(this.loclSplitNameTextBox);
            this.Controls.Add(this.lockOnSplitCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.predictionTitleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noOptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yesOptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelOnResetCheckBox);
            this.Controls.Add(this.getTokenBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOAuthToken);
            this.Name = "StreamingPredictionsSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(457, 785);
            ((System.ComponentModel.ISupportInitialize) (this.lockTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ResolveTimeInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.resolveAmountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.resolveEndTimeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox resolveOnAmountSplitNameTextBox;
        private System.Windows.Forms.RadioButton resolveOnGoldRadio;
        private System.Windows.Forms.RadioButton resolveOnGoodSplitsRadio;
        private System.Windows.Forms.RadioButton resolveOnBadSplitsRadio;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton resolveOnAmountEndOfRunRadio;
        private System.Windows.Forms.RadioButton resolveOnAmountSplitRadio;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown resolveAmountInput;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.RadioButton resolveOnEndReachedRadio;
        private System.Windows.Forms.RadioButton resolveOnSplitReachedRadio;

        private System.Windows.Forms.RadioButton resolveOnEndTimedRadio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown resolveEndTimeInput;

        private System.Windows.Forms.RadioButton doNotResolveRadioButton;

        private System.Windows.Forms.RadioButton resolveOnSplitTimedRadio;

        private System.Windows.Forms.RadioButton resolveOnSplitRadio;

        private System.Windows.Forms.RadioButton resolveOnPBRadio;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.RadioButton radioButton3;

        private System.Windows.Forms.RadioButton createOnSplitRadio;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton createOnStartRadio;

        private System.Windows.Forms.NumericUpDown ResolveTimeInput;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox resolveSplitNameTextBox;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.NumericUpDown lockTimeInput;

        private System.Windows.Forms.TextBox loclSplitNameTextBox;
        private System.Windows.Forms.CheckBox lockOnSplitCheckBox;

        private System.Windows.Forms.TextBox createOnSplitNameTextBox;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox predictionTitleTextBox;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox noOptionTextBox;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yesOptionTextBox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.CheckBox cancelOnResetCheckBox;

        private System.Windows.Forms.Button getTokenBtn;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOAuthToken;

        #endregion
    }
}
