using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class LeaderboardResultEventArgs : IDisposable, IWrappedObject
{
	private IntPtr m_Self;

	public LeaderboardResults Result
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LeaderboardResults), Member = "SetNativePtr")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LeaderboardResultEventArgs(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LeaderboardResultEventArgs()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResultEventArgs), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~LeaderboardResultEventArgs()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 59)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResultEventArgs), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "Finalize")]
	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "Dispose")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
