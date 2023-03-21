using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ArrowSaveList
{
	public List<ArrowSaveData> m_SerializedItems;

	[CalledBy(Type = typeof(ArrowManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public ArrowSaveList()
	{
	}
}
