using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FlareGunRoundSaveList
{
	public List<FlareGunRoundSaveData> m_SerializedItems;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(FlareGunRoundManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public FlareGunRoundSaveList()
	{
	}
}
