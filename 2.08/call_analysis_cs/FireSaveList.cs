using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FireSaveList
{
	public List<FireSaveData> m_SerializedFires;

	public List<string> m_DestroyedFires;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public FireSaveList()
	{
	}
}
