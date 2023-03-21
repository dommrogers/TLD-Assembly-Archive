using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class TLDBehaviourTreeManagerProxy
{
	public List<TLDBehaviourTreeOwnerProxy> m_TLDBehaviourTreeOwnerProxyList;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TLDBehaviourTreeManagerProxy()
	{
	}
}
