using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ContainerSaveList
{
	public List<ContainerSaveData> m_SerializedContainers;

	[CalledBy(Type = typeof(ContainerManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ContainerSaveList()
	{
	}
}
