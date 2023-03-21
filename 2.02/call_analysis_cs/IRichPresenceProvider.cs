using Cpp2ILInjected.CallAnalysis;

public interface IRichPresenceProvider
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Initialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Shutdown();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetLocalizationKeys(RichPresenceLocInfo[] locKeys);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetPresence(PresenceType presenceType);
}
