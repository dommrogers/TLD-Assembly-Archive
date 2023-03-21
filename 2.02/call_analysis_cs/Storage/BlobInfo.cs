using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class BlobInfo
{
	public string Name;

	public uint TotalSize;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BlobInfo()
	{
	}
}
