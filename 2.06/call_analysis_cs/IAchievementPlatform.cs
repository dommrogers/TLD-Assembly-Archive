using Cpp2ILInjected.CallAnalysis;

public interface IAchievementPlatform
{
	bool IsFullyOperational
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	bool DidAchievementsChangeThisUpdate
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		set;
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void Initialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Shutdown();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Unlock(Achievement achievement);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	bool IsUnlocked(Achievement achievement);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void SendStatistic(GameIntStatType statistic, int amount);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void SendStatistic(GameFloatStatType statistic, float amount);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void SendStatistic(GameEventStatType statistic);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void ListAllUnlockedAchievements();
}
