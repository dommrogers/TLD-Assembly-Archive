using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PackManagerDataProxyList
{
	public List<PackManagerDataProxy> m_SerializedDataProxyList;

	public List<string> m_RemoveOnLoadGuids;

	public float m_SerializedTime;

	public bool m_PlayerInPackCombatTrigger;

	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public PackManagerDataProxyList()
	{
	}
}
