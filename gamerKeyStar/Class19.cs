using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

// Token: 0x0200001C RID: 28
internal class Class19
{
	// Token: 0x060000C6 RID: 198 RVA: 0x0000289F File Offset: 0x00000A9F
	public Class19()
	{
		this.string_0 = this.method_3();
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000028B3 File Offset: 0x00000AB3
	public void method_0()
	{
		this.timer_0 = new Timer(new TimerCallback(this.method_4), null, 5000, -1);
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00008178 File Offset: 0x00006378
	private void method_1()
	{
		this.timer_0.Dispose();
		if (!(this.method_3() == this.string_0))
		{
			Class8.bool_0 = true;
			MessageBox.Show("ARP Cache poisoning has been detected!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Process.GetCurrentProcess().Kill();
		}
		else
		{
			this.string_0 = this.method_3();
		}
		this.timer_0 = new Timer(new TimerCallback(this.method_5), null, 5000, -1);
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x000081F4 File Offset: 0x000063F4
	public static IPAddress smethod_0()
	{
		return NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(Class19.Class20.<>9.method_0)).Where(new Func<NetworkInterface, bool>(Class19.Class20.<>9.method_1))
			.SelectMany(new Func<NetworkInterface, IEnumerable<GatewayIPAddressInformation>>(Class19.Class20.<>9.method_2))
			.Select(new Func<GatewayIPAddressInformation, IPAddress>(Class19.Class20.<>9.method_3))
			.Where(new Func<IPAddress, bool>(Class19.Class20.<>9.method_4))
			.FirstOrDefault<IPAddress>();
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000082C0 File Offset: 0x000064C0
	private string method_2()
	{
		string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
		string text;
		using (Process process = Process.Start(new ProcessStartInfo
		{
			FileName = pathRoot + "Windows\\System32\\arp.exe",
			Arguments = "-a",
			UseShellExecute = false,
			CreateNoWindow = true,
			RedirectStandardOutput = true
		}))
		{
			using (StreamReader standardOutput = process.StandardOutput)
			{
				text = standardOutput.ReadToEnd();
			}
		}
		return text;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00008358 File Offset: 0x00006558
	private string method_3()
	{
		string text = Class19.smethod_0().ToString();
		return new Regex(string.Format("({0} [\\W]*) ([a-z0-9-]*)", text)).Match(this.method_2()).Groups[2].ToString();
	}

	// Token: 0x060000CC RID: 204 RVA: 0x000028D3 File Offset: 0x00000AD3
	[CompilerGenerated]
	private void method_4(object object_0)
	{
		this.method_1();
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000028D3 File Offset: 0x00000AD3
	[CompilerGenerated]
	private void method_5(object object_0)
	{
		this.method_1();
	}

	// Token: 0x0400007D RID: 125
	private Timer timer_0;

	// Token: 0x0400007E RID: 126
	private string string_0;

	// Token: 0x0200001D RID: 29
	[CompilerGenerated]
	[Serializable]
	private sealed class Class20
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000028E7 File Offset: 0x00000AE7
		internal bool method_0(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.OperationalStatus == OperationalStatus.Up;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000028F2 File Offset: 0x00000AF2
		internal bool method_1(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.NetworkInterfaceType != NetworkInterfaceType.Loopback;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002901 File Offset: 0x00000B01
		internal IEnumerable<GatewayIPAddressInformation> method_2(NetworkInterface networkInterface_0)
		{
			IPInterfaceProperties ipproperties = networkInterface_0.GetIPProperties();
			if (ipproperties == null)
			{
				return null;
			}
			return ipproperties.GatewayAddresses;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002914 File Offset: 0x00000B14
		internal IPAddress method_3(GatewayIPAddressInformation gatewayIPAddressInformation_0)
		{
			if (gatewayIPAddressInformation_0 == null)
			{
				return null;
			}
			return gatewayIPAddressInformation_0.Address;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002921 File Offset: 0x00000B21
		internal bool method_4(IPAddress ipaddress_0)
		{
			return ipaddress_0 != null;
		}

		// Token: 0x0400007F RID: 127
		public static readonly Class19.Class20 <>9 = new Class19.Class20();

		// Token: 0x04000080 RID: 128
		public static Func<NetworkInterface, bool> <>9__5_0;

		// Token: 0x04000081 RID: 129
		public static Func<NetworkInterface, bool> <>9__5_1;

		// Token: 0x04000082 RID: 130
		public static Func<NetworkInterface, IEnumerable<GatewayIPAddressInformation>> <>9__5_2;

		// Token: 0x04000083 RID: 131
		public static Func<GatewayIPAddressInformation, IPAddress> <>9__5_3;

		// Token: 0x04000084 RID: 132
		public static Func<IPAddress, bool> <>9__5_4;
	}
}
