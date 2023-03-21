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
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CallsUnknownMethods(Count = 31)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Initialize")]
	public virtual void Initialize()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Shutdown()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract void Unlock(Achievement achievement);

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsUnlocked(Achievement achievement)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void SendStatistic(GameEventStatType statistic)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void ListAllUnlockedAchievements()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
