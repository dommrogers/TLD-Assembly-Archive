using Cpp2ILInjected.CallAnalysis;

public interface TLD_ITrack : TLD_IDynamicBindableTrack
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void Play();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void Stop();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void UpdatePlay();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void LateUpdatePlay();
}
