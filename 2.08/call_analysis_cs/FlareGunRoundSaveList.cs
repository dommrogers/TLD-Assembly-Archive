using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class FlareGunRoundSaveList
{
	public List<FlareGunRoundSaveData> m_SerializedItems;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public FlareGunRoundSaveList()
	{
	}
}
