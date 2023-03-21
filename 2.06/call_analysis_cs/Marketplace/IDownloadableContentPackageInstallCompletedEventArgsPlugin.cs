using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Marketplace;

public class IDownloadableContentPackageInstallCompletedEventArgsPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern Guid IDownloadableContentPackageInstallCompletedEventArgs_ContentId(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint IDownloadableContentPackageInstallCompletedEventArgs_OperationType(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr IDownloadableContentPackageInstallCompletedEventArgs_PackageFullName(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void IDownloadableContentPackageInstallCompletedEventArgs_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public IDownloadableContentPackageInstallCompletedEventArgsPlugin()
	{
	}
}
