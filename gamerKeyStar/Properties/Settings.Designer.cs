using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace gamerKeyStar.Properties
{
	// Token: 0x0200000F RID: 15
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000258F File Offset: 0x0000078F
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002596 File Offset: 0x00000796
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000025A8 File Offset: 0x000007A8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string username
		{
			get
			{
				return (string)this["username"];
			}
			set
			{
				this["username"] = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000025B6 File Offset: 0x000007B6
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000025C8 File Offset: 0x000007C8
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string password
		{
			get
			{
				return (string)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		// Token: 0x0400004D RID: 77
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
