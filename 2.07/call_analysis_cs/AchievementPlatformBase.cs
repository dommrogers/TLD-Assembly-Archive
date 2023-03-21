using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

public abstract class AchievementPlatformBase : IAchievementPlatform
{
	protected class AchievementInfo
	{
		public bool Unlocked;

		public int OptionalData;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public AchievementInfo()
		{
		}
	}

	protected Dictionary<Achievement, AchievementInfo> m_RegisteredAchievements;

	protected Dictionary<GameIntStatType, string> m_RegisteredStats;

	private bool _003CIsFullyOperational_003Ek__BackingField;

	private bool _003CDidAchievementsChangeThisUpdate_003Ek__BackingField;

	public bool IsFullyOperational
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		protected set
		{
		}
	}

	public virtual bool DidAchievementsChangeThisUpdate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	public virtual void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Shutdown()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract void Unlock(Achievement achievement);

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public virtual bool IsUnlocked(Achievement achievement)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SendStatistic(GameEventStatType statistic)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void ListAllUnlockedAchievements()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected AchievementInfo FindAchievementInfoByOptionalData(int optionalID)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected AchievementPlatformBase()
	{
	}
}
