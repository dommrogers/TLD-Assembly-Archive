using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PackManagerDataProxyList
{
	public List<PackManagerDataProxy> m_SerializedDataProxyList;

	public List<string> m_RemoveOnLoadGuids;

	public float m_SerializedTime;

	public bool m_PlayerInPackCombatTrigger;

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public PackManagerDataProxyList()
	{
	}
}
