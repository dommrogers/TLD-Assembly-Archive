using Cpp2ILInjected.CallAnalysis;

public interface TLD_ITrack : TLD_IDynamicBindableTrack
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Play();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Stop();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void UpdatePlay();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void LateUpdatePlay();
}
