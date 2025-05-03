namespace lab07_2
{
    partial class fPlanet
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
            groupBox1 = new GroupBox();
            txtWarpStatus = new ComboBox();
            txtDangerLevel = new TextBox();
            txtFaction = new TextBox();
            txtControl = new TextBox();
            txtType = new TextBox();
            txtName = new TextBox();
            txtUniqueFeauters = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtWarpStatus);
            groupBox1.Controls.Add(txtDangerLevel);
            groupBox1.Controls.Add(txtFaction);
            groupBox1.Controls.Add(txtControl);
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtUniqueFeauters);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Заповнення";
            // 
            // txtWarpStatus
            // 
            txtWarpStatus.FormattingEnabled = true;
            txtWarpStatus.Items.AddRange(new object[] { "Нормальний", "Нестабільний", "Буря" });
            txtWarpStatus.Location = new Point(187, 138);
            txtWarpStatus.Name = "txtWarpStatus";
            txtWarpStatus.Size = new Size(125, 28);
            txtWarpStatus.TabIndex = 14;
            // 
            // txtDangerLevel
            // 
            txtDangerLevel.Location = new Point(187, 238);
            txtDangerLevel.Name = "txtDangerLevel";
            txtDangerLevel.Size = new Size(125, 27);
            txtDangerLevel.TabIndex = 13;
            // 
            // txtFaction
            // 
            txtFaction.Location = new Point(187, 170);
            txtFaction.Name = "txtFaction";
            txtFaction.Size = new Size(125, 27);
            txtFaction.TabIndex = 12;
            // 
            // txtControl
            // 
            txtControl.Location = new Point(187, 101);
            txtControl.Name = "txtControl";
            txtControl.Size = new Size(125, 27);
            txtControl.TabIndex = 10;
            // 
            // txtType
            // 
            txtType.Location = new Point(187, 67);
            txtType.Name = "txtType";
            txtType.Size = new Size(125, 27);
            txtType.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(187, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 8;
            // 
            // txtUniqueFeauters
            // 
            txtUniqueFeauters.Location = new Point(187, 204);
            txtUniqueFeauters.Name = "txtUniqueFeauters";
            txtUniqueFeauters.Size = new Size(125, 27);
            txtUniqueFeauters.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 241);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 6;
            label7.Text = "Рівень небезпеки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 207);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 5;
            label6.Text = "Унікальні властивості\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 173);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Фракція";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 138);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Варп статус";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 104);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 2;
            label3.Text = "Хто контролює";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 70);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Тип";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва планети";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(353, 25);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 29);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(353, 60);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fPlanet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 323);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fPlanet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додати нову планету";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox txtWarpStatus;
        private TextBox txtDangerLevel;
        private TextBox txtFaction;
        private TextBox txtControl;
        private TextBox txtType;
        private TextBox txtName;
        private TextBox txtUniqueFeauters;
        private Button btnOk;
        private Button btnCancel;
    }
}