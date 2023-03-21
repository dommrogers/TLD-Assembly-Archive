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
			return default(bool);
		}
	}

	public static bool IsFullyOperational
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public static event AchievementsChangedHandler OnAchievementsChanged
	{
		[CompilerGenerated]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[CallsUnknownMethods(Count = 9)]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void Shutdown()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void ListAllUnlockedAchievements()
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Unlock(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CalledBy(Type = typeof(UnlockAchievementTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CallerCount(Count = 8)]
	public static bool IsUnlocked(Achievement achievement)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "SendStat")]
	[CalledBy(Type = typeof(AchievementManager), Member = "NightEnded")]
	[CalledBy(Type = typeof(AchievementManager), Member = "FullyHarvestedDeer")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	public static void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SendStatistic(GameEventStatType statistic)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private static IAchievementPlatform AllocatePlatform()
	{
		return null;
	}
}
