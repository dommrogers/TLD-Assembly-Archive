using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FlareGunRoundSaveList
{
	public List<FlareGunRoundSaveData> m_SerializedItems;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public FlareGunRoundSaveList()
	{
	}
}
