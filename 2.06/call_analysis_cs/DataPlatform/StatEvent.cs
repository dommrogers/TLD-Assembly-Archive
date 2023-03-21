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
			return 0;
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
			return 0;
		}
	}

	public string ErrorMessage
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public LeaderboardResultEventArgs LeaderboardResultArgs
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StatEventPlugin), Member = "StatisticEvent_EventType")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
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
	[CallerCount(Count = 113)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatEvent), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~StatEvent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatEvent), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(StatEvent), Member = "Finalize")]
	[CalledBy(Type = typeof(StatEvent), Member = "Dispose")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
