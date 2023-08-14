namespace ProjetoCriptografiaAssimetrico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.buttonEncryptFile = new System.Windows.Forms.Button();
            this.buttonDecryptFile = new System.Windows.Forms.Button();
            this.buttonCreateAsmKeys = new System.Windows.Forms.Button();
            this.buttonExportPublicKey = new System.Windows.Forms.Button();
            this.buttonImportPublicKey = new System.Windows.Forms.Button();
            this.buttonGetPrivateKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._encryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._decryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonEncryptFile
            // 
            this.buttonEncryptFile.Location = new System.Drawing.Point(62, 47);
            this.buttonEncryptFile.Name = "buttonEncryptFile";
            this.buttonEncryptFile.Size = new System.Drawing.Size(155, 26);
            this.buttonEncryptFile.TabIndex = 0;
            this.buttonEncryptFile.Text = "Criptografar o arquivo";
            this.buttonEncryptFile.UseVisualStyleBackColor = true;
            this.buttonEncryptFile.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // buttonDecryptFile
            // 
            this.buttonDecryptFile.Location = new System.Drawing.Point(276, 47);
            this.buttonDecryptFile.Name = "buttonDecryptFile";
            this.buttonDecryptFile.Size = new System.Drawing.Size(171, 26);
            this.buttonDecryptFile.TabIndex = 1;
            this.buttonDecryptFile.Text = "Descriptografar Arquivo";
            this.buttonDecryptFile.UseVisualStyleBackColor = true;
            this.buttonDecryptFile.Click += new System.EventHandler(this.buttonDecryptFile_Click);
            // 
            // buttonCreateAsmKeys
            // 
            this.buttonCreateAsmKeys.Location = new System.Drawing.Point(34, 115);
            this.buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            this.buttonCreateAsmKeys.Size = new System.Drawing.Size(98, 26);
            this.buttonCreateAsmKeys.TabIndex = 2;
            this.buttonCreateAsmKeys.Text = "Criar chaves";
            this.buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            this.buttonCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // buttonExportPublicKey
            // 
            this.buttonExportPublicKey.Location = new System.Drawing.Point(138, 115);
            this.buttonExportPublicKey.Name = "buttonExportPublicKey";
            this.buttonExportPublicKey.Size = new System.Drawing.Size(160, 26);
            this.buttonExportPublicKey.TabIndex = 3;
            this.buttonExportPublicKey.Text = "Exportar Chave Pública";
            this.buttonExportPublicKey.UseVisualStyleBackColor = true;
            this.buttonExportPublicKey.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // buttonImportPublicKey
            // 
            this.buttonImportPublicKey.Location = new System.Drawing.Point(304, 115);
            this.buttonImportPublicKey.Name = "buttonImportPublicKey";
            this.buttonImportPublicKey.Size = new System.Drawing.Size(155, 26);
            this.buttonImportPublicKey.TabIndex = 4;
            this.buttonImportPublicKey.Text = "Importar chave pública";
            this.buttonImportPublicKey.UseVisualStyleBackColor = true;
            this.buttonImportPublicKey.Click += new System.EventHandler(this.buttonImportPublicKey_Click);
            // 
            // buttonGetPrivateKey
            // 
            this.buttonGetPrivateKey.Location = new System.Drawing.Point(161, 175);
            this.buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            this.buttonGetPrivateKey.Size = new System.Drawing.Size(155, 26);
            this.buttonGetPrivateKey.TabIndex = 5;
            this.buttonGetPrivateKey.Text = "Obter chave privada";
            this.buttonGetPrivateKey.UseVisualStyleBackColor = true;
            this.buttonGetPrivateKey.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chave não definida";
            // 
            // _encryptOpenFileDialog
            // 
            this._encryptOpenFileDialog.FileName = "_encryptOpenFileDialog";
            // 
            // _decryptOpenFileDialog
            // 
            this._decryptOpenFileDialog.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetPrivateKey);
            this.Controls.Add(this.buttonImportPublicKey);
            this.Controls.Add(this.buttonExportPublicKey);
            this.Controls.Add(this.buttonCreateAsmKeys);
            this.Controls.Add(this.buttonDecryptFile);
            this.Controls.Add(this.buttonEncryptFile);
            this.Name = "Form1";
            this.Text = "CriptografandoDados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncryptFile;
        private System.Windows.Forms.Button buttonDecryptFile;
        private System.Windows.Forms.Button buttonCreateAsmKeys;
        private System.Windows.Forms.Button buttonExportPublicKey;
        private System.Windows.Forms.Button buttonImportPublicKey;
        private System.Windows.Forms.Button buttonGetPrivateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog _encryptOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog _decryptOpenFileDialog;
    }
}

