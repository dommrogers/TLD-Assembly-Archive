using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FireSaveList
{
	public List<FireSaveData> m_SerializedFires;

	public List<string> m_DestroyedFires;

	[CalledBy(Type = typeof(FireManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public FireSaveList()
	{
	}
}
