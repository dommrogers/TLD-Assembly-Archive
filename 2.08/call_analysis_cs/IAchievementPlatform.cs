using Cpp2ILInjected.CallAnalysis;

public interface IAchievementPlatform
{
	bool IsFullyOperational
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	bool DidAchievementsChangeThisUpdate
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void Initialize();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void Update();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void Shutdown();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Unlock(Achievement achievement);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool IsUnlocked(Achievement achievement);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void SendStatistic(GameIntStatType statistic, int amount);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void SendStatistic(GameFloatStatType statistic, float amount);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void SendStatistic(GameEventStatType statistic);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void ListAllUnlockedAchievements();
}
