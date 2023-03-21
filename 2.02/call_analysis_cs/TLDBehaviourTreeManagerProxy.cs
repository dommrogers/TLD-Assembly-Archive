using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class TLDBehaviourTreeManagerProxy
{
	public List<TLDBehaviourTreeOwnerProxy> m_TLDBehaviourTreeOwnerProxyList;

	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public TLDBehaviourTreeManagerProxy()
	{
	}
}
