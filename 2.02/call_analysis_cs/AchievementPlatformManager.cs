using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

public static class AchievementPlatformManager
{
	public delegate void AchievementsChangedHandler();

	private static IAchievementPlatform s_AchievementPlatform;

	public static readonly int NumStatistics;

	public static readonly int NumAchievements;

	public static bool AchievementsEnabledOnThisPlatform
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public static bool IsFullyOperational
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return false;
		}
	}

	public static event AchievementsChangedHandler OnAchievementsChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static void Initialize()
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void ListAllUnlockedAchievements()
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Unlock(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(UnlockAchievementTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsUnlocked(Achievement achievement)
	{
		return false;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "SendStat")]
	[CalledBy(Type = typeof(AchievementManager), Member = "NightEnded")]
	[CalledBy(Type = typeof(AchievementManager), Member = "FullyHarvestedDeer")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SendStatistic(GameEventStatType statistic)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static IAchievementPlatform AllocatePlatform()
	{
		return null;
	}
}
