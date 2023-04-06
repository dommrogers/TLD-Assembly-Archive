using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PackManagerDataProxyList
{
	public List<PackManagerDataProxy> m_SerializedDataProxyList;

	public List<string> m_RemoveOnLoadGuids;

	public float m_SerializedTime;

	public bool m_PlayerInPackCombatTrigger;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public PackManagerDataProxyList()
	{
	}
}
