using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class BlobInfo
{
	public string Name;

	public uint TotalSize;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public BlobInfo()
	{
	}
}
