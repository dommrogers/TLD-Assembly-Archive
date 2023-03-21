using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class LeaderboardResults : IDisposable, IWrappedObject
{
	public LeaderboardResultColumns Columns;

	public LeaderboardResultRows Rows;

	private IntPtr m_Self;

	private string m_DisplayName;

	public uint TotalRowCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public string DisplayName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public bool HasNext
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public LeaderboardQuery GetNextQuery()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResults), Member = "SetNativePtr")]
	public LeaderboardResults(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LeaderboardResults()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResults), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~LeaderboardResults()
	{
	}

	[CalledBy(Type = typeof(LeaderboardResults), Member = ".ctor")]
	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "get_Result")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResults), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(LeaderboardResults), Member = "Finalize")]
	[CalledBy(Type = typeof(LeaderboardResults), Member = "Dispose")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
