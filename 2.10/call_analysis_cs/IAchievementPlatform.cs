public interface IAchievementPlatform
{
	bool IsFullyOperational { get; }

	bool DidAchievementsChangeThisUpdate { get; set; }

	void Initialize();

	void Update();

	void Shutdown();

	void Unlock(Achievement achievement);

	bool IsUnlocked(Achievement achievement);

	void SendStatistic(GameIntStatType statistic, int amount);

	void SendStatistic(GameFloatStatType statistic, float amount);

	void SendStatistic(GameEventStatType statistic);

	void ListAllUnlockedAchievements();
}
