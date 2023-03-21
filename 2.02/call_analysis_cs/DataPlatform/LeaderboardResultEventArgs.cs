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
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(LeaderboardResults), Member = "SetNativePtr")]
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

	[Calls(Type = typeof(LeaderboardResultEventArgs), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	~LeaderboardResultEventArgs()
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LeaderboardResultEventArgs), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "Finalize")]
	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "Dispose")]
	private void DisposeImpl()
	{
	}
}
