using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class CampfireSaveDataProxy
{
	public CampfireState m_State;

	public Dictionary<string, string> m_RockGuids;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CampfireSaveDataProxy()
	{
	}
}
