
namespace WinformsButtonCalculator
{
    partial class Calculator
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
            this.btnZero = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnDivided = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.labelHistory = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCalculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOnlyCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZero
            // 
            this.btnZero.AutoSize = true;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZero.Location = new System.Drawing.Point(58, 200);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(35, 35);
            this.btnZero.TabIndex = 21;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxResult.Location = new System.Drawing.Point(17, 43);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(211, 29);
            this.textBoxResult.TabIndex = 20;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDot
            // 
            this.btnDot.AutoSize = true;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDot.Location = new System.Drawing.Point(99, 200);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(35, 35);
            this.btnDot.TabIndex = 39;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.AutoSize = true;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEquals.Location = new System.Drawing.Point(180, 159);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(48, 76);
            this.btnEquals.TabIndex = 40;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnCount
            // 
            this.btnCount.AutoSize = true;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCount.Location = new System.Drawing.Point(139, 200);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(35, 35);
            this.btnCount.TabIndex = 41;
            this.btnCount.Text = "+";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.operator_click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.AutoSize = true;
            this.btnSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSubstring.Location = new System.Drawing.Point(139, 159);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(35, 35);
            this.btnSubstring.TabIndex = 47;
            this.btnSubstring.Text = "-";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.operator_click);
            // 
            // btnThree
            // 
            this.btnThree.AutoSize = true;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnThree.Location = new System.Drawing.Point(99, 159);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(35, 35);
            this.btnThree.TabIndex = 45;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.AutoSize = true;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTwo.Location = new System.Drawing.Point(58, 159);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(35, 35);
            this.btnTwo.TabIndex = 44;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnOne
            // 
            this.btnOne.AutoSize = true;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOne.Location = new System.Drawing.Point(17, 159);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(35, 35);
            this.btnOne.TabIndex = 43;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.button_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.AutoSize = true;
            this.btnMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMultiple.Location = new System.Drawing.Point(139, 118);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(35, 35);
            this.btnMultiple.TabIndex = 53;
            this.btnMultiple.Text = "X";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.operator_click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Location = new System.Drawing.Point(180, 118);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(48, 35);
            this.btnRemove.TabIndex = 52;
            this.btnRemove.Text = "C";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSix
            // 
            this.btnSix.AutoSize = true;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSix.Location = new System.Drawing.Point(99, 118);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(35, 35);
            this.btnSix.TabIndex = 51;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFive
            // 
            this.btnFive.AutoSize = true;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFive.Location = new System.Drawing.Point(58, 118);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(35, 35);
            this.btnFive.TabIndex = 50;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFour
            // 
            this.btnFour.AutoSize = true;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFour.Location = new System.Drawing.Point(17, 118);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(35, 35);
            this.btnFour.TabIndex = 49;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.button_Click);
            // 
            // btnDivided
            // 
            this.btnDivided.AutoSize = true;
            this.btnDivided.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDivided.Location = new System.Drawing.Point(139, 77);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(35, 35);
            this.btnDivided.TabIndex = 59;
            this.btnDivided.Text = "÷";
            this.btnDivided.UseVisualStyleBackColor = true;
            this.btnDivided.Click += new System.EventHandler(this.operator_click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.AutoSize = true;
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveAll.Location = new System.Drawing.Point(180, 77);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(48, 35);
            this.btnRemoveAll.TabIndex = 58;
            this.btnRemoveAll.Text = "CE";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnNine
            // 
            this.btnNine.AutoSize = true;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNine.Location = new System.Drawing.Point(99, 77);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(35, 35);
            this.btnNine.TabIndex = 57;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEight
            // 
            this.btnEight.AutoSize = true;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEight.Location = new System.Drawing.Point(58, 77);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(35, 35);
            this.btnEight.TabIndex = 56;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.AutoSize = true;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeven.Location = new System.Drawing.Point(17, 77);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(35, 35);
            this.btnSeven.TabIndex = 55;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCurrentOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCurrentOperation.Location = new System.Drawing.Point(188, 16);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 16);
            this.labelCurrentOperation.TabIndex = 60;
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.AutoSize = true;
            this.buttonBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackSpace.Location = new System.Drawing.Point(17, 197);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(35, 35);
            this.buttonBackSpace.TabIndex = 62;
            this.buttonBackSpace.Text = "◄";
            this.buttonBackSpace.UseVisualStyleBackColor = true;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.AutoSize = true;
            this.buttonClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearHistory.Location = new System.Drawing.Point(253, 199);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(154, 36);
            this.buttonClearHistory.TabIndex = 63;
            this.buttonClearHistory.Text = "Clear";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxResult.Location = new System.Drawing.Point(253, 43);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(153, 151);
            this.richTextBoxResult.TabIndex = 64;
            this.richTextBoxResult.Text = "";
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHistory.Location = new System.Drawing.Point(255, 16);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(104, 24);
            this.labelHistory.TabIndex = 65;
            this.labelHistory.Text = "No history";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCalculationsToolStripMenuItem,
            this.showOnlyCalculatorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewCalculationsToolStripMenuItem
            // 
            this.viewCalculationsToolStripMenuItem.Name = "viewCalculationsToolStripMenuItem";
            this.viewCalculationsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewCalculationsToolStripMenuItem.Text = "View calculations";
            this.viewCalculationsToolStripMenuItem.Click += new System.EventHandler(this.viewCalculationsToolStripMenuItem_Click);
            // 
            // showOnlyCalculatorToolStripMenuItem
            // 
            this.showOnlyCalculatorToolStripMenuItem.Name = "showOnlyCalculatorToolStripMenuItem";
            this.showOnlyCalculatorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showOnlyCalculatorToolStripMenuItem.Text = "Show only calculator";
            this.showOnlyCalculatorToolStripMenuItem.Click += new System.EventHandler(this.showOnlyCalculatorToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 251);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.buttonBackSpace);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.btnDivided);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnDivided;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCalculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOnlyCalculatorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

