using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class AchievementMediaAssetPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint AchievementMediaAsset_MediaAssetType(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr AchievementMediaAsset_Name(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr AchievementMediaAsset_Url(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void AchievementMediaAsset_Dispose(IntPtr self);

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AchievementMediaAssetPlugin()
	{
	}
}
