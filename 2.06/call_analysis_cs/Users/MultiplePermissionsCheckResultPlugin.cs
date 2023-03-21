using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class MultiplePermissionsCheckResultPlugin
{
	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern IntPtr MultiplePermissionsCheckResult_Items(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint MultiplePermissionsCheckResult_Items_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr MultiplePermissionsCheckResult_Items_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void MultiplePermissionsCheckResult_Items_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr MultiplePermissionsCheckResult_XboxUserId(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void MultiplePermissionsCheckResult_Dispose(IntPtr self);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public MultiplePermissionsCheckResultPlugin()
	{
	}
}
