using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

public sealed class ModsInterface : Handle
{
	public const int CopymodinfoApiLatest = 1;

	public const int EnumeratemodsApiLatest = 1;

	public const int InstallmodApiLatest = 1;

	public const int ModIdentifierApiLatest = 1;

	public const int ModinfoApiLatest = 1;

	public const int UninstallmodApiLatest = 1;

	public const int UpdatemodApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ModsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ModsInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyModInfoOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public Result CopyModInfo(CopyModInfoOptions options, out ModInfo outEnumeratedMods)
	{
		outEnumeratedMods = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumerateModsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void EnumerateMods(EnumerateModsOptions options, object clientData, OnEnumerateModsCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstallModOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void InstallMod(InstallModOptions options, object clientData, OnInstallModCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UninstallModOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void UninstallMod(UninstallModOptions options, object clientData, OnUninstallModCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateModOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateMod(UpdateModOptions options, object clientData, OnUpdateModCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnEnumerateModsCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnInstallModCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnUninstallModCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnUpdateModCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Mods_CopyModInfo(IntPtr handle, IntPtr options, ref IntPtr outEnumeratedMods);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Mods_EnumerateMods(IntPtr handle, IntPtr options, IntPtr clientData, OnEnumerateModsCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Mods_InstallMod(IntPtr handle, IntPtr options, IntPtr clientData, OnInstallModCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Mods_ModInfo_Release(IntPtr modInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Mods_UninstallMod(IntPtr handle, IntPtr options, IntPtr clientData, OnUninstallModCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Mods_UpdateMod(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateModCallbackInternal completionDelegate);
}
