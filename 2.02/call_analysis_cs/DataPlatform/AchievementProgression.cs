using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class AchievementProgression : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private AchievementRequirementList m_Requirements;

	private DateTime m_TimeUnlocked;

	public AchievementRequirementList Requirements
	{
		[CallsUnknownMethods(Count = 9)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public DateTime TimeUnlocked
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedDateTime")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return default(DateTime);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AchievementProgression(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AchievementProgression()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	~AchievementProgression()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
