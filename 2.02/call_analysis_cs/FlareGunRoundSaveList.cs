using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FlareGunRoundSaveList
{
	public List<FlareGunRoundSaveData> m_SerializedItems;

	[CalledBy(Type = typeof(FlareGunRoundManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public FlareGunRoundSaveList()
	{
	}
}
