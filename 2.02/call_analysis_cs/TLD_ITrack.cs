using Cpp2ILInjected.CallAnalysis;

public interface TLD_ITrack : TLD_IDynamicBindableTrack
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Play();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Stop();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void UpdatePlay();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void LateUpdatePlay();
}
