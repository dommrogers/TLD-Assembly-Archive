using Cpp2ILInjected.CallAnalysis;

public interface ITorchLightInteraction
{
	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	bool CanLightTorch();
}
