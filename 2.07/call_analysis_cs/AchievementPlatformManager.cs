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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Initialize()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void ListAllUnlockedAchievements()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallsUnknownMethods(Count = 2)]
	public static void Unlock(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CalledBy(Type = typeof(UnlockAchievementTrigger), Member = "OnTriggerEnter")]
	public static bool IsUnlocked(Achievement achievement)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(AchievementManager), Member = "FullyHarvestedDeer")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(AchievementManager), Member = "SendStat")]
	[CalledBy(Type = typeof(AchievementManager), Member = "NightEnded")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "CheckAchievements")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static IAchievementPlatform AllocatePlatform()
	{
		return null;
	}
}
