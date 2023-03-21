using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class TLDBehaviourTreeManagerProxy
{
	public List<TLDBehaviourTreeOwnerProxy> m_TLDBehaviourTreeOwnerProxyList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public TLDBehaviourTreeManagerProxy()
	{
	}
}
