using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class TLDBehaviourTreeManagerProxy
{
	public List<TLDBehaviourTreeOwnerProxy> m_TLDBehaviourTreeOwnerProxyList;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = ".cctor")]
	[CallsUnknownMethods(Count = 7)]
	public TLDBehaviourTreeManagerProxy()
	{
	}
}
