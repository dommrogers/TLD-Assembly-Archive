using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class LeanToSaveList
{
	public List<LeanToSaveData> m_SerializedLeanToList;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public LeanToSaveList()
	{
	}
}
