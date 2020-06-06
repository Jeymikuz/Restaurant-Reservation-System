namespace RestaurantDesktop
{
    partial class EditTables
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewNumberOfChairsTekstBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.EditNumberOfChairsTekstBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DeleteTableBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(327, 61);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Dodaj";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_OnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba miejsc";
            // 
            // NewNumberOfChairsTekstBox
            // 
            this.NewNumberOfChairsTekstBox.Location = new System.Drawing.Point(315, 35);
            this.NewNumberOfChairsTekstBox.Name = "NewNumberOfChairsTekstBox";
            this.NewNumberOfChairsTekstBox.Size = new System.Drawing.Size(100, 20);
            this.NewNumberOfChairsTekstBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nowy Stolik";
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDataGridView.Location = new System.Drawing.Point(12, 12);
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.Size = new System.Drawing.Size(211, 258);
            this.TableDataGridView.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edytuj wybrany stolik";
            // 
            // EditNumberOfChairsTekstBox
            // 
            this.EditNumberOfChairsTekstBox.Location = new System.Drawing.Point(315, 156);
            this.EditNumberOfChairsTekstBox.Name = "EditNumberOfChairsTekstBox";
            this.EditNumberOfChairsTekstBox.Size = new System.Drawing.Size(100, 20);
            this.EditNumberOfChairsTekstBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Liczba miejsc";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(327, 182);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Edytuj";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(374, 256);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Wróć";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DeleteTableBtn
            // 
            this.DeleteTableBtn.Location = new System.Drawing.Point(242, 256);
            this.DeleteTableBtn.Name = "DeleteTableBtn";
            this.DeleteTableBtn.Size = new System.Drawing.Size(96, 23);
            this.DeleteTableBtn.TabIndex = 10;
            this.DeleteTableBtn.Text = "Usun stolik";
            this.DeleteTableBtn.UseVisualStyleBackColor = true;
            this.DeleteTableBtn.Click += new System.EventHandler(this.DeleteTableBtn_Click);
            // 
            // NewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 291);
            this.Controls.Add(this.DeleteTableBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.EditNumberOfChairsTekstBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TableDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewNumberOfChairsTekstBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Name = "NewTable";
            this.Text = "Nowy Stolik";
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewNumberOfChairsTekstBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TableDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EditNumberOfChairsTekstBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button DeleteTableBtn;
    }
}