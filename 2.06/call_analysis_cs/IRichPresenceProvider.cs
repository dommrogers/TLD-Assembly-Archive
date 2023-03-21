using Cpp2ILInjected.CallAnalysis;

public interface IRichPresenceProvider
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Initialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Shutdown();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void SetLocalizationKeys(RichPresenceLocInfo[] locKeys);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void SetPresence(PresenceType presenceType);
}
