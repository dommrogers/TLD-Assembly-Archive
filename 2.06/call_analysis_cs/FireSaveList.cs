using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FireSaveList
{
	public List<FireSaveData> m_SerializedFires;

	public List<string> m_DestroyedFires;

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FireManager), Member = "Serialize")]
	public FireSaveList()
	{
	}
}
