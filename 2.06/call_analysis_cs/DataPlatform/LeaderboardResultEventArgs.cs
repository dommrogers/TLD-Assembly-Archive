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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(LeaderboardResults), Member = "SetNativePtr")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LeaderboardResultEventArgs(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public LeaderboardResultEventArgs()
	{
	}

	[Calls(Type = typeof(LeaderboardResultEventArgs), Member = "DisposeImpl")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	~LeaderboardResultEventArgs()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResultEventArgs), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "Dispose")]
	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
