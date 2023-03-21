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
		[CallerCount(Count = 7)]
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
		[CallerCount(Count = 2)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
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
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(SteamAchievementPlatform), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 33)]
	public virtual void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void Shutdown()
	{
	}

	public abstract void Unlock(Achievement achievement);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool IsUnlocked(Achievement achievement)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void SendStatistic(GameEventStatType statistic)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void ListAllUnlockedAchievements()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected AchievementInfo FindAchievementInfoByOptionalData(int optionalID)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected AchievementPlatformBase()
	{
	}
}
