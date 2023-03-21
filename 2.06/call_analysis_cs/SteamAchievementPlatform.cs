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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	public static void ResetAllAchievements()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(AchievementPlatformBase), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	public override void Update()
	{
	}

	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallerCount(Count = 0)]
	public override void Shutdown()
	{
	}

	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	[Calls(Type = typeof(SteamUserStats), Member = "SetAchievement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	public override void Unlock(Achievement achievement)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamUserStats), Member = "SetStat")]
	public override void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void RequestStatsAndAchievements()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SteamUserStats), Member = "GetAchievement")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[CallerCount(Count = 6)]
	public SteamAchievementPlatform()
	{
	}
}
