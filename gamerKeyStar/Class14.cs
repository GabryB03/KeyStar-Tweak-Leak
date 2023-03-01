using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;

// Token: 0x02000017 RID: 23
internal class Class14
{
	// Token: 0x060000AF RID: 175 RVA: 0x00007B28 File Offset: 0x00005D28
	public static string smethod_0(string string_1)
	{
		string text;
		using (MD5 md = MD5.Create())
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			text = BitConverter.ToString(md.ComputeHash(bytes)).Replace("-", "");
		}
		return text;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00007B80 File Offset: 0x00005D80
	private static string smethod_1(int int_0)
	{
		Class14.Class16 @class = new Class14.Class16();
		@class.random_0 = new Random();
		return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz", int_0).Select(new Func<string, char>(@class.method_0)).ToArray<char>());
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00007BC4 File Offset: 0x00005DC4
	public static string smethod_2(int int_0)
	{
		Class14.Class17 @class = new Class14.Class17();
		@class.random_0 = new Random();
		return new string(Enumerable.Repeat<string>("gd8JQ57nxXzLLMPrLylVhxoGnWGCFjO4knKTfRE6mVvdjug2NF/4aptAsZcdIGbAPmcx0O+ftU/KvMIjcfUnH3j+IMdhAW5OpoX3MrjQdf5AAP97tTB5g1wdDSAqKpq9gw06t3VaqMWZHKtPSuAXy0kkZRsc+DicpcY8E9+vWMHXa3jMdbPx4YES0p66GzhqLd/heA2zMvX8iWv4wK7S3QKIW/a9dD4ALZJpmcr9OOE=", int_0).Select(new Func<string, char>(@class.method_0)).ToArray<char>());
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00007C08 File Offset: 0x00005E08
	public static void smethod_3()
	{
		string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
		if (!Class8.bool_1)
		{
			using (StreamReader streamReader = new StreamReader(pathRoot + "Windows\\System32\\drivers\\etc\\hosts"))
			{
				if (streamReader.ReadToEnd().Contains("api.auth.gg"))
				{
					Class8.bool_0 = true;
					MessageBox.Show("DNS redirecting has been detected!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
			}
			new Class19().method_0();
			Class8.String_0 = Guid.NewGuid().ToString();
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Class14.smethod_5));
			Class8.String_2 = Convert.ToBase64String(Encoding.Default.GetBytes(Class14.smethod_1(32)));
			Class8.String_3 = Convert.ToBase64String(Encoding.Default.GetBytes(Class14.smethod_1(16)));
			Class8.string_4 = Convert.ToBase64String(Encoding.Default.GetBytes(Class8.smethod_0(16)));
			Class8.string_5 = Convert.ToBase64String(Encoding.Default.GetBytes(Class8.smethod_0(32)));
			Class8.bool_1 = true;
			return;
		}
		MessageBox.Show("A session has already been started, please end the previous one!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
		Process.GetCurrentProcess().Kill();
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00007D60 File Offset: 0x00005F60
	public static void smethod_4()
	{
		if (!Class8.bool_1)
		{
			MessageBox.Show("No session has been started, closing for security reasons!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
			Process.GetCurrentProcess().Kill();
			return;
		}
		Class8.String_0 = null;
		ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(Class14.Class15.<>9.method_0);
		Class8.String_2 = null;
		Class8.String_3 = null;
		Class8.string_4 = null;
		Class8.string_5 = null;
		Class8.bool_1 = false;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002847 File Offset: 0x00000A47
	private static bool smethod_5(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return x509Certificate_0 != null && x509Certificate_0.GetPublicKeyString() == "3082010A0282010100ABDA0F3E94C51EDC5DC15E65D0DD98B6AC90EA1F712D1318A081700F5C06B50638456378F97D828D8A7CDFF6907D9A064E1182B62B16B3F4F8D125F8BA1279B42C18D7B14A3356E0F3E0907BBD1B287E33292260E5EBB8B050293AB11E63FEDEFDAFAA6A5DD15EF125832A20A5760BC76B6D10FD3DAAEFDC70924353D699A5C2DD8EF78D1AA5A9F9EFA7EDE7B8DBD893579B2A8EA87FCFF2F50D7E43F75EF8C9D0B01C5D1FB0E9C8E30FFA83AD5BE4A46BD7C707B2B027E5CAA96EF6386617186EFB22ACD2F1231228E75465546DE24C4D54032C3C44594CEC39302FCAD12AE784ACC73FD9E2D43A452A01ABF9ACCE8E124601DD11AFBF43089F636FDB730D270203010001";
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00007DDC File Offset: 0x00005FDC
	public static string smethod_6(string string_1)
	{
		string text;
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(string_1))
			{
				text = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
			}
		}
		return text;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00007E4C File Offset: 0x0000604C
	public static bool smethod_7(string string_1)
	{
		DateTime dateTime = DateTime.Parse(string_1);
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = dateTime - now;
		if (Convert.ToInt32(timeSpan.Seconds.ToString().Replace("-", "")) < 5 && Convert.ToInt32(timeSpan.Minutes.ToString().Replace("-", "")) < 1)
		{
			return false;
		}
		Class8.bool_0 = true;
		return true;
	}

	// Token: 0x04000078 RID: 120
	private const string string_0 = "3082010A0282010100ABDA0F3E94C51EDC5DC15E65D0DD98B6AC90EA1F712D1318A081700F5C06B50638456378F97D828D8A7CDFF6907D9A064E1182B62B16B3F4F8D125F8BA1279B42C18D7B14A3356E0F3E0907BBD1B287E33292260E5EBB8B050293AB11E63FEDEFDAFAA6A5DD15EF125832A20A5760BC76B6D10FD3DAAEFDC70924353D699A5C2DD8EF78D1AA5A9F9EFA7EDE7B8DBD893579B2A8EA87FCFF2F50D7E43F75EF8C9D0B01C5D1FB0E9C8E30FFA83AD5BE4A46BD7C707B2B027E5CAA96EF6386617186EFB22ACD2F1231228E75465546DE24C4D54032C3C44594CEC39302FCAD12AE784ACC73FD9E2D43A452A01ABF9ACCE8E124601DD11AFBF43089F636FDB730D270203010001";

	// Token: 0x02000018 RID: 24
	[CompilerGenerated]
	[Serializable]
	private sealed class Class15
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0000286A File Offset: 0x00000A6A
		internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}

		// Token: 0x04000079 RID: 121
		public static readonly Class14.Class15 <>9 = new Class14.Class15();

		// Token: 0x0400007A RID: 122
		public static RemoteCertificateValidationCallback <>9__4_0;
	}

	// Token: 0x02000019 RID: 25
	[CompilerGenerated]
	private sealed class Class16
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000286D File Offset: 0x00000A6D
		internal char method_0(string string_0)
		{
			return string_0[this.random_0.Next(string_0.Length)];
		}

		// Token: 0x0400007B RID: 123
		public Random random_0;
	}

	// Token: 0x0200001A RID: 26
	[CompilerGenerated]
	private sealed class Class17
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002886 File Offset: 0x00000A86
		internal char method_0(string string_0)
		{
			return string_0[this.random_0.Next(string_0.Length)];
		}

		// Token: 0x0400007C RID: 124
		public Random random_0;
	}
}
