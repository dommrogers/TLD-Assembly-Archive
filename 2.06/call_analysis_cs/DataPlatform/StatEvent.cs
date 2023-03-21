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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		get
		{
			return null;
		}
	}

	public LeaderboardResultEventArgs LeaderboardResultArgs
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(StatEventPlugin), Member = "StatisticEvent_EventType")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StatEvent(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public StatEvent()
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatEvent), Member = "DisposeImpl")]
	~StatEvent()
	{
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatEvent), Member = "DisposeImpl")]
	public void Dispose()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(StatEvent), Member = "Finalize")]
	[CalledBy(Type = typeof(StatEvent), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
