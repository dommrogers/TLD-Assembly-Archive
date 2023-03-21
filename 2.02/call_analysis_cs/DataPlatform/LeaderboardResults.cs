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
			return default(uint);
		}
	}

	public string DisplayName
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

	public bool HasNext
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(LeaderboardResults), Member = ".ctor")]
	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "get_Result")]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LeaderboardResults), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(LeaderboardResults), Member = "Finalize")]
	[CalledBy(Type = typeof(LeaderboardResults), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
