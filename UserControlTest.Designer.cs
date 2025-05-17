using System.ComponentModel;

namespace WinFormsExamTest2;

partial class UserControlTest
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label_fname_usercon = new System.Windows.Forms.Label();
        label_lname_usercon = new System.Windows.Forms.Label();
        label_age_usercon = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label_fname_usercon
        // 
        label_fname_usercon.Location = new System.Drawing.Point(17, 10);
        label_fname_usercon.Name = "label_fname_usercon";
        label_fname_usercon.Size = new System.Drawing.Size(51, 25);
        label_fname_usercon.TabIndex = 0;
        label_fname_usercon.Text = "Имя";
        label_fname_usercon.UseCompatibleTextRendering = true;
        // 
        // label_lname_usercon
        // 
        label_lname_usercon.Location = new System.Drawing.Point(74, 10);
        label_lname_usercon.Name = "label_lname_usercon";
        label_lname_usercon.Size = new System.Drawing.Size(68, 28);
        label_lname_usercon.TabIndex = 1;
        label_lname_usercon.Text = "Фамилия";
        // 
        // label_age_usercon
        // 
        label_age_usercon.Location = new System.Drawing.Point(325, 60);
        label_age_usercon.Name = "label_age_usercon";
        label_age_usercon.Size = new System.Drawing.Size(68, 28);
        label_age_usercon.TabIndex = 2;
        label_age_usercon.Text = "Возраст";
        // 
        // UserControlTest
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Controls.Add(label_age_usercon);
        Controls.Add(label_lname_usercon);
        Controls.Add(label_fname_usercon);
        Size = new System.Drawing.Size(418, 148);
        Load += UserControlTest_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label_fname_usercon;
    private System.Windows.Forms.Label label_lname_usercon;
    private System.Windows.Forms.Label label_age_usercon;

    #endregion
}