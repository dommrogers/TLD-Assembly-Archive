using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class LeanToSaveList
{
	public List<LeanToSaveData> m_SerializedLeanToList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public LeanToSaveList()
	{
	}
}
