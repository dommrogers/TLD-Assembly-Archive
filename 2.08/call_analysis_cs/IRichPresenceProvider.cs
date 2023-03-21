using Cpp2ILInjected.CallAnalysis;

public interface IRichPresenceProvider
{
	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void Initialize();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Shutdown();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Update();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void SetLocalizationKeys(RichPresenceLocInfo[] locKeys);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void SetPresence(PresenceType presenceType);
}
