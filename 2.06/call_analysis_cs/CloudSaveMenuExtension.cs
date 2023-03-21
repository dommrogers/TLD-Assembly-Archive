using Cpp2ILInjected.CallAnalysis;

public class CloudSaveMenuExtension : CloudMenuExtension
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CloudSaveMenuExtension()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Destroy()
	{
	}
}
