using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class AchievementListPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr AchievementList_GetAt(IntPtr self, uint index);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint AchievementList_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void AchievementList_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AchievementListPlugin()
	{
	}
}
