using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;

// Token: 0x02000015 RID: 21
internal class Class12
{
	// Token: 0x060000A4 RID: 164 RVA: 0x000061C4 File Offset: 0x000043C4
	public static void smethod_0(string string_5, string string_6, string string_7, string string_8)
	{
		if (string.IsNullOrWhiteSpace(string_5) || string.IsNullOrWhiteSpace(string_6) || string.IsNullOrWhiteSpace(string_7) || string.IsNullOrWhiteSpace(string_8) || string_5.Contains("APPNAME"))
		{
			MessageBox.Show("Failed to initialize your application correctly in Program.cs!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Process.GetCurrentProcess().Kill();
		}
		Class12.string_0 = string_6;
		Class12.string_1 = string_7;
		Class12.string_2 = string_8;
		Class12.string_3 = string_5;
		string[] array = new string[0];
		using (WebClient webClient = new WebClient())
		{
			try
			{
				webClient.Proxy = null;
				Class14.smethod_3();
				Encoding @default = Encoding.Default;
				WebClient webClient2 = webClient;
				string string_9 = Class8.string_6;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["token"] = Class18.smethod_1(Class8.String_0);
				nameValueCollection["timestamp"] = Class18.smethod_1(DateTime.Now.ToString());
				nameValueCollection["aid"] = Class18.smethod_0(Class12.string_0);
				nameValueCollection["session_id"] = Class8.string_4;
				nameValueCollection["api_id"] = Class8.String_3;
				nameValueCollection["api_key"] = Class8.String_2;
				nameValueCollection["session_key"] = Class8.string_5;
				nameValueCollection["secret"] = Class18.smethod_0(Class12.string_1);
				nameValueCollection["type"] = Class18.smethod_0("start");
				array = Class18.smethod_2(@default.GetString(webClient2.UploadValues(string_9, nameValueCollection))).Split("|".ToCharArray());
				if (Class14.smethod_7(array[1]))
				{
					MessageBox.Show("Possible malicious activity detected!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
					Process.GetCurrentProcess().Kill();
				}
				if (Class8.bool_0)
				{
					MessageBox.Show("Possible malicious activity detected!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
					Process.GetCurrentProcess().Kill();
				}
				if (array[0] != Class8.String_0)
				{
					MessageBox.Show("Security error has been triggered!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
				string text = array[2];
				if (!(text == "success"))
				{
					if (text == "binderror")
					{
						MessageBox.Show(Class18.smethod_5("RmFpbGVkIHRvIGJpbmQgdG8gc2VydmVyLCBjaGVjayB5b3VyIEFJRCAmIFNlY3JldCBpbiB5b3VyIGNvZGUh"), Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
						return;
					}
					if (text == "banned")
					{
						MessageBox.Show("This application has been banned for violating the TOS" + Environment.NewLine + "Contact us at support@auth.gg", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
						return;
					}
				}
				else
				{
					Class8.bool_2 = true;
					if (array[3] == "Enabled")
					{
						Class11.Boolean_0 = true;
					}
					if (array[4] == "Enabled")
					{
						Class11.Boolean_1 = true;
					}
					Class11.String_0 = array[5];
					Class11.String_1 = array[6];
					Class11.String_2 = array[7];
					if (array[8] == "Enabled")
					{
						Class11.Boolean_2 = true;
					}
					if (array[9] == "Enabled")
					{
						Class11.Boolean_3 = true;
					}
					Class11.String_3 = array[10];
					if (array[11] == "Enabled")
					{
						Class11.Boolean_4 = true;
					}
					Class11.String_4 = array[13];
					if (Class11.Boolean_1)
					{
						File.Create(Environment.CurrentDirectory + "/integrity.log").Close();
						string text2 = Class14.smethod_6(Process.GetCurrentProcess().MainModule.FileName);
						File.WriteAllText(Environment.CurrentDirectory + "/integrity.log", text2);
					}
					else
					{
						if (Class11.String_1 != Class12.string_2)
						{
							MessageBox.Show("Update " + Class11.String_1 + " available, redirecting to update!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
							Process.Start(Class11.String_2);
							Process.GetCurrentProcess().Kill();
						}
						if (array[12] == "Enabled" && Class11.String_0 != Class14.smethod_6(Process.GetCurrentProcess().MainModule.FileName))
						{
							MessageBox.Show("File has been tampered with, couldn't verify integrity!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
							Process.GetCurrentProcess().Kill();
						}
					}
					if (!Class11.Boolean_0)
					{
						MessageBox.Show("Looks like this application is disabled, please try again later!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
					}
				}
				Class14.smethod_4();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
		}
	}

	// Token: 0x04000073 RID: 115
	public static string string_0;

	// Token: 0x04000074 RID: 116
	public static string string_1;

	// Token: 0x04000075 RID: 117
	public static string string_2;

	// Token: 0x04000076 RID: 118
	public static string string_3;

	// Token: 0x04000077 RID: 119
	public static string string_4;
}
