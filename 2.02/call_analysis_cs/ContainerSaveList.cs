using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ContainerSaveList
{
	public List<ContainerSaveData> m_SerializedContainers;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ContainerManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 7)]
	public ContainerSaveList()
	{
	}
}
