using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200001B RID: 27
internal class Class18
{
	// Token: 0x060000BF RID: 191 RVA: 0x00007EC4 File Offset: 0x000060C4
	public static string smethod_0(string string_0)
	{
		string @string = Encoding.Default.GetString(Convert.FromBase64String(Class8.String_2));
		byte[] array = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(@string));
		byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Class8.String_3)));
		return Class18.smethod_3(string_0, array, bytes);
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00007F24 File Offset: 0x00006124
	public static string smethod_1(string string_0)
	{
		string @string = Encoding.Default.GetString(Convert.FromBase64String(Class8.String_2));
		byte[] array = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(@string));
		byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Class8.String_3)));
		string text = Class18.smethod_3(string_0, array, bytes);
		int num = int.Parse(Class12.string_0.Substring(0, 2));
		return text + Class14.smethod_2(num);
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00007FA0 File Offset: 0x000061A0
	public static string smethod_2(string string_0)
	{
		string @string = Encoding.Default.GetString(Convert.FromBase64String(Class8.String_2));
		byte[] array = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(@string));
		byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Class8.String_3)));
		return Class18.smethod_4(string_0, array, bytes);
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00008000 File Offset: 0x00006200
	public static string smethod_3(string string_0, byte[] byte_0, byte[] byte_1)
	{
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.Key = byte_0;
		aes.IV = byte_1;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform cryptoTransform = aes.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] array = memoryStream.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(array, 0, array.Length);
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0000807C File Offset: 0x0000627C
	public static string smethod_4(string string_0, byte[] byte_0, byte[] byte_1)
	{
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.Key = byte_0;
		aes.IV = byte_1;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform cryptoTransform = aes.CreateDecryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
		string text = string.Empty;
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			text = Encoding.ASCII.GetString(array2, 0, array2.Length);
		}
		finally
		{
			memoryStream.Close();
			cryptoStream.Close();
		}
		return text;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00008118 File Offset: 0x00006318
	public static string smethod_5(string string_0)
	{
		string_0 = string_0.Replace('_', '/').Replace('-', '+');
		int num = string_0.Length % 4;
		if (num != 2)
		{
			if (num == 3)
			{
				string_0 += "=";
			}
		}
		else
		{
			string_0 += "==";
		}
		return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
	}
}
