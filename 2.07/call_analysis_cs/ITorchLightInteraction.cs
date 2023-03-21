using Cpp2ILInjected.CallAnalysis;

public interface ITorchLightInteraction
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool CanLightTorch();
}
