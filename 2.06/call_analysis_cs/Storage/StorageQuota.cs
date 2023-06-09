using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class StorageQuota
{
	public ulong TotalSize;

	public ulong SizeConsumed;

	public ulong SizeLeft
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0uL;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StorageQuota(ulong total, ulong used)
	{
	}
}
