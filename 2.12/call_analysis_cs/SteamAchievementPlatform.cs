using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Steamworks;

public class SteamAchievementPlatform : AchievementPlatformBase
{
	private enum InternalState
	{
		BootStrapping,
		StatsAndAchievementsQueryRequested,
		StatsAndAchievementsQueryPending,
		StatsAndAchievementsQuerySuccessful,
		SystemOperational,
		SystemNotInitializedProperly
	}

	private Callback<UserStatsReceived_t> m_OnUserStatsReceived;

	private Callback<UserStatsStored_t> m_OnUserStatsStored;

	private InternalState m_InternalState;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetAllAchievements()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementPlatformBase), Member = "Initialize")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsUnknownMethods(Count = 1)]
	public override void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SteamUserStats), Member = "SetAchievement")]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	[CallsUnknownMethods(Count = 1)]
	public override void Unlock(Achievement achievement)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(SteamUserStats), Member = "SetStat")]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	[CallsUnknownMethods(Count = 1)]
	public override void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RequestStatsAndAchievements()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SteamUserStats), Member = "GetAchievement")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private void OnUserStatsReceived(UserStatsReceived_t callback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	private static void OnUserStatsStored(UserStatsStored_t callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SteamAchievementPlatform()
	{
	}
}
