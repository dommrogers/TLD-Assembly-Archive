using Cpp2ILInjected.CallAnalysis;

public interface ITorchLightInteraction
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool CanLightTorch();
}
