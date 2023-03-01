using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows;

// Token: 0x02000016 RID: 22
internal class Class13
{
	// Token: 0x060000A6 RID: 166 RVA: 0x00006634 File Offset: 0x00004834
	public static void smethod_0(string string_0, string string_1)
	{
		if (!Class8.bool_2)
		{
			MessageBox.Show("Please initialize your application first!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Process.GetCurrentProcess().Kill();
		}
		if (string.IsNullOrWhiteSpace(string_1))
		{
			MessageBox.Show("Missing log information!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Process.GetCurrentProcess().Kill();
		}
		using (WebClient webClient = new WebClient())
		{
			try
			{
				Class14.smethod_3();
				webClient.Proxy = null;
				Encoding @default = Encoding.Default;
				WebClient webClient2 = webClient;
				string string_2 = Class8.string_6;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["token"] = Class18.smethod_1(Class8.String_0);
				nameValueCollection["aid"] = Class18.smethod_0(Class12.string_0);
				nameValueCollection["username"] = Class18.smethod_0(string_0);
				nameValueCollection["pcuser"] = Class18.smethod_0(Environment.UserName);
				nameValueCollection["session_id"] = Class8.string_4;
				nameValueCollection["api_id"] = Class8.String_3;
				nameValueCollection["api_key"] = Class8.String_2;
				nameValueCollection["data"] = Class18.smethod_0(string_1);
				nameValueCollection["session_key"] = Class8.string_5;
				nameValueCollection["secret"] = Class18.smethod_0(Class12.string_1);
				nameValueCollection["type"] = Class18.smethod_0("log");
				Class18.smethod_2(@default.GetString(webClient2.UploadValues(string_2, nameValueCollection))).Split("|".ToCharArray());
				Class14.smethod_4();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000067FC File Offset: 0x000049FC
	public static void smethod_1(string string_0, string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1))
		{
			MessageBox.Show("Invalid Picture information!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Process.GetCurrentProcess().Kill();
		}
		using (WebClient webClient = new WebClient())
		{
			try
			{
				webClient.Proxy = null;
				Class14.smethod_3();
				Encoding @default = Encoding.Default;
				WebClient webClient2 = webClient;
				string string_2 = Class8.string_6;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["token"] = Class18.smethod_1(Class8.String_0);
				nameValueCollection["timestamp"] = Class18.smethod_1(DateTime.Now.ToString());
				nameValueCollection["aid"] = Class18.smethod_0(Class12.string_0);
				nameValueCollection["username"] = Class18.smethod_0(string_0);
				nameValueCollection["picbytes"] = Class18.smethod_0(string_1);
				nameValueCollection["session_id"] = Class8.string_4;
				nameValueCollection["api_id"] = Class8.String_3;
				nameValueCollection["api_key"] = Class8.String_2;
				nameValueCollection["session_key"] = Class8.string_5;
				nameValueCollection["secret"] = Class18.smethod_0(Class12.string_1);
				nameValueCollection["type"] = Class18.smethod_0("uploadpic");
				string text = Class18.smethod_2(@default.GetString(webClient2.UploadValues(string_2, nameValueCollection))).Split("|".ToCharArray())[0];
				if (text == "success")
				{
					MessageBox.Show("Successfully updated profile picture!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Asterisk);
					Class14.smethod_4();
				}
				else if (!(text == "permissions"))
				{
					if (text == "failed")
					{
						MessageBox.Show("Failed to upload profile picture!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Class14.smethod_4();
					}
				}
				else
				{
					MessageBox.Show("Please upgrade your plan to use this feature!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002830 File Offset: 0x00000A30
	public static bool smethod_2(string string_0)
	{
		return Class13.smethod_3(string_0) || Class13.smethod_4(string_0);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00006A20 File Offset: 0x00004C20
	public static bool smethod_3(string string_0)
	{
		if (!Class8.bool_2)
		{
			MessageBox.Show("Please initialize your application first!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Process.GetCurrentProcess().Kill();
		}
		if (string.IsNullOrWhiteSpace(string_0))
		{
			MessageBox.Show("Username/password mancanti", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		string[] array = new string[0];
		bool flag;
		using (WebClient webClient = new WebClient())
		{
			try
			{
				Class14.smethod_3();
				webClient.Proxy = null;
				Encoding @default = Encoding.Default;
				WebClient webClient2 = webClient;
				string string_ = Class8.string_6;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["token"] = Class18.smethod_1(Class8.String_0);
				nameValueCollection["timestamp"] = Class18.smethod_1(DateTime.Now.ToString());
				nameValueCollection["aid"] = Class18.smethod_0(Class12.string_0);
				nameValueCollection["session_id"] = Class8.string_4;
				nameValueCollection["api_id"] = Class8.String_3;
				nameValueCollection["api_key"] = Class8.String_2;
				nameValueCollection["username"] = Class18.smethod_0(string_0);
				nameValueCollection["password"] = Class18.smethod_0(string_0);
				nameValueCollection["hwid"] = Class18.smethod_0(Class8.smethod_1());
				nameValueCollection["session_key"] = Class8.string_5;
				nameValueCollection["secret"] = Class18.smethod_0(Class12.string_1);
				nameValueCollection["type"] = Class18.smethod_0("login");
				array = Class18.smethod_2(@default.GetString(webClient2.UploadValues(string_, nameValueCollection))).Split("|".ToCharArray());
				if (array[0] != Class8.String_0)
				{
					MessageBox.Show("Security error has been triggered!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
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
				string text = array[2];
				if (text == "success")
				{
					Class14.smethod_4();
					Class10.String_0 = array[3];
					Class10.String_1 = array[4];
					Class10.String_2 = array[5];
					Class10.String_3 = array[6];
					Class10.String_4 = array[7];
					Class10.String_6 = array[8];
					Class10.String_7 = array[9];
					Class10.String_5 = array[10];
					Class10.String_8 = array[11];
					Class10.String_9 = array[12];
					Class10.String_10 = array[13];
					string[] array2 = array[14].Split(new char[] { '~' });
					for (int i = 0; i < array2.Length; i++)
					{
						string[] array3 = array2[i].Split(new char[] { '^' });
						try
						{
							Class7.dictionary_0.Add(array3[0], array3[1]);
						}
						catch
						{
						}
					}
					return true;
				}
				if (text == "invalid_details")
				{
					Class14.smethod_4();
					return false;
				}
				if (text == "time_expired")
				{
					MessageBox.Show("La tua key è scaduta!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
				if (text == "hwid_updated")
				{
					MessageBox.Show("La tua nuova macchina è stata settata, per favore riapri l'applicazione!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Asterisk);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
				if (text == "invalid_hwid")
				{
					MessageBox.Show("Questo utente è gia collegato ad un altro computer, per favore contatta il supporto!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Class14.smethod_4();
				Process.GetCurrentProcess().Kill();
			}
			flag = false;
		}
		return flag;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00006E28 File Offset: 0x00005028
	public static bool smethod_4(string string_0)
	{
		if (!Class8.bool_2)
		{
			MessageBox.Show("Please initialize your application first!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Class14.smethod_4();
			Process.GetCurrentProcess().Kill();
		}
		if (string.IsNullOrWhiteSpace(string_0))
		{
			MessageBox.Show("Invalid registrar information!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		bool flag;
		using (WebClient webClient = new WebClient())
		{
			try
			{
				Class14.smethod_3();
				webClient.Proxy = null;
				Encoding @default = Encoding.Default;
				WebClient webClient2 = webClient;
				string string_ = Class8.string_6;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["token"] = Class18.smethod_1(Class8.String_0);
				nameValueCollection["timestamp"] = Class18.smethod_1(DateTime.Now.ToString());
				nameValueCollection["aid"] = Class18.smethod_0(Class12.string_0);
				nameValueCollection["session_id"] = Class8.string_4;
				nameValueCollection["api_id"] = Class8.String_3;
				nameValueCollection["api_key"] = Class8.String_2;
				nameValueCollection["session_key"] = Class8.string_5;
				nameValueCollection["secret"] = Class18.smethod_0(Class12.string_1);
				nameValueCollection["type"] = Class18.smethod_0("register");
				nameValueCollection["username"] = Class18.smethod_0(string_0);
				nameValueCollection["password"] = Class18.smethod_0(string_0);
				nameValueCollection["email"] = Class18.smethod_0(string_0);
				nameValueCollection["license"] = Class18.smethod_0(string_0);
				nameValueCollection["hwid"] = Class18.smethod_0(Class8.smethod_1());
				string[] array = Class18.smethod_2(@default.GetString(webClient2.UploadValues(string_, nameValueCollection))).Split("|".ToCharArray());
				if (array[0] != Class8.String_0)
				{
					MessageBox.Show("Security error has been triggered!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
				}
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
				Class14.smethod_4();
				string text = array[2];
				if (text == "success")
				{
					return true;
				}
				if (text == "error")
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			flag = false;
		}
		return flag;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000070D0 File Offset: 0x000052D0
	public static bool smethod_5(string string_0, string string_1)
	{
		if (!Class8.bool_2)
		{
			MessageBox.Show("Please initialize your application first!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Process.GetCurrentProcess().Kill();
		}
		if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1))
		{
			MessageBox.Show("Username/passwsord mancanti!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		string[] array = new string[0];
		bool flag;
		using (WebClient webClient = new WebClient())
		{
			try
			{
				Class14.smethod_3();
				webClient.Proxy = null;
				Encoding @default = Encoding.Default;
				WebClient webClient2 = webClient;
				string string_2 = Class8.string_6;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["token"] = Class18.smethod_1(Class8.String_0);
				nameValueCollection["timestamp"] = Class18.smethod_1(DateTime.Now.ToString());
				nameValueCollection["aid"] = Class18.smethod_0(Class12.string_0);
				nameValueCollection["session_id"] = Class8.string_4;
				nameValueCollection["api_id"] = Class8.String_3;
				nameValueCollection["api_key"] = Class8.String_2;
				nameValueCollection["username"] = Class18.smethod_0(string_0);
				nameValueCollection["password"] = Class18.smethod_0(string_1);
				nameValueCollection["hwid"] = Class18.smethod_0(Class8.smethod_1());
				nameValueCollection["session_key"] = Class8.string_5;
				nameValueCollection["secret"] = Class18.smethod_0(Class12.string_1);
				nameValueCollection["type"] = Class18.smethod_0("login");
				array = Class18.smethod_2(@default.GetString(webClient2.UploadValues(string_2, nameValueCollection))).Split("|".ToCharArray());
				if (array[0] != Class8.String_0)
				{
					MessageBox.Show("Security error has been triggered!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
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
				string text = array[2];
				if (text == "success")
				{
					Class10.String_0 = array[3];
					Class10.String_1 = array[4];
					Class10.String_2 = array[5];
					Class10.String_3 = array[6];
					Class10.String_4 = array[7];
					Class10.String_6 = array[8];
					Class10.String_7 = array[9];
					Class10.String_5 = array[10];
					Class10.String_8 = array[11];
					Class10.String_9 = array[12];
					Class10.String_10 = array[13];
					string[] array2 = array[14].Split(new char[] { '~' });
					for (int i = 0; i < array2.Length; i++)
					{
						string[] array3 = array2[i].Split(new char[] { '^' });
						try
						{
							Class7.dictionary_0.Add(array3[0], array3[1]);
						}
						catch
						{
						}
					}
					Class14.smethod_4();
					return true;
				}
				if (text == "invalid_details")
				{
					MessageBox.Show("Username/password non trovati!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					return false;
				}
				if (text == "time_expired")
				{
					MessageBox.Show("La tua key è scaduta!!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
				if (text == "hwid_updated")
				{
					MessageBox.Show("La tua nuova macchina è stata settata, per favore riapri l'applicazione!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Asterisk);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
				if (text == "invalid_hwid")
				{
					MessageBox.Show("Questo utente è gia collegato ad un altro computer, per favore contatta il supporto!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Class14.smethod_4();
				Process.GetCurrentProcess().Kill();
			}
			flag = false;
		}
		return flag;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000074F8 File Offset: 0x000056F8
	public static bool smethod_6(string string_0, string string_1, string string_2, string string_3)
	{
		if (!Class8.bool_2)
		{
			MessageBox.Show("Please initialize your application first!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Class14.smethod_4();
			Process.GetCurrentProcess().Kill();
		}
		if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1) || string.IsNullOrWhiteSpace(string_2) || string.IsNullOrWhiteSpace(string_3))
		{
			MessageBox.Show("Invalid registrar information!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		bool flag;
		using (WebClient webClient = new WebClient())
		{
			try
			{
				Class14.smethod_3();
				webClient.Proxy = null;
				Encoding @default = Encoding.Default;
				WebClient webClient2 = webClient;
				string string_4 = Class8.string_6;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["token"] = Class18.smethod_1(Class8.String_0);
				nameValueCollection["timestamp"] = Class18.smethod_1(DateTime.Now.ToString());
				nameValueCollection["aid"] = Class18.smethod_0(Class12.string_0);
				nameValueCollection["session_id"] = Class8.string_4;
				nameValueCollection["api_id"] = Class8.String_3;
				nameValueCollection["api_key"] = Class8.String_2;
				nameValueCollection["session_key"] = Class8.string_5;
				nameValueCollection["secret"] = Class18.smethod_0(Class12.string_1);
				nameValueCollection["type"] = Class18.smethod_0("register");
				nameValueCollection["username"] = Class18.smethod_0(string_0);
				nameValueCollection["password"] = Class18.smethod_0(string_1);
				nameValueCollection["email"] = Class18.smethod_0(string_2);
				nameValueCollection["license"] = Class18.smethod_0(string_3);
				nameValueCollection["hwid"] = Class18.smethod_0(Class8.smethod_1());
				string[] array = Class18.smethod_2(@default.GetString(webClient2.UploadValues(string_4, nameValueCollection))).Split("|".ToCharArray());
				if (array[0] != Class8.String_0)
				{
					MessageBox.Show("Security error has been triggered!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
				}
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
				string text = array[2];
				if (text == "success")
				{
					Class14.smethod_4();
					return true;
				}
				if (text == "invalid_license")
				{
					MessageBox.Show("License does not exist!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
				if (text == "email_used")
				{
					MessageBox.Show("Email has already been used!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
				if (text == "invalid_username")
				{
					MessageBox.Show("You entered an invalid/used username!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			flag = false;
		}
		return flag;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00007844 File Offset: 0x00005A44
	public static bool smethod_7(string string_0, string string_1, string string_2)
	{
		if (!Class8.bool_2)
		{
			MessageBox.Show("Please initialize your application first!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
			Class14.smethod_4();
			Process.GetCurrentProcess().Kill();
		}
		if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1) || string.IsNullOrWhiteSpace(string_2))
		{
			MessageBox.Show("Invalid registrar information!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		bool flag;
		using (WebClient webClient = new WebClient())
		{
			try
			{
				Class14.smethod_3();
				webClient.Proxy = null;
				Encoding @default = Encoding.Default;
				WebClient webClient2 = webClient;
				string string_3 = Class8.string_6;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["token"] = Class18.smethod_1(Class8.String_0);
				nameValueCollection["timestamp"] = Class18.smethod_1(DateTime.Now.ToString());
				nameValueCollection["aid"] = Class18.smethod_0(Class12.string_0);
				nameValueCollection["session_id"] = Class8.string_4;
				nameValueCollection["api_id"] = Class8.String_3;
				nameValueCollection["api_key"] = Class8.String_2;
				nameValueCollection["session_key"] = Class8.string_5;
				nameValueCollection["secret"] = Class18.smethod_0(Class12.string_1);
				nameValueCollection["type"] = Class18.smethod_0("extend");
				nameValueCollection["username"] = Class18.smethod_0(string_0);
				nameValueCollection["password"] = Class18.smethod_0(string_1);
				nameValueCollection["license"] = Class18.smethod_0(string_2);
				string[] array = Class18.smethod_2(@default.GetString(webClient2.UploadValues(string_3, nameValueCollection))).Split("|".ToCharArray());
				if (array[0] != Class8.String_0)
				{
					MessageBox.Show("Security error has been triggered!", Class12.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
				}
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
				string text = array[2];
				if (text == "success")
				{
					Class14.smethod_4();
					return true;
				}
				if (text == "invalid_token")
				{
					MessageBox.Show("Token does not exist!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
				if (text == "invalid_details")
				{
					MessageBox.Show("Your user details are invalid!", Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class14.smethod_4();
					Process.GetCurrentProcess().Kill();
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Class11.String_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			flag = false;
		}
		return flag;
	}
}
