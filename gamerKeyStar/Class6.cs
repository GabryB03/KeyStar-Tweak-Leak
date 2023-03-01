using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200000E RID: 14
[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Class6
{
	// Token: 0x0600005A RID: 90 RVA: 0x0000228D File Offset: 0x0000048D
	internal Class6()
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600005B RID: 91 RVA: 0x0000255B File Offset: 0x0000075B
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class6.resourceManager_0 == null)
			{
				Class6.resourceManager_0 = new ResourceManager("Pg\\\\rc_V$((>Nt|pR;g:S/aM<\"", typeof(Class6).Assembly);
			}
			return Class6.resourceManager_0;
		}
	}

	// Token: 0x17000002 RID: 2
	// (set) Token: 0x0600005C RID: 92 RVA: 0x00002587 File Offset: 0x00000787
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		set
		{
			Class6.cultureInfo_0 = value;
		}
	}

	// Token: 0x0400004B RID: 75
	private static ResourceManager resourceManager_0;

	// Token: 0x0400004C RID: 76
	private static CultureInfo cultureInfo_0;
}
