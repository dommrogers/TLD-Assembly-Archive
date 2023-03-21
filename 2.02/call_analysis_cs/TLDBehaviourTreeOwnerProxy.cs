using Cpp2ILInjected.CallAnalysis;

public class TLDBehaviourTreeOwnerProxy
{
	public string m_ObjectName;

	public string m_Blackboard;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public TLDBehaviourTreeOwnerProxy()
	{
	}
}
