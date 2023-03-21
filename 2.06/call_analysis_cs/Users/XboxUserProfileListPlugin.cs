using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Users;

public class XboxUserProfileListPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint XboxUserProfileList_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr XboxUserProfileList_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void XboxUserProfileList_Dispose(IntPtr self);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public XboxUserProfileListPlugin()
	{
	}
}
