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
		get
		{
			return default(bool);
		}
	}

	public static bool IsFullyOperational
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public static event AchievementsChangedHandler OnAchievementsChanged
	{
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[CallerCount(Count = 1)]
	public static void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void ListAllUnlockedAchievements()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	public static void Unlock(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(UnlockAchievementTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public static bool IsUnlocked(Achievement achievement)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AchievementManager), Member = "FullyHarvestedDeer")]
	[CalledBy(Type = typeof(AchievementManager), Member = "NightEnded")]
	[CalledBy(Type = typeof(AchievementManager), Member = "SendStat")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	public static void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void SendStatistic(GameEventStatType statistic)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private static IAchievementPlatform AllocatePlatform()
	{
		return null;
	}
}
