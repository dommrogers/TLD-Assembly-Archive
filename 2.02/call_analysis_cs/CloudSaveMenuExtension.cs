using Cpp2ILInjected.CallAnalysis;

public class CloudSaveMenuExtension : CloudMenuExtension
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CloudSaveMenuExtension()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Destroy()
	{
	}
}
