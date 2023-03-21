using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class LeanToSaveList
{
	public List<LeanToSaveData> m_SerializedLeanToList;

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(LeanToManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public LeanToSaveList()
	{
	}
}
