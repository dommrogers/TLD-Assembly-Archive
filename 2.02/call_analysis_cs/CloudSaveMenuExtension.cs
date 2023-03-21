using Cpp2ILInjected.CallAnalysis;

public class CloudSaveMenuExtension : CloudMenuExtension
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CloudSaveMenuExtension()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Destroy()
	{
	}
}
