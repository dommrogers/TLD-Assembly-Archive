using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ChimneySaveList
{
	public List<LinkedChimneySaveData> m_SerializedChimneyData;

	[CalledBy(Type = typeof(FireManager), Member = "SerializeChimneyData")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public ChimneySaveList()
	{
	}
}
