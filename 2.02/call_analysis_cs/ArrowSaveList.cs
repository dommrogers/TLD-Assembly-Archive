using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ArrowSaveList
{
	public List<ArrowSaveData> m_SerializedItems;

	[CalledBy(Type = typeof(ArrowManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ArrowSaveList()
	{
	}
}
