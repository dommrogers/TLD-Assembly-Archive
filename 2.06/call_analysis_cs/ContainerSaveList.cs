using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ContainerSaveList
{
	public List<ContainerSaveData> m_SerializedContainers;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public ContainerSaveList()
	{
	}
}
