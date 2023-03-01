using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002210 File Offset: 0x00000410
	static <Module>()
	{
		<Module>.smethod_4();
		<Module>.smethod_2();
		<Module>.smethod_0();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002930 File Offset: 0x00000B30
	private static void smethod_0()
	{
		string text = "COR";
		Type typeFromHandle = typeof(Environment);
		MethodInfo method = typeFromHandle.GetMethod("GetEnvironmentVariable", new Type[] { typeof(string) });
		if (method != null && "1".Equals(method.Invoke(null, new object[] { text + "_ENABLE_PROFILING" })))
		{
			Environment.FailFast(null);
		}
		new Thread(new ParameterizedThreadStart(<Module>.smethod_1))
		{
			IsBackground = true
		}.Start(null);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000029C8 File Offset: 0x00000BC8
	private static void smethod_1(object object_0)
	{
		Thread thread = object_0 as Thread;
		if (thread == null)
		{
			thread = new Thread(new ParameterizedThreadStart(<Module>.smethod_1));
			thread.IsBackground = true;
			thread.Start(Thread.CurrentThread);
			Thread.Sleep(500);
		}
		for (;;)
		{
			if (Debugger.IsAttached)
			{
				goto IL_3A;
			}
			if (Debugger.IsLogging())
			{
				goto IL_3A;
			}
			IL_40:
			if (!thread.IsAlive)
			{
				Environment.FailFast(null);
			}
			Thread.Sleep(1000);
			continue;
			IL_3A:
			Environment.FailFast(null);
			goto IL_40;
		}
	}

	// Token: 0x06000004 RID: 4
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	// Token: 0x06000005 RID: 5 RVA: 0x00002A40 File Offset: 0x00000C40
	internal unsafe static void smethod_2()
	{
		Module module = typeof(<Module>).Module;
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + 60;
		ptr2 = ptr + *(uint*)ptr2;
		ptr2 += 6;
		ushort num = *(ushort*)ptr2;
		ptr2 += 14;
		ushort num2 = *(ushort*)ptr2;
		ptr2 = ptr2 + 4 + num2;
		byte* ptr3 = stackalloc byte[(UIntPtr)11];
		uint num3;
		if (module.FullyQualifiedName[0] != '<')
		{
			byte* ptr4 = ptr + *(uint*)(ptr2 - 16);
			if (*(uint*)(ptr2 - 120) != 0U)
			{
				byte* ptr5 = ptr + *(uint*)(ptr2 - 120);
				byte* ptr6 = ptr + *(uint*)ptr5;
				byte* ptr7 = ptr + *(uint*)(ptr5 + 12);
				byte* ptr8 = ptr + *(uint*)ptr6 + 2;
				<Module>.VirtualProtect(ptr7, 11, 64U, ref num3);
				*(int*)ptr3 = 1818522734;
				*(int*)(ptr3 + 4) = 1818504812;
				*(short*)(ptr3 + 8) = 108;
				ptr3[10] = 0;
				for (int i = 0; i < 11; i++)
				{
					ptr7[i] = ptr3[i];
				}
				<Module>.VirtualProtect(ptr8, 11, 64U, ref num3);
				*(int*)ptr3 = 1866691662;
				*(int*)(ptr3 + 4) = 1852404846;
				*(short*)(ptr3 + 8) = 25973;
				ptr3[10] = 0;
				for (int j = 0; j < 11; j++)
				{
					ptr8[j] = ptr3[j];
				}
			}
			for (int k = 0; k < (int)num; k++)
			{
				<Module>.VirtualProtect(ptr2, 8, 64U, ref num3);
				Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
				ptr2 += 40;
			}
			<Module>.VirtualProtect(ptr4, 72, 64U, ref num3);
			byte* ptr9 = ptr + *(uint*)(ptr4 + 8);
			*(int*)ptr4 = 0;
			*(int*)(ptr4 + 4) = 0;
			*(int*)(ptr4 + 8) = 0;
			*(int*)(ptr4 + 12) = 0;
			<Module>.VirtualProtect(ptr9, 4, 64U, ref num3);
			*(int*)ptr9 = 0;
			ptr9 += 12;
			ptr9 += *(uint*)ptr9;
			ptr9 = (ptr9 + 7L) & -4L;
			ptr9 += 2;
			ushort num4 = (ushort)(*ptr9);
			ptr9 += 2;
			for (int l = 0; l < (int)num4; l++)
			{
				<Module>.VirtualProtect(ptr9, 8, 64U, ref num3);
				ptr9 += 4;
				ptr9 += 4;
				for (int m = 0; m < 8; m++)
				{
					<Module>.VirtualProtect(ptr9, 4, 64U, ref num3);
					*ptr9 = 0;
					ptr9++;
					if (*ptr9 == 0)
					{
						ptr9 += 3;
						break;
					}
					*ptr9 = 0;
					ptr9++;
					if (*ptr9 == 0)
					{
						ptr9 += 2;
						break;
					}
					*ptr9 = 0;
					ptr9++;
					if (*ptr9 == 0)
					{
						ptr9++;
						break;
					}
					*ptr9 = 0;
					ptr9++;
				}
			}
			return;
		}
		uint num5 = *(uint*)(ptr2 - 16);
		uint num6 = *(uint*)(ptr2 - 120);
		uint[] array = new uint[(int)num];
		uint[] array2 = new uint[(int)num];
		uint[] array3 = new uint[(int)num];
		for (int n = 0; n < (int)num; n++)
		{
			<Module>.VirtualProtect(ptr2, 8, 64U, ref num3);
			Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
			array[n] = *(uint*)(ptr2 + 12);
			array2[n] = *(uint*)(ptr2 + 8);
			array3[n] = *(uint*)(ptr2 + 20);
			ptr2 += 40;
		}
		if (num6 != 0U)
		{
			for (int num7 = 0; num7 < (int)num; num7++)
			{
				if (array[num7] <= num6 && num6 < array[num7] + array2[num7])
				{
					num6 = num6 - array[num7] + array3[num7];
					IL_34E:
					byte* ptr10 = ptr + num6;
					uint num8 = *(uint*)ptr10;
					for (int num9 = 0; num9 < (int)num; num9++)
					{
						if (array[num9] <= num8 && num8 < array[num9] + array2[num9])
						{
							num8 = num8 - array[num9] + array3[num9];
							break;
						}
					}
					byte* ptr11 = ptr + num8;
					uint num10 = *(uint*)(ptr10 + 12);
					for (int num11 = 0; num11 < (int)num; num11++)
					{
						if (array[num11] <= num10 && num10 < array[num11] + array2[num11])
						{
							num10 = num10 - array[num11] + array3[num11];
							break;
						}
					}
					uint num12 = *(uint*)ptr11 + 2U;
					for (int num13 = 0; num13 < (int)num; num13++)
					{
						if (array[num13] <= num12 && num12 < array[num13] + array2[num13])
						{
							num12 = num12 - array[num13] + array3[num13];
							break;
						}
					}
					<Module>.VirtualProtect(ptr + num10, 11, 64U, ref num3);
					*(int*)ptr3 = 1818522734;
					*(int*)(ptr3 + 4) = 1818504812;
					*(short*)(ptr3 + 8) = 108;
					ptr3[10] = 0;
					for (int num14 = 0; num14 < 11; num14++)
					{
						(ptr + num10)[num14] = ptr3[num14];
					}
					<Module>.VirtualProtect(ptr + num12, 11, 64U, ref num3);
					*(int*)ptr3 = 1866691662;
					*(int*)(ptr3 + 4) = 1852404846;
					*(short*)(ptr3 + 8) = 25973;
					ptr3[10] = 0;
					for (int num15 = 0; num15 < 11; num15++)
					{
						(ptr + num12)[num15] = ptr3[num15];
					}
					goto IL_4C4;
				}
			}
			goto IL_34E;
		}
		IL_4C4:
		for (int num16 = 0; num16 < (int)num; num16++)
		{
			if (array[num16] <= num5 && num5 < array[num16] + array2[num16])
			{
				num5 = num5 - array[num16] + array3[num16];
				IL_4FE:
				byte* ptr12 = ptr + num5;
				<Module>.VirtualProtect(ptr12, 72, 64U, ref num3);
				uint num17 = *(uint*)(ptr12 + 8);
				for (int num18 = 0; num18 < (int)num; num18++)
				{
					if (array[num18] <= num17 && num17 < array[num18] + array2[num18])
					{
						num17 = num17 - array[num18] + array3[num18];
						IL_554:
						*(int*)ptr12 = 0;
						*(int*)(ptr12 + 4) = 0;
						*(int*)(ptr12 + 8) = 0;
						*(int*)(ptr12 + 12) = 0;
						byte* ptr13 = ptr + num17;
						<Module>.VirtualProtect(ptr13, 4, 64U, ref num3);
						*(int*)ptr13 = 0;
						ptr13 += 12;
						ptr13 += *(uint*)ptr13;
						ptr13 = (ptr13 + 7L) & -4L;
						ptr13 += 2;
						ushort num19 = (ushort)(*ptr13);
						ptr13 += 2;
						for (int num20 = 0; num20 < (int)num19; num20++)
						{
							<Module>.VirtualProtect(ptr13, 8, 64U, ref num3);
							ptr13 += 4;
							ptr13 += 4;
							for (int num21 = 0; num21 < 8; num21++)
							{
								<Module>.VirtualProtect(ptr13, 4, 64U, ref num3);
								*ptr13 = 0;
								ptr13++;
								if (*ptr13 == 0)
								{
									ptr13 += 3;
									break;
								}
								*ptr13 = 0;
								ptr13++;
								if (*ptr13 == 0)
								{
									ptr13 += 2;
									break;
								}
								*ptr13 = 0;
								ptr13++;
								if (*ptr13 == 0)
								{
									ptr13++;
									break;
								}
								*ptr13 = 0;
								ptr13++;
							}
						}
						return;
					}
				}
				goto IL_554;
			}
		}
		goto IL_4FE;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000030B4 File Offset: 0x000012B4
	internal static byte[] smethod_3(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		<Module>.Class1 @class = new <Module>.Class1();
		byte[] array = new byte[5];
		memoryStream.Read(array, 0, 5);
		@class.method_5(array);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array2 = new byte[(int)num];
		MemoryStream memoryStream2 = new MemoryStream(array2, true);
		long num3 = memoryStream.Length - 13L;
		@class.method_4(memoryStream, memoryStream2, num3, num);
		return array2;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000314C File Offset: 0x0000134C
	internal static void smethod_4()
	{
		uint num = 112U;
		uint[] array = new uint[]
		{
			2858139106U, 3999068031U, 3193806271U, 2390650704U, 693689626U, 660386741U, 413288819U, 2333995129U, 28253131U, 3780705120U,
			1183952449U, 3165023116U, 198963708U, 505648822U, 4273060338U, 2457846114U, 3986584211U, 3434555220U, 1142711290U, 4243666659U,
			1188615198U, 3791839119U, 2961067047U, 3608666462U, 3103691860U, 3232276188U, 528201567U, 1096387994U, 3549818702U, 3775395586U,
			2769685788U, 3710226244U, 2312685253U, 402331157U, 880662265U, 3889078403U, 727881511U, 464562117U, 652179205U, 852341390U,
			3404053882U, 3564207893U, 1877265164U, 329316314U, 1197128477U, 1495144049U, 2880954851U, 999471421U, 1182082459U, 3467637354U,
			1635996474U, 2536974381U, 454181918U, 3014784771U, 1814757198U, 476001273U, 1755714167U, 1655450241U, 1702735029U, 3826914084U,
			251824862U, 2323345524U, 171897065U, 407568064U, 110029592U, 3498987228U, 2129946185U, 2978571264U, 2789623767U, 2730899495U,
			2821290691U, 1791449669U, 2744677203U, 4138692906U, 3244994792U, 1419941878U, 520525806U, 3111198775U, 3367934482U, 202422501U,
			1597229304U, 434552852U, 897501670U, 745130092U, 1033063417U, 387549237U, 2358613105U, 1760017049U, 2165793542U, 2318907035U,
			2722030349U, 1467444399U, 1385722924U, 3160573757U, 921091037U, 2183764062U, 2324439126U, 1930260256U, 1008055696U, 4057212186U,
			2866655559U, 509428449U, 2358613003U, 1760017049U, 2165793542U, 2318907035U, 2722030349U, 1467444399U, 1385722924U, 3160573757U,
			921091037U, 2183764062U
		};
		uint[] array2 = new uint[16];
		uint num2 = 1582911344U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 13;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = array3[0] ^ array2[0];
			array3[1] = array3[1] ^ array2[1];
			array3[2] = array3[2] ^ array2[2];
			array3[3] = array3[3] ^ array2[3];
			array3[4] = array3[4] ^ array2[4];
			array3[5] = array3[5] ^ array2[5];
			array3[6] = array3[6] ^ array2[6];
			array3[7] = array3[7] ^ array2[7];
			array3[8] = array3[8] ^ array2[8];
			array3[9] = array3[9] ^ array2[9];
			array3[10] = array3[10] ^ array2[10];
			array3[11] = array3[11] ^ array2[11];
			array3[12] = array3[12] ^ array2[12];
			array3[13] = array3[13] ^ array2[13];
			array3[14] = array3[14] ^ array2[14];
			array3[15] = array3[15] ^ array2[15];
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.assembly_0 = Assembly.Load(<Module>.smethod_3(array4));
		AppDomain.CurrentDomain.ResourceResolve += <Module>.smethod_5;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00003364 File Offset: 0x00001564
	internal static Assembly smethod_5(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string[] manifestResourceNames = <Module>.assembly_0.GetManifestResourceNames();
		if (Array.IndexOf<string>(manifestResourceNames, resolveEventArgs_0.Name) == -1)
		{
			return null;
		}
		return <Module>.assembly_0;
	}

	// Token: 0x06000009 RID: 9
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_0, uint uint_1, ref uint uint_2);

	// Token: 0x0600000A RID: 10 RVA: 0x00003394 File Offset: 0x00001594
	internal unsafe static void smethod_6()
	{
		Module module = typeof(<Module>).Module;
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + *(uint*)(ptr + 60);
		ushort num = *(ushort*)(ptr2 + 6);
		ushort num2 = *(ushort*)(ptr2 + 20);
		uint* ptr3 = null;
		uint num3 = 0U;
		uint* ptr4 = (uint*)(ptr2 + 24 + num2);
		uint num4 = 3715498512U;
		uint num5 = 2434762473U;
		uint num6 = 1349917719U;
		uint num7 = 1835405946U;
		for (int i = 0; i < (int)num; i++)
		{
			uint num8 = *(ptr4++) * *(ptr4++);
			if (num8 != 1983922824U)
			{
				if (num8 != 0U)
				{
					uint* ptr5 = (uint*)(ptr + (flag ? ptr4[3] : ptr4[1]) / 4U);
					uint num9 = ptr4[2] >> 2;
					for (uint num10 = 0U; num10 < num9; num10 += 1U)
					{
						uint num11 = (num4 ^ *(ptr5++)) + num5 + num6 * num7;
						num4 = num5;
						num5 = num7;
						num7 = num11;
					}
				}
			}
			else
			{
				ptr3 = (uint*)(ptr + (flag ? ptr4[3] : ptr4[1]) / 4U);
				num3 = (flag ? ptr4[2] : (*ptr4)) >> 2;
			}
			ptr4 += 8;
		}
		uint[] array = new uint[16];
		uint[] array2 = new uint[16];
		for (int j = 0; j < 16; j++)
		{
			array[j] = num7;
			array2[j] = num5;
			num4 = (num5 >> 5) | (num5 << 27);
			num5 = (num6 >> 3) | (num6 << 29);
			num6 = (num7 >> 7) | (num7 << 25);
			num7 = (num4 >> 11) | (num4 << 21);
		}
		array[0] = array[0] ^ array2[0];
		array[1] = array[1] * array2[1];
		array[2] = array[2] + array2[2];
		array[3] = array[3] ^ array2[3];
		array[4] = array[4] * array2[4];
		array[5] = array[5] + array2[5];
		array[6] = array[6] ^ array2[6];
		array[7] = array[7] * array2[7];
		array[8] = array[8] + array2[8];
		array[9] = array[9] ^ array2[9];
		array[10] = array[10] * array2[10];
		array[11] = array[11] + array2[11];
		array[12] = array[12] ^ array2[12];
		array[13] = array[13] * array2[13];
		array[14] = array[14] + array2[14];
		array[15] = array[15] ^ array2[15];
		uint num12 = 64U;
		<Module>.VirtualProtect_1((IntPtr)((void*)ptr3), num3 << 2, 64U, ref num12);
		if (num12 == 64U)
		{
			return;
		}
		uint num13 = 0U;
		for (uint num14 = 0U; num14 < num3; num14 += 1U)
		{
			*ptr3 ^= array[(int)((UIntPtr)(num13 & 15U))];
			array[(int)((UIntPtr)(num13 & 15U))] = (array[(int)((UIntPtr)(num13 & 15U))] ^ *(ptr3++)) + 1035675673U;
			num13 += 1U;
		}
	}

	// Token: 0x04000001 RID: 1
	internal static Assembly assembly_0;

	// Token: 0x04000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.Struct4 struct4_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002222 File Offset: 0x00000422
		internal void method_0()
		{
			this.uint_0 = 1024U;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000036A0 File Offset: 0x000018A0
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = (class0_0.uint_1 >> 11) * this.uint_0;
			if (class0_0.uint_0 < num)
			{
				class0_0.uint_1 = num;
				this.uint_0 += 2048U - this.uint_0 >> 5;
				if (class0_0.uint_1 < 16777216U)
				{
					class0_0.uint_0 = (class0_0.uint_0 << 8) | (uint)((byte)class0_0.stream_0.ReadByte());
					class0_0.uint_1 <<= 8;
				}
				return 0U;
			}
			class0_0.uint_1 -= num;
			class0_0.uint_0 -= num;
			this.uint_0 -= this.uint_0 >> 5;
			if (class0_0.uint_1 < 16777216U)
			{
				class0_0.uint_0 = (class0_0.uint_0 << 8) | (uint)((byte)class0_0.stream_0.ReadByte());
				class0_0.uint_1 <<= 8;
			}
			return 1U;
		}

		// Token: 0x04000003 RID: 3
		internal uint uint_0;
	}

	// Token: 0x02000003 RID: 3
	internal struct Struct1
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000222F File Offset: 0x0000042F
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000378C File Offset: 0x0000198C
		internal void method_0()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)((UIntPtr)num)].method_0();
				num += 1U;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000037C4 File Offset: 0x000019C4
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
			}
			return num - (1U << this.int_0);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000380C File Offset: 0x00001A0C
		internal uint method_2(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003854 File Offset: 0x00001A54
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class0 class0_0, int int_1)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)((UIntPtr)(uint_0 + num))].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000004 RID: 4
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x04000005 RID: 5
		internal readonly int int_0;
	}

	// Token: 0x02000004 RID: 4
	internal class Class0
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00003894 File Offset: 0x00001A94
		internal void method_0(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0U;
			this.uint_1 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8) | (uint)((byte)this.stream_0.ReadByte());
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002249 File Offset: 0x00000449
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002252 File Offset: 0x00000452
		internal void method_2()
		{
			while (this.uint_1 < 16777216U)
			{
				this.uint_0 = (this.uint_0 << 8) | (uint)((byte)this.stream_0.ReadByte());
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000038E0 File Offset: 0x00001AE0
		internal uint method_3(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0U;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= num & (num4 - 1U);
				num3 = (num3 << 1) | (1U - num4);
				if (num < 16777216U)
				{
					num2 = (num2 << 8) | (uint)((byte)this.stream_0.ReadByte());
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000228D File Offset: 0x0000048D
		internal Class0()
		{
		}

		// Token: 0x04000006 RID: 6
		internal uint uint_0;

		// Token: 0x04000007 RID: 7
		internal uint uint_1;

		// Token: 0x04000008 RID: 8
		internal Stream stream_0;
	}

	// Token: 0x02000005 RID: 5
	internal class Class1
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003954 File Offset: 0x00001B54
		internal Class1()
		{
			this.uint_0 = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_0[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003A54 File Offset: 0x00001C54
		internal void method_0(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1U);
				uint num = Math.Max(this.uint_1, 4096U);
				this.class4_0.method_0(num);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002295 File Offset: 0x00000495
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003AA0 File Offset: 0x00001CA0
		internal void method_2(int int_0)
		{
			uint num = 1U << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1U;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003AD8 File Offset: 0x00001CD8
		internal void method_3(Stream stream_0, Stream stream_1)
		{
			this.class0_0.method_0(stream_0);
			this.class4_0.method_1(stream_1, this.bool_0);
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this.uint_2; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this.struct0_0[(int)((UIntPtr)num3)].method_0();
					this.struct0_1[(int)((UIntPtr)num3)].method_0();
				}
				this.struct0_2[(int)((UIntPtr)num)].method_0();
				this.struct0_3[(int)((UIntPtr)num)].method_0();
				this.struct0_4[(int)((UIntPtr)num)].method_0();
				this.struct0_5[(int)((UIntPtr)num)].method_0();
			}
			this.class3_0.method_1();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this.struct1_0[(int)((UIntPtr)num)].method_0();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this.struct0_6[(int)((UIntPtr)num)].method_0();
			}
			this.class2_0.method_1();
			this.class2_1.method_1();
			this.struct1_1.method_0();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003C04 File Offset: 0x00001E04
		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_3(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((UIntPtr)(@struct.uint_0 << 4))].method_1(this.class0_0);
				@struct.method_1();
				byte b = this.class3_0.method_3(this.class0_0, 0U, 0);
				this.class4_0.method_5(b);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class0_0) == 0U)
				{
					byte b2 = this.class4_0.method_6(0U);
					byte b3;
					if (!@struct.method_5())
					{
						b3 = this.class3_0.method_4(this.class0_0, (uint)num5, b2, this.class4_0.method_6(num));
					}
					else
					{
						b3 = this.class3_0.method_3(this.class0_0, (uint)num5, b2);
					}
					this.class4_0.method_5(b3);
					@struct.method_1();
					num5 += 1UL;
				}
				else
				{
					uint num7;
					if (this.struct0_2[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) != 1U)
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num7 = 2U + this.class2_0.method_2(this.class0_0, num6);
						@struct.method_2();
						uint num8 = this.struct1_0[(int)((UIntPtr)<Module>.Class1.smethod_0(num7))].method_1(this.class0_0);
						if (num8 < 4U)
						{
							num = num8;
						}
						else
						{
							int num9 = (int)((num8 >> 1) - 1U);
							num = (2U | (num8 & 1U)) << num9;
							if (num8 < 14U)
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num8 - 1U, this.class0_0, num9);
							}
							else
							{
								num += this.class0_0.method_3(num9 - 4) << 4;
								num += this.struct1_1.method_2(this.class0_0);
							}
						}
					}
					else
					{
						if (this.struct0_3[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 0U)
						{
							if (this.struct0_1[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class0_0) == 0U)
							{
								@struct.method_4();
								this.class4_0.method_5(this.class4_0.method_6(num));
								num5 += 1UL;
								continue;
							}
						}
						else
						{
							uint num10;
							if (this.struct0_4[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) != 0U)
							{
								if (this.struct0_5[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 0U)
								{
									num10 = num3;
								}
								else
								{
									num10 = num4;
									num4 = num3;
								}
								num3 = num2;
							}
							else
							{
								num10 = num2;
							}
							num2 = num;
							num = num10;
						}
						num7 = this.class2_1.method_2(this.class0_0, num6) + 2U;
						@struct.method_3();
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295U)
					{
						break;
					}
					this.class4_0.method_4(num, num7);
					num5 += (ulong)num7;
				}
			}
			this.class4_0.method_3();
			this.class4_0.method_2();
			this.class0_0.method_1();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003F80 File Offset: 0x00002180
		internal void method_5(byte[] byte_0)
		{
			int num = (int)(byte_0[0] % 9);
			int num2 = (int)(byte_0[0] / 9);
			int num3 = num2 % 5;
			int num4 = num2 / 5;
			uint num5 = 0U;
			for (int i = 0; i < 4; i++)
			{
				num5 += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_0(num5);
			this.method_1(num3, num);
			this.method_2(num4);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022A4 File Offset: 0x000004A4
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2U;
			if (uint_3 >= 4U)
			{
				return 3U;
			}
			return uint_3;
		}

		// Token: 0x04000009 RID: 9
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x0400000A RID: 10
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Class1.Class2 class2_0 = new <Module>.Class1.Class2();

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Class1.Class3 class3_0 = new <Module>.Class1.Class3();

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Class4 class4_0 = new <Module>.Class4();

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[4];

		// Token: 0x04000014 RID: 20
		internal readonly <Module>.Class0 class0_0 = new <Module>.Class0();

		// Token: 0x04000015 RID: 21
		internal readonly <Module>.Class1.Class2 class2_1 = new <Module>.Class1.Class2();

		// Token: 0x04000016 RID: 22
		internal bool bool_0;

		// Token: 0x04000017 RID: 23
		internal uint uint_0;

		// Token: 0x04000018 RID: 24
		internal uint uint_1;

		// Token: 0x04000019 RID: 25
		internal <Module>.Struct1 struct1_1 = new <Module>.Struct1(4);

		// Token: 0x0400001A RID: 26
		internal uint uint_2;

		// Token: 0x02000006 RID: 6
		internal class Class2
		{
			// Token: 0x0600001F RID: 31 RVA: 0x00003FE0 File Offset: 0x000021E0
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1U)
				{
					this.struct1_0[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
					this.struct1_1[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00004038 File Offset: 0x00002238
			internal void method_1()
			{
				this.struct0_0.method_0();
				for (uint num = 0U; num < this.uint_0; num += 1U)
				{
					this.struct1_0[(int)((UIntPtr)num)].method_0();
					this.struct1_1[(int)((UIntPtr)num)].method_0();
				}
				this.struct0_1.method_0();
				this.struct1_2.method_0();
			}

			// Token: 0x06000021 RID: 33 RVA: 0x0000409C File Offset: 0x0000229C
			internal uint method_2(<Module>.Class0 class0_0, uint uint_1)
			{
				if (this.struct0_0.method_1(class0_0) == 0U)
				{
					return this.struct1_0[(int)((UIntPtr)uint_1)].method_1(class0_0);
				}
				uint num = 8U;
				if (this.struct0_1.method_1(class0_0) == 0U)
				{
					num += this.struct1_1[(int)((UIntPtr)uint_1)].method_1(class0_0);
				}
				else
				{
					num += 8U;
					num += this.struct1_2.method_1(class0_0);
				}
				return num;
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00004108 File Offset: 0x00002308
			internal Class2()
			{
			}

			// Token: 0x0400001B RID: 27
			internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[16];

			// Token: 0x0400001C RID: 28
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x0400001D RID: 29
			internal <Module>.Struct0 struct0_0 = default(<Module>.Struct0);

			// Token: 0x0400001E RID: 30
			internal <Module>.Struct0 struct0_1 = default(<Module>.Struct0);

			// Token: 0x0400001F RID: 31
			internal <Module>.Struct1 struct1_2 = new <Module>.Struct1(8);

			// Token: 0x04000020 RID: 32
			internal uint uint_0;
		}

		// Token: 0x02000007 RID: 7
		internal class Class3
		{
			// Token: 0x06000023 RID: 35 RVA: 0x0000415C File Offset: 0x0000235C
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null && this.int_1 == int_3)
				{
					if (this.int_0 == int_2)
					{
						return;
					}
				}
				this.int_0 = int_2;
				this.uint_0 = (1U << int_2) - 1U;
				this.int_1 = int_3;
				uint num = 1U << this.int_1 + this.int_0;
				this.struct2_0 = new <Module>.Class1.Class3.Struct2[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_0();
				}
			}

			// Token: 0x06000024 RID: 36 RVA: 0x000041E0 File Offset: 0x000023E0
			internal void method_1()
			{
				uint num = 1U << this.int_1 + this.int_0;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_1();
				}
			}

			// Token: 0x06000025 RID: 37 RVA: 0x000022B2 File Offset: 0x000004B2
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x06000026 RID: 38 RVA: 0x000022D4 File Offset: 0x000004D4
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_2(class0_0);
			}

			// Token: 0x06000027 RID: 39 RVA: 0x000022F0 File Offset: 0x000004F0
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_3(class0_0, byte_1);
			}

			// Token: 0x06000028 RID: 40 RVA: 0x0000228D File Offset: 0x0000048D
			internal Class3()
			{
			}

			// Token: 0x04000021 RID: 33
			internal <Module>.Class1.Class3.Struct2[] struct2_0;

			// Token: 0x04000022 RID: 34
			internal int int_0;

			// Token: 0x04000023 RID: 35
			internal int int_1;

			// Token: 0x04000024 RID: 36
			internal uint uint_0;

			// Token: 0x02000008 RID: 8
			internal struct Struct2
			{
				// Token: 0x06000029 RID: 41 RVA: 0x0000230E File Offset: 0x0000050E
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x0600002A RID: 42 RVA: 0x00004220 File Offset: 0x00002420
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x0600002B RID: 43 RVA: 0x00004250 File Offset: 0x00002450
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 1U;
					do
					{
						num = (num << 1) | this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
					}
					while (num < 256U);
					return (byte)num;
				}

				// Token: 0x0600002C RID: 44 RVA: 0x00004284 File Offset: 0x00002484
				internal byte method_3(<Module>.Class0 class0_0, byte byte_0)
				{
					uint num = 1U;
					for (;;)
					{
						uint num2 = (uint)((byte_0 >> 7) & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((UIntPtr)((1U + num2 << 8) + num))].method_1(class0_0);
						num = (num << 1) | num3;
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256U)
						{
							goto IL_5E;
						}
					}
					while (num < 256U)
					{
						num = (num << 1) | this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
					}
					IL_5E:
					return (byte)num;
				}

				// Token: 0x04000025 RID: 37
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Class4
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002320 File Offset: 0x00000520
		internal void method_0(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0U;
			this.uint_1 = 0U;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000234D File Offset: 0x0000054D
		internal void method_1(Stream stream_1, bool bool_0)
		{
			this.method_2();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0U;
				this.uint_0 = 0U;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000236D File Offset: 0x0000056D
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000042F4 File Offset: 0x000024F4
		internal void method_3()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num == 0U)
			{
				return;
			}
			this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
			if (this.uint_0 >= this.uint_2)
			{
				this.uint_0 = 0U;
			}
			this.uint_1 = this.uint_0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000434C File Offset: 0x0000254C
		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0U)
			{
				if (num >= this.uint_2)
				{
					num = 0U;
				}
				this.byte_0[(int)((UIntPtr)(this.uint_0++))] = this.byte_0[(int)((UIntPtr)(num++))];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_3();
				}
				uint_4 -= 1U;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000043C8 File Offset: 0x000025C8
		internal void method_5(byte byte_1)
		{
			this.byte_0[(int)((UIntPtr)(this.uint_0++))] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004404 File Offset: 0x00002604
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)((UIntPtr)num)];
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000228D File Offset: 0x0000048D
		internal Class4()
		{
		}

		// Token: 0x04000026 RID: 38
		internal byte[] byte_0;

		// Token: 0x04000027 RID: 39
		internal uint uint_0;

		// Token: 0x04000028 RID: 40
		internal Stream stream_0;

		// Token: 0x04000029 RID: 41
		internal uint uint_1;

		// Token: 0x0400002A RID: 42
		internal uint uint_2;
	}

	// Token: 0x0200000A RID: 10
	internal struct Struct3
	{
		// Token: 0x06000035 RID: 53 RVA: 0x0000239E File Offset: 0x0000059E
		internal void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000023A7 File Offset: 0x000005A7
		internal void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 >= 10U)
			{
				this.uint_0 -= 6U;
				return;
			}
			this.uint_0 -= 3U;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000023E1 File Offset: 0x000005E1
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000023F7 File Offset: 0x000005F7
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000240D File Offset: 0x0000060D
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002424 File Offset: 0x00000624
		internal bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x0400002B RID: 43
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 448)]
	internal struct Struct4
	{
	}
}
