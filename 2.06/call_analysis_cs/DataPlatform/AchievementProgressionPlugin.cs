using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class AchievementProgressionPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr AchievementProgression_Requirements(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint AchievementProgression_Requirements_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr AchievementProgression_Requirements_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void AchievementProgression_Requirements_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern ulong AchievementProgression_TimeUnlocked(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void AchievementProgression_Dispose(IntPtr self);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public AchievementProgressionPlugin()
	{
	}
}
