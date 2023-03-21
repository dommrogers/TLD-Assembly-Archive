using Cpp2ILInjected.CallAnalysis;

public class TLDBehaviourTreeOwnerProxy
{
	public string m_ObjectName;

	public string m_Blackboard;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public TLDBehaviourTreeOwnerProxy()
	{
	}
}
