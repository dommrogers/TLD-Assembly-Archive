using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class StatEvent : IDisposable, IWrappedObject
{
	private IntPtr m_Self;

	private string m_errorMessage;

	public int UserId
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public StatEventType EventType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StatEventPlugin), Member = "StatisticEvent_EventType")]
		get
		{
			return default(StatEventType);
		}
	}

	public int ErrorCode
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public string ErrorMessage
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public LeaderboardResultEventArgs LeaderboardResultArgs
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(StatEventPlugin), Member = "StatisticEvent_EventType")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public StatEvent(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StatEvent()
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatEvent), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~StatEvent()
	{
	}

	[Calls(Type = typeof(StatEvent), Member = "DisposeImpl")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StatEvent), Member = "Dispose")]
	[CalledBy(Type = typeof(StatEvent), Member = "Finalize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void DisposeImpl()
	{
	}
}
