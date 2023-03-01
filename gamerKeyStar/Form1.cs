using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using gamerKeyStar.Properties;
using Microsoft.Win32;

// Token: 0x0200000C RID: 12
public partial class Form1 : Form
{
	// Token: 0x0600003B RID: 59 RVA: 0x00004438 File Offset: 0x00002638
	public Form1()
	{
		this.InitializeComponent();
		this.textBoxUtente.Text = Settings.Default.username;
		this.textBoxPassword.Text = Settings.Default.password;
		Settings.Default.Save();
		this.textBoxPassword.PasswordChar = '*';
		this.login.Dock = DockStyle.Fill;
		this.registrati.Dock = DockStyle.Fill;
		this.tweak.Dock = DockStyle.Fill;
		this.login.Hide();
		this.nonvalide.Hide();
		this.registrati.Hide();
		this.tweak.Show();
		this.campivuoti.Hide();
		this.nomepassword.Hide();
	}

	// Token: 0x0600003C RID: 60 RVA: 0x0000242F File Offset: 0x0000062F
	private void tweak_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000044F8 File Offset: 0x000026F8
	private void accedi_Click(object sender, EventArgs e)
	{
		Class13.smethod_0(this.textBoxUtente.ToString(), "login");
		if (Class13.smethod_5(this.textBoxUtente.Text, this.textBoxPassword.Text))
		{
			MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.login.Hide();
			this.tweak.Show();
		}
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000242F File Offset: 0x0000062F
	private void login_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002431 File Offset: 0x00000631
	private void registatib_Click(object sender, EventArgs e)
	{
		this.login.Hide();
		this.registrati.Show();
		this.textboxpass.PasswordChar = '*';
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0000242F File Offset: 0x0000062F
	private void registrati_Paint(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002456 File Offset: 0x00000656
	private void button2_Click(object sender, EventArgs e)
	{
		this.registrati.Hide();
		this.login.Show();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00004560 File Offset: 0x00002760
	private void button1_Click(object sender, EventArgs e)
	{
		if (this.textboxnomeUtente.Text == "" || this.textboxpass.Text == "")
		{
			this.nomepassword.Hide();
			this.campivuoti.Show();
			return;
		}
		if (this.textboxpass.Text.Length < 7)
		{
			this.campivuoti.Hide();
			this.nomepassword.Show();
			return;
		}
		if (Class13.smethod_6(this.textboxnomeUtente.Text, this.textboxpass.Text, this.email.Text, this.key.Text))
		{
			MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.textboxnomeUtente.Clear();
			this.textboxpass.Clear();
			this.registrati.Hide();
			this.login.Show();
		}
	}

	// Token: 0x06000043 RID: 67 RVA: 0x0000242F File Offset: 0x0000062F
	private void textboxnomeUtente_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000242F File Offset: 0x0000062F
	private void textBoxUtente_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00004654 File Offset: 0x00002854
	private void fps_Click(object sender, EventArgs e)
	{
		Class13.smethod_0(this.textBoxUtente.ToString(), "ESECUZIONE TWEAK IN CORSO");
		MessageBox.Show("ESECUZIONE TWEAK IN CORSO...");
		Registry.CurrentUser.OpenSubKey("Control Panel\\Accessibility\\StickyKeys", true).SetValue("flags", 0, RegistryValueKind.DWord);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
		registryKey.SetValue("MenuShowDelay", "0", RegistryValueKind.String);
		registryKey.SetValue("MaxMonitorDimension", 780, RegistryValueKind.DWord);
		registryKey.SetValue("MaxVirtualDesktopDimension", 780, RegistryValueKind.DWord);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Accessibility\\MouseKeys", true).SetValue("flags", 0, RegistryValueKind.String);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Accessibility\\Keyboard Response", true).SetValue("flags", 0, RegistryValueKind.String);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Accessibility\\ToggleKeys", true).SetValue("flags", 0, RegistryValueKind.String);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Accessibility\\Keyboard Response", true).SetValue("flags", 0, RegistryValueKind.String);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications", true).SetValue("GlobalUserDisabled", 1, RegistryValueKind.DWord);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Search", true).SetValue("BackgroundAppGlobalToggle", 0, RegistryValueKind.DWord);
		Thread.Sleep(3500);
		MessageBox.Show("TWEAK ESEGUITO CON SUCCESSO");
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000047CC File Offset: 0x000029CC
	private void button6_Click(object sender, EventArgs e)
	{
		Class13.smethod_0(this.textBoxUtente.ToString(), "RIDUZIONE PING IN CORSO");
		MessageBox.Show("RIDUZIONE PING IN CORSO...");
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion", true);
		registryKey.CreateSubKey("MaxConnectionPerServer");
		registryKey.CreateSubKey("MaxConnection1_0Server");
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion", true);
		registryKey2.SetValue("MaxConnectionPerServer", 22, RegistryValueKind.DWord);
		registryKey2.SetValue("MaxConnection1_0Server", 22, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\ServiceProvider", true);
		registryKey3.SetValue("LocalPriority", 4, RegistryValueKind.DWord);
		registryKey3.SetValue("HostsPriority", 5, RegistryValueKind.DWord);
		registryKey3.SetValue("DnsPriority", 6, RegistryValueKind.DWord);
		registryKey3.SetValue("NetbtPriority", 7, RegistryValueKind.DWord);
		Process.Start("FileBTC\\Disable_StorPort_Idle.bat").WaitForExit();
		Process.Start("FileBTC\\Disable_Spectre_and_Meltdown_&_more.bat").WaitForExit();
		Thread.Sleep(3500);
		MessageBox.Show("PING RIDOTTO CON SUCCESSO");
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000048E0 File Offset: 0x00002AE0
	private void button3_Click(object sender, EventArgs e)
	{
		Class13.smethod_0(this.textBoxUtente.ToString(), "RIDUZIONE INPUT DELAY IN CORSO");
		MessageBox.Show("RIDUZIONE INPUT DELAY IN CORSO...");
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\ControlSet001\\Control\\Session Manager\\Memory Management", true);
		registryKey.CreateSubKey("FeatureSettingsOverride");
		registryKey.CreateSubKey("FeatureSettingsOverrideMask");
		registryKey.SetValue("FeatureSettingsOverride", 3, RegistryValueKind.DWord);
		registryKey.SetValue("FeatureSettingsOverrideMask", 3, RegistryValueKind.DWord);
		registryKey.SetValue("FeatureSettings", 0, RegistryValueKind.DWord);
		Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power", true).SetValue("HibernateEnabledDefault", 0, RegistryValueKind.DWord);
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true);
		registryKey2.SetValue("Scheduling Category", "High", RegistryValueKind.String);
		registryKey2.SetValue("SFIO Priority", "High", RegistryValueKind.String);
		registryKey2.SetValue("Priority", 6, RegistryValueKind.DWord);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR", true).SetValue("value", 0, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
		registryKey3.SetValue("MaxMonitorDimension", 1920, RegistryValueKind.DWord);
		registryKey3.SetValue("MaxVirtualDesktopDimension", 1920, RegistryValueKind.DWord);
		Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\TokenBroker", true).SetValue("Start", 4, RegistryValueKind.DWord);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).SetValue("NoInstrumentation", 1, RegistryValueKind.DWord);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", true).SetValue("AllowTelemetry", 0, RegistryValueKind.DWord);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection", true).SetValue("AllowTelemetry", 0, RegistryValueKind.DWord);
		Process.Start("FileBTC\\Disable_Process_Mitigations.bat").WaitForExit();
		Process.Start("FileBTC\\Disable_USB_Idle.bat").WaitForExit();
		Thread.Sleep(3500);
		MessageBox.Show("INPUT DELAY RIDOTTO CON SUCCESSO");
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00004AE4 File Offset: 0x00002CE4
	private void button8_Click(object sender, EventArgs e)
	{
		Class13.smethod_0(this.textBoxUtente.ToString(), "RIDUZIONE PROCESSI IN CORSO");
		MessageBox.Show("RIDUZIONE PROCESSI IN CORSO...");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control", true);
		registryKey.SetValue("SystemStartOptions", "NOEXECUTE=OPTIN", RegistryValueKind.String);
		registryKey.SetValue("WaitToKillServiceTimeout", "5000", RegistryValueKind.String);
		registryKey.SetValue("SvcHostSplitThresholdInKB", 376926742, RegistryValueKind.DWord);
		registryKey.SetValue("DirtyShutdownCount", 2, RegistryValueKind.DWord);
		registryKey.SetValue("Scheduling Category", "high", RegistryValueKind.String);
		registryKey.SetValue("Priority", 6, RegistryValueKind.DWord);
		Process.Start("FileBTC\\Disable_HIPM_&_DIPM_HDD_Parking.bat").WaitForExit();
		Process.Start("FileBTC\\Disable_IoLatencyCap.bat").WaitForExit();
		Thread.Sleep(3500);
		MessageBox.Show("PROCESSI RIDOTTI CON SUCCESSO");
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00004BC0 File Offset: 0x00002DC0
	private void button7_Click(object sender, EventArgs e)
	{
		Class13.smethod_0(this.textBoxUtente.ToString(), "STABILIZZAZIONE FPS IN CORSO");
		MessageBox.Show("STABILIZZAZIONE FPS IN CORSO...");
		Process.Start("FileBTC\\!Set_current_install_default.bat").WaitForExit();
		Process.Start("FileBTC\\Delete_Chrome_bloatware.bat").WaitForExit();
		Thread.Sleep(3500);
		MessageBox.Show("FPS STABILIZZATI CON SUCCESSO");
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00004C20 File Offset: 0x00002E20
	private void button5_Click(object sender, EventArgs e)
	{
		Class13.smethod_0(this.textBoxUtente.ToString(), "ELIMINAZIONE FILE TEMPORANEI IN CORSO");
		MessageBox.Show("ELIMINAZIONE FILE TEMPORANEI IN CORSO...");
		Process.Start("FileBTC\\Delete_Temporary_Files.cmd").WaitForExit();
		Process.Start("FileBTC\\Delete_Log_Files.cmd").WaitForExit();
		Thread.Sleep(3500);
		MessageBox.Show("FILE TEMPORANEI ELIMINATI CON SUCCESSO");
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000246E File Offset: 0x0000066E
	private void button4_Click(object sender, EventArgs e)
	{
		MessageBox.Show("COMING SOON...");
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00004C80 File Offset: 0x00002E80
	private void button9_Click(object sender, EventArgs e)
	{
		Class13.smethod_0(this.textBoxUtente.ToString(), "PULIZIA DNS IN CORSO");
		MessageBox.Show("PULIZIA DNS IN CORSO...");
		Process.Start("FileBTC\\Clear_DNS_Cache_Ping_Improve.cmd").WaitForExit();
		Thread.Sleep(3500);
		MessageBox.Show("PULIZIA DNS AVVENUTA CON SUCCESSO");
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0000247B File Offset: 0x0000067B
	private void button12_Click(object sender, EventArgs e)
	{
		Process.Start("https://discord.gg/7S9U3muKDM");
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002488 File Offset: 0x00000688
	private void button11_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.instagram.com/keystar.team/");
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002495 File Offset: 0x00000695
	private void button10_Click(object sender, EventArgs e)
	{
		Process.Start("https://shoppy.gg/product/trZtrsP");
	}

	// Token: 0x06000050 RID: 80 RVA: 0x000024A2 File Offset: 0x000006A2
	private void method_0(object sender, EventArgs e)
	{
		if (this.textboxpass.PasswordChar == '\0')
		{
			this.textboxpass.PasswordChar = '*';
			return;
		}
		this.textboxpass.PasswordChar = '\0';
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000242F File Offset: 0x0000062F
	private void method_1(object sender, EventArgs e)
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000024CB File Offset: 0x000006CB
	private void button15_Click(object sender, EventArgs e)
	{
		this.tweak.Hide();
		this.login.Show();
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000024A2 File Offset: 0x000006A2
	private void method_2(object sender, EventArgs e)
	{
		if (this.textboxpass.PasswordChar == '\0')
		{
			this.textboxpass.PasswordChar = '*';
			return;
		}
		this.textboxpass.PasswordChar = '\0';
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000024E3 File Offset: 0x000006E3
	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if (this.textBoxPassword.PasswordChar == '\0')
		{
			this.textBoxPassword.PasswordChar = '*';
			return;
		}
		this.textBoxPassword.PasswordChar = '\0';
	}

	// Token: 0x06000055 RID: 85 RVA: 0x0000242F File Offset: 0x0000062F
	private void textBoxPassword_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000024A2 File Offset: 0x000006A2
	private void pictureBox2_Click(object sender, EventArgs e)
	{
		if (this.textboxpass.PasswordChar == '\0')
		{
			this.textboxpass.PasswordChar = '*';
			return;
		}
		this.textboxpass.PasswordChar = '\0';
	}

	// Token: 0x06000057 RID: 87 RVA: 0x0000250C File Offset: 0x0000070C
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0400002C RID: 44
	private IContainer icontainer_0;
}
