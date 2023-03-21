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
			return false;
		}
	}

	public static bool IsFullyOperational
	{
		[CallerCount(Count = 0)]
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
		[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void Unlock(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(UnlockAchievementTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(AchievementManager), Member = "CheckAchievements")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "HasCompletedEpisode")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "OnAchievementsChanged")]
	[CallerCount(Count = 6)]
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
	[CallsUnknownMethods(Count = 2)]
	public static void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void SendStatistic(GameEventStatType statistic)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IAchievementPlatform AllocatePlatform()
	{
		return null;
	}
}
