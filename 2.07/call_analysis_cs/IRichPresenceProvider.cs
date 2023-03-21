using Cpp2ILInjected.CallAnalysis;

public interface IRichPresenceProvider
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void Initialize();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void Shutdown();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void SetLocalizationKeys(RichPresenceLocInfo[] locKeys);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void SetPresence(PresenceType presenceType);
}
