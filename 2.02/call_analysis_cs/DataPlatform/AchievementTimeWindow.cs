using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class AchievementTimeWindow : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private DateTime m_EndDate;

	private DateTime m_StartDate;

	public DateTime EndDate
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

	public DateTime StartDate
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
	public AchievementTimeWindow(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AchievementTimeWindow()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	~AchievementTimeWindow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
