using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class CampfireSaveDataProxy
{
	public CampfireState m_State;

	public Dictionary<string, string> m_RockGuids;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Campfire), Member = ".cctor")]
	[CallsUnknownMethods(Count = 8)]
	public CampfireSaveDataProxy()
	{
	}
}
