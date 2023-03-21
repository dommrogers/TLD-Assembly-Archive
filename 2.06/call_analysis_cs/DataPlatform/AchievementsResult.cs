using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class AchievementsResult : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private AchievementList m_Items;

	public AchievementList Items
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool GetNextAsync(AchievementsResult res, uint maxItems, ObjectResultCallback callback, IntPtr userData)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AchievementsResult(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public AchievementsResult()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	~AchievementsResult()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
