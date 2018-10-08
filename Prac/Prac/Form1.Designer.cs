namespace Prac {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonNet = new System.Windows.Forms.Button();
            this.textAPIKey = new System.Windows.Forms.TextBox();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textCollectionID = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.pictureAddon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAddonID = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelTags = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelMap = new System.Windows.Forms.Label();
            this.textBoxMap = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelExistExe = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonServerDirectory = new System.Windows.Forms.Button();
            this.labelServerDirectory = new System.Windows.Forms.Label();
            this.textServerDirectory = new System.Windows.Forms.TextBox();
            this.dialogServerDirectory = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(10, 10);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(242, 340);
            this.checkedListBox.TabIndex = 1;
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
            // 
            // buttonNet
            // 
            this.buttonNet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNet.Location = new System.Drawing.Point(346, 38);
            this.buttonNet.Name = "buttonNet";
            this.buttonNet.Size = new System.Drawing.Size(75, 23);
            this.buttonNet.TabIndex = 2;
            this.buttonNet.Text = "GetInfo";
            this.buttonNet.UseVisualStyleBackColor = true;
            this.buttonNet.Click += new System.EventHandler(this.buttonNet_Click);
            // 
            // textAPIKey
            // 
            this.textAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAPIKey.Location = new System.Drawing.Point(110, 40);
            this.textAPIKey.Name = "textAPIKey";
            this.textAPIKey.Size = new System.Drawing.Size(230, 19);
            this.textAPIKey.TabIndex = 3;
            // 
            // labelApiKey
            // 
            this.labelApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.Location = new System.Drawing.Point(16, 43);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(88, 12);
            this.labelApiKey.TabIndex = 4;
            this.labelApiKey.Text = "Steam API Key :";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(32, 14);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(72, 12);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "コレクションID :";
            // 
            // textCollectionID
            // 
            this.textCollectionID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCollectionID.Location = new System.Drawing.Point(110, 11);
            this.textCollectionID.Name = "textCollectionID";
            this.textCollectionID.Size = new System.Drawing.Size(230, 19);
            this.textCollectionID.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(346, 9);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(319, 38);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(102, 23);
            this.buttonExport.TabIndex = 12;
            this.buttonExport.Text = "luaファイルを出力";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // pictureAddon
            // 
            this.pictureAddon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureAddon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureAddon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureAddon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAddon.Location = new System.Drawing.Point(6, 108);
            this.pictureAddon.Name = "pictureAddon";
            this.pictureAddon.Size = new System.Drawing.Size(128, 128);
            this.pictureAddon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAddon.TabIndex = 14;
            this.pictureAddon.TabStop = false;
            this.pictureAddon.Click += new System.EventHandler(this.pictureAddon_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.Location = new System.Drawing.Point(140, 102);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(33, 12);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Title";
            // 
            // labelAddonID
            // 
            this.labelAddonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddonID.AutoSize = true;
            this.labelAddonID.Location = new System.Drawing.Point(142, 118);
            this.labelAddonID.Name = "labelAddonID";
            this.labelAddonID.Size = new System.Drawing.Size(16, 12);
            this.labelAddonID.TabIndex = 16;
            this.labelAddonID.Text = "ID";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(141, 134);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(266, 102);
            this.textBoxDescription.TabIndex = 17;
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(290, 115);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(0, 12);
            this.labelAmount.TabIndex = 19;
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.Filter = "GarrysMod|workshop.lua|List(csv)|*.csv";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(258, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 347);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.labelTags);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.buttonNet);
            this.tabPage1.Controls.Add(this.textBoxDescription);
            this.tabPage1.Controls.Add(this.textAPIKey);
            this.tabPage1.Controls.Add(this.labelAddonID);
            this.tabPage1.Controls.Add(this.labelApiKey);
            this.tabPage1.Controls.Add(this.labelTitle);
            this.tabPage1.Controls.Add(this.textCollectionID);
            this.tabPage1.Controls.Add(this.pictureAddon);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 321);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Page1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(110, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(230, 23);
            this.progressBar1.Step = 20;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // labelTags
            // 
            this.labelTags.Location = new System.Drawing.Point(7, 243);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(127, 75);
            this.labelTags.TabIndex = 18;
            this.labelTags.Text = "Tags";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSave);
            this.tabPage2.Controls.Add(this.labelMap);
            this.tabPage2.Controls.Add(this.textBoxMap);
            this.tabPage2.Controls.Add(this.buttonGenerate);
            this.tabPage2.Controls.Add(this.labelExistExe);
            this.tabPage2.Controls.Add(this.buttonRun);
            this.tabPage2.Controls.Add(this.buttonServerDirectory);
            this.tabPage2.Controls.Add(this.labelServerDirectory);
            this.tabPage2.Controls.Add(this.textServerDirectory);
            this.tabPage2.Controls.Add(this.buttonExport);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(427, 321);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Page2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(319, 157);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 23);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "入力状態を保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(74, 72);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(32, 12);
            this.labelMap.TabIndex = 20;
            this.labelMap.Text = "Map :";
            // 
            // textBoxMap
            // 
            this.textBoxMap.Location = new System.Drawing.Point(112, 69);
            this.textBoxMap.Name = "textBoxMap";
            this.textBoxMap.Size = new System.Drawing.Size(201, 19);
            this.textBoxMap.TabIndex = 19;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(319, 67);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(102, 23);
            this.buttonGenerate.TabIndex = 18;
            this.buttonGenerate.Text = "batファイルを生成";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelExistExe
            // 
            this.labelExistExe.AutoSize = true;
            this.labelExistExe.ForeColor = System.Drawing.Color.Crimson;
            this.labelExistExe.Location = new System.Drawing.Point(101, 104);
            this.labelExistExe.Name = "labelExistExe";
            this.labelExistExe.Size = new System.Drawing.Size(212, 12);
            this.labelExistExe.TabIndex = 17;
            this.labelExistExe.Text = "そのディレクトリにはsrcds.exeが存在しません";
            this.labelExistExe.Visible = false;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(319, 99);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(102, 23);
            this.buttonRun.TabIndex = 16;
            this.buttonRun.Text = "start.bat を起動";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonServerDirectory
            // 
            this.buttonServerDirectory.Location = new System.Drawing.Point(397, 9);
            this.buttonServerDirectory.Name = "buttonServerDirectory";
            this.buttonServerDirectory.Size = new System.Drawing.Size(24, 23);
            this.buttonServerDirectory.TabIndex = 15;
            this.buttonServerDirectory.Text = "...";
            this.buttonServerDirectory.UseVisualStyleBackColor = true;
            this.buttonServerDirectory.Click += new System.EventHandler(this.buttonServerDirectory_Click);
            // 
            // labelServerDirectory
            // 
            this.labelServerDirectory.AutoSize = true;
            this.labelServerDirectory.Location = new System.Drawing.Point(6, 14);
            this.labelServerDirectory.Name = "labelServerDirectory";
            this.labelServerDirectory.Size = new System.Drawing.Size(100, 12);
            this.labelServerDirectory.TabIndex = 14;
            this.labelServerDirectory.Text = "サーバーディレクトリ :";
            // 
            // textServerDirectory
            // 
            this.textServerDirectory.Location = new System.Drawing.Point(112, 11);
            this.textServerDirectory.Name = "textServerDirectory";
            this.textServerDirectory.Size = new System.Drawing.Size(279, 19);
            this.textServerDirectory.TabIndex = 13;
            // 
            // dialogServerDirectory
            // 
            this.dialogServerDirectory.Description = "Garry\'s Mod Serverのディレクトリを指定してください";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 367);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.checkedListBox);
            this.MinimumSize = new System.Drawing.Size(721, 406);
            this.Name = "Form1";
            this.Text = "Garry\'s Mod Addon Lister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button buttonNet;
        private System.Windows.Forms.TextBox textAPIKey;
        private System.Windows.Forms.Label labelApiKey;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textCollectionID;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.PictureBox pictureAddon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAddonID;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelServerDirectory;
        private System.Windows.Forms.TextBox textServerDirectory;
        private System.Windows.Forms.Button buttonServerDirectory;
        private System.Windows.Forms.FolderBrowserDialog dialogServerDirectory;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelExistExe;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.TextBox textBoxMap;
        private System.Windows.Forms.Button buttonSave;
    }
}

