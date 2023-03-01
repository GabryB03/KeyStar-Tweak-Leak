using System;
using System.Collections.Generic;

// Token: 0x02000010 RID: 16
internal class Class7
{
	// Token: 0x06000064 RID: 100 RVA: 0x00006164 File Offset: 0x00004364
	public static string smethod_0(string string_1)
	{
		string text;
		try
		{
			if (Class10.String_0 == null && Class10.String_4 == null && Class10.String_5 == null && Class8.bool_0)
			{
				Class8.bool_0 = true;
				text = "User is not logged in, possible breach detected!";
			}
			else
			{
				text = Class7.dictionary_0[string_1];
			}
		}
		catch
		{
			text = "N/A";
		}
		return text;
	}

	// Token: 0x0400004E RID: 78
	public static string string_0 = null;

	// Token: 0x0400004F RID: 79
	public static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();
}
