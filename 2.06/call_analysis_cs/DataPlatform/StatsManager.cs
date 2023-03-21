using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class StatsManager
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void AddLocalUser(int userId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveLocaluser(int userId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetStatAsInteger(int userId, string statName, long statValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetStatAsNumber(int userId, string statName, double statValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManagerPlugin), Member = "StatsManager_SetStatAsString")]
	public static void SetStatAsString(int userId, string statName, string statValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void RequestFlushToService(int userId, bool isHighPriority)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static StatNamesList GetStatNames(int userId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static StatValue GetStat(int userId, string statName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void DeleteStat(int userId, string statName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void GetLeaderboard(int userId, string statName, LeaderboardQuery query)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void GetSocialLeaderboard(int userId, string statName, string socialGroup, LeaderboardQuery query)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static StatEventList DoWork()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public StatsManager()
	{
	}
}
