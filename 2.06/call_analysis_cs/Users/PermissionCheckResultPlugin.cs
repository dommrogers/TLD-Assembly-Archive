using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class PermissionCheckResultPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr PermissionCheckResult_DenyReasons(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint PermissionCheckResult_DenyReasons_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr PermissionCheckResult_DenyReasons_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void PermissionCheckResult_DenyReasons_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int PermissionCheckResult_IsAllowed(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr PermissionCheckResult_PermissionRequested(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void PermissionCheckResult_Dispose(IntPtr self);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PermissionCheckResultPlugin()
	{
	}
}
