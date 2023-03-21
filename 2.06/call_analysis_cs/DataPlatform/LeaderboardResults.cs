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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public bool HasNext
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public LeaderboardQuery GetNextQuery()
	{
		return null;
	}

	[Calls(Type = typeof(LeaderboardResults), Member = "SetNativePtr")]
	[CallerCount(Count = 0)]
	public LeaderboardResults(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public LeaderboardResults()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResults), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~LeaderboardResults()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(LeaderboardResults), Member = ".ctor")]
	[CalledBy(Type = typeof(LeaderboardResultEventArgs), Member = "get_Result")]
	[CallsUnknownMethods(Count = 13)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 23)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardResults), Member = "DisposeImpl")]
	public void Dispose()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LeaderboardResults), Member = "Finalize")]
	[CalledBy(Type = typeof(LeaderboardResults), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
