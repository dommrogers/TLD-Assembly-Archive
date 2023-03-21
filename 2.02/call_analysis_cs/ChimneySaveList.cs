using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ChimneySaveList
{
	public List<LinkedChimneySaveData> m_SerializedChimneyData;

	[CalledBy(Type = typeof(FireManager), Member = "SerializeChimneyData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ChimneySaveList()
	{
	}
}
