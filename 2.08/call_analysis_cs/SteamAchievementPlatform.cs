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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	public static void ResetAllAchievements()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(AchievementPlatformBase), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	public override void Shutdown()
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamUserStats), Member = "SetAchievement")]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	public override void Unlock(Achievement achievement)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	[Calls(Type = typeof(SteamUserStats), Member = "SetStat")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(SteamUserStats), Member = "GetAchievement")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	private void OnUserStatsReceived(UserStatsReceived_t callback)
	{
	}

	[Calls(Type = typeof(SteamUserStats), Member = "StoreStats")]
	[CallerCount(Count = 0)]
	private static void OnUserStatsStored(UserStatsStored_t callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SteamAchievementPlatform()
	{
	}
}
