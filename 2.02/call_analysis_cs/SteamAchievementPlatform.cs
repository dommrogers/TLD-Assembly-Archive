using System;
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ResetAllAchievements()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(AchievementPlatformBase), Member = "Initialize")]
	[CallsUnknownMethods(Count = 14)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsUnknownMethods(Count = 2)]
	public override void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	public override void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(SteamUserStats), Member = "SetAchievement")]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void Unlock(Achievement achievement)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	[Calls(Type = typeof(SteamUserStats), Member = "SetStat")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	private void RequestStatsAndAchievements()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(SteamUserStats), Member = "GetAchievement")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void OnUserStatsReceived(UserStatsReceived_t callback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	private static void OnUserStatsStored(UserStatsStored_t callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SteamAchievementPlatform()
	{
	}
}
