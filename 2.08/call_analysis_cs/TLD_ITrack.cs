using Cpp2ILInjected.CallAnalysis;

public interface TLD_ITrack : TLD_IDynamicBindableTrack
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Play();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Stop();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void UpdatePlay();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void LateUpdatePlay();
}
