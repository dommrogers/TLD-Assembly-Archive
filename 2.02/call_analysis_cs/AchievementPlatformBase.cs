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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		protected set
		{
		}
	}

	public virtual bool DidAchievementsChangeThisUpdate
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Initialize")]
	[CallsUnknownMethods(Count = 33)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	public virtual void Initialize()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void Shutdown()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract void Unlock(Achievement achievement);

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool IsUnlocked(Achievement achievement)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void SendStatistic(GameEventStatType statistic)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void ListAllUnlockedAchievements()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected AchievementInfo FindAchievementInfoByOptionalData(int optionalID)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected AchievementPlatformBase()
	{
	}
}
