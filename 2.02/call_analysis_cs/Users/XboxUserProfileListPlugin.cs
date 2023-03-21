using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class XboxUserProfileListPlugin
{
	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint XboxUserProfileList_Length(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern IntPtr XboxUserProfileList_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void XboxUserProfileList_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public XboxUserProfileListPlugin()
	{
	}
}
