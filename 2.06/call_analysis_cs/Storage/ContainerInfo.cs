using System;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class ContainerInfo
{
	public string Name;

	public string DisplayName;

	public ulong TotalSize;

	public DateTime LastModifiedTime;

	public bool NeedsSync;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public ContainerInfo()
	{
	}
}
