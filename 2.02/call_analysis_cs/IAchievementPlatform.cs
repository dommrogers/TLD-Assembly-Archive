using Cpp2ILInjected.CallAnalysis;

public interface IAchievementPlatform
{
	bool IsFullyOperational
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	bool DidAchievementsChangeThisUpdate
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		set;
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void Initialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Shutdown();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void Unlock(Achievement achievement);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool IsUnlocked(Achievement achievement);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SendStatistic(GameIntStatType statistic, int amount);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SendStatistic(GameFloatStatType statistic, float amount);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void SendStatistic(GameEventStatType statistic);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void ListAllUnlockedAchievements();
}
