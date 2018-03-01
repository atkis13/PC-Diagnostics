namespace PC_diagnostics
{
    partial class frm_delete_pc
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
            this.cmb_select_id = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_select_id
            // 
            this.cmb_select_id.FormattingEnabled = true;
            this.cmb_select_id.Location = new System.Drawing.Point(78, 50);
            this.cmb_select_id.Name = "cmb_select_id";
            this.cmb_select_id.Size = new System.Drawing.Size(203, 21);
            this.cmb_select_id.TabIndex = 71;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(128, 108);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 33);
            this.btn_delete.TabIndex = 70;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // frm_delete_pc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 177);
            this.Controls.Add(this.cmb_select_id);
            this.Controls.Add(this.btn_delete);
            this.Name = "frm_delete_pc";
            this.Text = "Delete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_select_id;
        private System.Windows.Forms.Button btn_delete;
    }
}