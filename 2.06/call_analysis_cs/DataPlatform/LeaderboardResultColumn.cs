using System;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace DataPlatform;

public class LeaderboardResultColumn
{
	private IntPtr m_Self;

	private string m_DisplayName;

	private string m_StatisticName;

	public string DisplayName
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string StatisticName
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

	public StatisticType Type
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(StatisticType);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LeaderboardResultColumn(IntPtr self)
	{
	}
}
