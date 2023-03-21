using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FireSaveList
{
	public List<FireSaveData> m_SerializedFires;

	public List<string> m_DestroyedFires;

	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(FireManager), Member = "Serialize")]
	public FireSaveList()
	{
	}
}
