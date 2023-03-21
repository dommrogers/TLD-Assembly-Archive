using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class MultiplePermissionsCheckResultListPlugin
{
	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern IntPtr MultiplePermissionsCheckResultList_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint MultiplePermissionsCheckResultList_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void MultiplePermissionsCheckResultList_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MultiplePermissionsCheckResultListPlugin()
	{
	}
}
