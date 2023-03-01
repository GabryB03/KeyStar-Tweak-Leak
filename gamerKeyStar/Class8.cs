using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;

// Token: 0x02000011 RID: 17
internal class Class8
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000067 RID: 103 RVA: 0x00002606 File Offset: 0x00000806
	// (set) Token: 0x06000068 RID: 104 RVA: 0x0000260D File Offset: 0x0000080D
	public static string String_0 { get; set; }

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000069 RID: 105 RVA: 0x00002615 File Offset: 0x00000815
	// (set) Token: 0x0600006A RID: 106 RVA: 0x0000261C File Offset: 0x0000081C
	public static string String_1 { get; set; }

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600006B RID: 107 RVA: 0x00002624 File Offset: 0x00000824
	// (set) Token: 0x0600006C RID: 108 RVA: 0x0000262B File Offset: 0x0000082B
	public static string String_2 { get; set; }

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600006D RID: 109 RVA: 0x00002633 File Offset: 0x00000833
	// (set) Token: 0x0600006E RID: 110 RVA: 0x0000263A File Offset: 0x0000083A
	public static string String_3 { get; set; }

	// Token: 0x0600006F RID: 111 RVA: 0x00002642 File Offset: 0x00000842
	public static string smethod_0(int int_0)
	{
		return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", int_0).Select(new Func<string, char>(Class8.Class9.<>9.method_0)).ToArray<char>());
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0000267D File Offset: 0x0000087D
	public static string smethod_1()
	{
		return WindowsIdentity.GetCurrent().User.Value;
	}

	// Token: 0x04000050 RID: 80
	[CompilerGenerated]
	private static string string_0;

	// Token: 0x04000051 RID: 81
	[CompilerGenerated]
	private static string string_1;

	// Token: 0x04000052 RID: 82
	[CompilerGenerated]
	private static string string_2;

	// Token: 0x04000053 RID: 83
	[CompilerGenerated]
	private static string string_3;

	// Token: 0x04000054 RID: 84
	public static bool bool_0 = false;

	// Token: 0x04000055 RID: 85
	public static bool bool_1 = false;

	// Token: 0x04000056 RID: 86
	public static string string_4 = null;

	// Token: 0x04000057 RID: 87
	public static string string_5 = null;

	// Token: 0x04000058 RID: 88
	public static string string_6 = "https://api.auth.gg/csharp/";

	// Token: 0x04000059 RID: 89
	public static bool bool_2 = false;

	// Token: 0x0400005A RID: 90
	public static Random random_0 = new Random();

	// Token: 0x02000012 RID: 18
	[CompilerGenerated]
	[Serializable]
	private sealed class Class9
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000026CE File Offset: 0x000008CE
		internal char method_0(string string_0)
		{
			return string_0[Class8.random_0.Next(string_0.Length)];
		}

		// Token: 0x0400005B RID: 91
		public static readonly Class8.Class9 <>9 = new Class8.Class9();

		// Token: 0x0400005C RID: 92
		public static Func<string, char> <>9__23_0;
	}
}
