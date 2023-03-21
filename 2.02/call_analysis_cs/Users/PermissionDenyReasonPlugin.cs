using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class PermissionDenyReasonPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr PermissionDenyReason_Reason(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr PermissionDenyReason_RestrictedSetting(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void PermissionDenyReason_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PermissionDenyReasonPlugin()
	{
	}
}
