using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Marketplace;

public class DLCPlugin
{
	public delegate void DownloadableContentPackageInstallCompletedCallback(IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern IntPtr DLC_FindPackages(InstalledPackagesFilter filter);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static extern bool DLC_RegisterForDLCCompletedEvent(DownloadableContentPackageInstallCompletedCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern bool DLC_UnRegisterForDLCCompletedEvent();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool DLC_RegisterForDLCCompletedWithDetailsEvent(ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool DLC_UnRegisterForDLCCompletedWithDetailsEvent();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint DLC_IDownloadableContentPackage_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void DLC_IDownloadableContentPackage_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr DLC_IDownloadableContentPackage_GetAt(IntPtr self, uint idx);

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public DLCPlugin()
	{
	}
}
