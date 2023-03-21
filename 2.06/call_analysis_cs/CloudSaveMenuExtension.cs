using Cpp2ILInjected.CallAnalysis;

public class CloudSaveMenuExtension : CloudMenuExtension
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public CloudSaveMenuExtension()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Destroy()
	{
	}
}
