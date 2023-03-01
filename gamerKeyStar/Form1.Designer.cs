// Token: 0x0200000C RID: 12
public partial class Form1 : global::System.Windows.Forms.Form
{
	// Token: 0x06000058 RID: 88 RVA: 0x00004CD4 File Offset: 0x00002ED4
	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Form1));
		this.tweak = new global::System.Windows.Forms.Panel();
		this.button15 = new global::System.Windows.Forms.Button();
		this.button9 = new global::System.Windows.Forms.Button();
		this.button8 = new global::System.Windows.Forms.Button();
		this.button7 = new global::System.Windows.Forms.Button();
		this.button6 = new global::System.Windows.Forms.Button();
		this.button5 = new global::System.Windows.Forms.Button();
		this.button4 = new global::System.Windows.Forms.Button();
		this.button3 = new global::System.Windows.Forms.Button();
		this.fps = new global::System.Windows.Forms.Button();
		this.accedi = new global::System.Windows.Forms.Button();
		this.registatib = new global::System.Windows.Forms.Button();
		this.textBoxUtente = new global::System.Windows.Forms.TextBox();
		this.textBoxPassword = new global::System.Windows.Forms.TextBox();
		this.login = new global::System.Windows.Forms.Panel();
		this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
		this.nonvalide = new global::System.Windows.Forms.Label();
		this.registrati = new global::System.Windows.Forms.Panel();
		this.key = new global::System.Windows.Forms.TextBox();
		this.email = new global::System.Windows.Forms.TextBox();
		this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
		this.campivuoti = new global::System.Windows.Forms.Label();
		this.nomepassword = new global::System.Windows.Forms.Label();
		this.button12 = new global::System.Windows.Forms.Button();
		this.button11 = new global::System.Windows.Forms.Button();
		this.button10 = new global::System.Windows.Forms.Button();
		this.textboxpass = new global::System.Windows.Forms.TextBox();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.textboxnomeUtente = new global::System.Windows.Forms.TextBox();
		this.tweak.SuspendLayout();
		this.login.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.registrati.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		base.SuspendLayout();
		this.tweak.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("tweak.BackgroundImage");
		this.tweak.Controls.Add(this.button15);
		this.tweak.Controls.Add(this.button9);
		this.tweak.Controls.Add(this.button8);
		this.tweak.Controls.Add(this.button7);
		this.tweak.Controls.Add(this.button6);
		this.tweak.Controls.Add(this.button5);
		this.tweak.Controls.Add(this.button4);
		this.tweak.Controls.Add(this.button3);
		this.tweak.Controls.Add(this.fps);
		this.tweak.Location = new global::System.Drawing.Point(-1, -1);
		this.tweak.Name = "tweak";
		this.tweak.Size = new global::System.Drawing.Size(600, 300);
		this.tweak.TabIndex = 0;
		this.tweak.Paint += new global::System.Windows.Forms.PaintEventHandler(this.tweak_Paint);
		this.button15.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button15.BackgroundImage");
		this.button15.Location = new global::System.Drawing.Point(447, 246);
		this.button15.Name = "button15";
		this.button15.Size = new global::System.Drawing.Size(99, 21);
		this.button15.TabIndex = 16;
		this.button15.UseVisualStyleBackColor = true;
		this.button15.Click += new global::System.EventHandler(this.button15_Click);
		this.button9.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button9.BackgroundImage");
		this.button9.Location = new global::System.Drawing.Point(447, 212);
		this.button9.Name = "button9";
		this.button9.Size = new global::System.Drawing.Size(92, 18);
		this.button9.TabIndex = 8;
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new global::System.EventHandler(this.button9_Click);
		this.button8.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button8.BackgroundImage");
		this.button8.Location = new global::System.Drawing.Point(447, 133);
		this.button8.Name = "button8";
		this.button8.Size = new global::System.Drawing.Size(92, 18);
		this.button8.TabIndex = 7;
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new global::System.EventHandler(this.button8_Click);
		this.button7.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button7.BackgroundImage");
		this.button7.Location = new global::System.Drawing.Point(56, 212);
		this.button7.Name = "button7";
		this.button7.Size = new global::System.Drawing.Size(92, 18);
		this.button7.TabIndex = 6;
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new global::System.EventHandler(this.button7_Click);
		this.button6.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button6.BackgroundImage");
		this.button6.Location = new global::System.Drawing.Point(178, 133);
		this.button6.Name = "button6";
		this.button6.Size = new global::System.Drawing.Size(92, 18);
		this.button6.TabIndex = 5;
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new global::System.EventHandler(this.button6_Click);
		this.button5.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button5.BackgroundImage");
		this.button5.Location = new global::System.Drawing.Point(178, 212);
		this.button5.Name = "button5";
		this.button5.Size = new global::System.Drawing.Size(92, 18);
		this.button5.TabIndex = 4;
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new global::System.EventHandler(this.button5_Click);
		this.button4.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button4.BackgroundImage");
		this.button4.Location = new global::System.Drawing.Point(316, 213);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(92, 18);
		this.button4.TabIndex = 3;
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.button3.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button3.BackgroundImage");
		this.button3.Location = new global::System.Drawing.Point(316, 133);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(92, 18);
		this.button3.TabIndex = 2;
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.fps.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("fps.BackgroundImage");
		this.fps.Location = new global::System.Drawing.Point(56, 133);
		this.fps.Name = "fps";
		this.fps.Size = new global::System.Drawing.Size(92, 18);
		this.fps.TabIndex = 1;
		this.fps.UseVisualStyleBackColor = true;
		this.fps.Click += new global::System.EventHandler(this.fps_Click);
		this.accedi.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("accedi.BackgroundImage");
		this.accedi.Location = new global::System.Drawing.Point(470, 212);
		this.accedi.Name = "accedi";
		this.accedi.Size = new global::System.Drawing.Size(0, 0);
		this.accedi.TabIndex = 0;
		this.accedi.UseVisualStyleBackColor = true;
		this.accedi.Click += new global::System.EventHandler(this.accedi_Click);
		this.registatib.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("registatib.BackgroundImage");
		this.registatib.Location = new global::System.Drawing.Point(305, 212);
		this.registatib.Name = "registatib";
		this.registatib.Size = new global::System.Drawing.Size(139, 21);
		this.registatib.TabIndex = 1;
		this.registatib.UseVisualStyleBackColor = true;
		this.registatib.Click += new global::System.EventHandler(this.registatib_Click);
		this.textBoxUtente.Location = new global::System.Drawing.Point(337, 114);
		this.textBoxUtente.Name = "textBoxUtente";
		this.textBoxUtente.Size = new global::System.Drawing.Size(196, 20);
		this.textBoxUtente.TabIndex = 2;
		this.textBoxUtente.TextChanged += new global::System.EventHandler(this.textBoxUtente_TextChanged);
		this.textBoxPassword.Location = new global::System.Drawing.Point(337, 171);
		this.textBoxPassword.Name = "textBoxPassword";
		this.textBoxPassword.Size = new global::System.Drawing.Size(196, 20);
		this.textBoxPassword.TabIndex = 3;
		this.textBoxPassword.TextChanged += new global::System.EventHandler(this.textBoxPassword_TextChanged);
		this.login.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("login.BackgroundImage");
		this.login.Controls.Add(this.pictureBox1);
		this.login.Controls.Add(this.nonvalide);
		this.login.Controls.Add(this.textBoxPassword);
		this.login.Controls.Add(this.textBoxUtente);
		this.login.Controls.Add(this.registatib);
		this.login.Controls.Add(this.accedi);
		this.login.Location = new global::System.Drawing.Point(649, 1);
		this.login.Name = "login";
		this.login.Size = new global::System.Drawing.Size(600, 300);
		this.login.TabIndex = 1;
		this.login.Paint += new global::System.Windows.Forms.PaintEventHandler(this.login_Paint);
		this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
		this.pictureBox1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.ErrorImage");
		this.pictureBox1.InitialImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.InitialImage");
		this.pictureBox1.Location = new global::System.Drawing.Point(533, 171);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new global::System.Drawing.Size(20, 20);
		this.pictureBox1.TabIndex = 16;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
		this.nonvalide.AutoSize = true;
		this.nonvalide.BackColor = global::System.Drawing.Color.Transparent;
		this.nonvalide.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
		this.nonvalide.Location = new global::System.Drawing.Point(363, 194);
		this.nonvalide.Name = "nonvalide";
		this.nonvalide.Size = new global::System.Drawing.Size(148, 13);
		this.nonvalide.TabIndex = 4;
		this.nonvalide.Text = "Credenziali non valide, riprova";
		this.registrati.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("registrati.BackgroundImage");
		this.registrati.Controls.Add(this.key);
		this.registrati.Controls.Add(this.email);
		this.registrati.Controls.Add(this.pictureBox2);
		this.registrati.Controls.Add(this.campivuoti);
		this.registrati.Controls.Add(this.nomepassword);
		this.registrati.Controls.Add(this.button12);
		this.registrati.Controls.Add(this.button11);
		this.registrati.Controls.Add(this.button10);
		this.registrati.Controls.Add(this.textboxpass);
		this.registrati.Controls.Add(this.button2);
		this.registrati.Controls.Add(this.button1);
		this.registrati.Controls.Add(this.textboxnomeUtente);
		this.registrati.Location = new global::System.Drawing.Point(649, 325);
		this.registrati.Name = "registrati";
		this.registrati.Size = new global::System.Drawing.Size(600, 300);
		this.registrati.TabIndex = 1;
		this.registrati.Paint += new global::System.Windows.Forms.PaintEventHandler(this.registrati_Paint);
		this.key.Location = new global::System.Drawing.Point(232, 213);
		this.key.Multiline = true;
		this.key.Name = "key";
		this.key.Size = new global::System.Drawing.Size(139, 17);
		this.key.TabIndex = 20;
		this.email.Location = new global::System.Drawing.Point(232, 171);
		this.email.Multiline = true;
		this.email.Name = "email";
		this.email.Size = new global::System.Drawing.Size(139, 17);
		this.email.TabIndex = 19;
		this.pictureBox2.BackColor = global::System.Drawing.Color.Transparent;
		this.pictureBox2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage");
		this.pictureBox2.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.ErrorImage");
		this.pictureBox2.InitialImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.InitialImage");
		this.pictureBox2.Location = new global::System.Drawing.Point(371, 133);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new global::System.Drawing.Size(20, 17);
		this.pictureBox2.TabIndex = 17;
		this.pictureBox2.TabStop = false;
		this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
		this.campivuoti.AutoSize = true;
		this.campivuoti.BackColor = global::System.Drawing.Color.Transparent;
		this.campivuoti.ForeColor = global::System.Drawing.Color.Red;
		this.campivuoti.Location = new global::System.Drawing.Point(470, 230);
		this.campivuoti.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.campivuoti.Name = "campivuoti";
		this.campivuoti.Size = new global::System.Drawing.Size(62, 13);
		this.campivuoti.TabIndex = 13;
		this.campivuoti.Text = "Campi vuoti";
		this.nomepassword.AutoSize = true;
		this.nomepassword.BackColor = global::System.Drawing.Color.Transparent;
		this.nomepassword.ForeColor = global::System.Drawing.Color.Red;
		this.nomepassword.Location = new global::System.Drawing.Point(439, 230);
		this.nomepassword.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.nomepassword.Name = "nomepassword";
		this.nomepassword.Size = new global::System.Drawing.Size(141, 13);
		this.nomepassword.TabIndex = 12;
		this.nomepassword.Text = "Password minimo 8 caratteri.";
		this.button12.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button12.BackgroundImage");
		this.button12.Location = new global::System.Drawing.Point(62, 226);
		this.button12.Name = "button12";
		this.button12.Size = new global::System.Drawing.Size(92, 18);
		this.button12.TabIndex = 11;
		this.button12.UseVisualStyleBackColor = true;
		this.button12.Click += new global::System.EventHandler(this.button12_Click);
		this.button11.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button11.BackgroundImage");
		this.button11.Location = new global::System.Drawing.Point(62, 169);
		this.button11.Name = "button11";
		this.button11.Size = new global::System.Drawing.Size(92, 18);
		this.button11.TabIndex = 10;
		this.button11.UseVisualStyleBackColor = true;
		this.button11.Click += new global::System.EventHandler(this.button11_Click);
		this.button10.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button10.BackgroundImage");
		this.button10.Location = new global::System.Drawing.Point(62, 133);
		this.button10.Name = "button10";
		this.button10.Size = new global::System.Drawing.Size(92, 18);
		this.button10.TabIndex = 9;
		this.button10.UseVisualStyleBackColor = true;
		this.button10.Click += new global::System.EventHandler(this.button10_Click);
		this.textboxpass.Location = new global::System.Drawing.Point(232, 133);
		this.textboxpass.Multiline = true;
		this.textboxpass.Name = "textboxpass";
		this.textboxpass.Size = new global::System.Drawing.Size(139, 17);
		this.textboxpass.TabIndex = 18;
		this.button2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button2.BackgroundImage");
		this.button2.Location = new global::System.Drawing.Point(453, 201);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(99, 21);
		this.button2.TabIndex = 5;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.BackgroundImage");
		this.button1.Location = new global::System.Drawing.Point(430, 252);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(139, 21);
		this.button1.TabIndex = 5;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.textboxnomeUtente.Location = new global::System.Drawing.Point(232, 92);
		this.textboxnomeUtente.Multiline = true;
		this.textboxnomeUtente.Name = "textboxnomeUtente";
		this.textboxnomeUtente.Size = new global::System.Drawing.Size(139, 17);
		this.textboxnomeUtente.TabIndex = 5;
		this.textboxnomeUtente.TextChanged += new global::System.EventHandler(this.textboxnomeUtente_TextChanged);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(596, 295);
		base.Controls.Add(this.registrati);
		base.Controls.Add(this.login);
		base.Controls.Add(this.tweak);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "Form1";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "KeyStarTweak v.2 | Cracked by https://github.com/GabryB03/";
		this.tweak.ResumeLayout(false);
		this.login.ResumeLayout(false);
		this.login.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.registrati.ResumeLayout(false);
		this.registrati.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x0400002D RID: 45
	private global::System.Windows.Forms.Panel tweak;

	// Token: 0x0400002E RID: 46
	private global::System.Windows.Forms.Button accedi;

	// Token: 0x0400002F RID: 47
	private global::System.Windows.Forms.Button registatib;

	// Token: 0x04000030 RID: 48
	private global::System.Windows.Forms.TextBox textBoxUtente;

	// Token: 0x04000031 RID: 49
	private global::System.Windows.Forms.TextBox textBoxPassword;

	// Token: 0x04000032 RID: 50
	private global::System.Windows.Forms.Panel login;

	// Token: 0x04000033 RID: 51
	private global::System.Windows.Forms.Panel registrati;

	// Token: 0x04000034 RID: 52
	private global::System.Windows.Forms.Button fps;

	// Token: 0x04000035 RID: 53
	private global::System.Windows.Forms.Label nonvalide;

	// Token: 0x04000036 RID: 54
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000037 RID: 55
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000038 RID: 56
	private global::System.Windows.Forms.TextBox textboxnomeUtente;

	// Token: 0x04000039 RID: 57
	private global::System.Windows.Forms.TextBox textboxpass;

	// Token: 0x0400003A RID: 58
	private global::System.Windows.Forms.Button button9;

	// Token: 0x0400003B RID: 59
	private global::System.Windows.Forms.Button button8;

	// Token: 0x0400003C RID: 60
	private global::System.Windows.Forms.Button button7;

	// Token: 0x0400003D RID: 61
	private global::System.Windows.Forms.Button button6;

	// Token: 0x0400003E RID: 62
	private global::System.Windows.Forms.Button button5;

	// Token: 0x0400003F RID: 63
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000040 RID: 64
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04000041 RID: 65
	private global::System.Windows.Forms.Button button12;

	// Token: 0x04000042 RID: 66
	private global::System.Windows.Forms.Button button11;

	// Token: 0x04000043 RID: 67
	private global::System.Windows.Forms.Button button10;

	// Token: 0x04000044 RID: 68
	private global::System.Windows.Forms.Label campivuoti;

	// Token: 0x04000045 RID: 69
	private global::System.Windows.Forms.Label nomepassword;

	// Token: 0x04000046 RID: 70
	private global::System.Windows.Forms.Button button15;

	// Token: 0x04000047 RID: 71
	private global::System.Windows.Forms.PictureBox pictureBox1;

	// Token: 0x04000048 RID: 72
	private global::System.Windows.Forms.PictureBox pictureBox2;

	// Token: 0x04000049 RID: 73
	private global::System.Windows.Forms.TextBox email;

	// Token: 0x0400004A RID: 74
	private global::System.Windows.Forms.TextBox key;
}
