using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

public class ConcurrentGraphState
{
	public GraphOwner m_GraphOwner;

	public string m_GraphId;

	public string m_StateId;

	public string m_SerializedBlackboard;

	public string m_SerializedGlobalBlackboard;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeConcurrentGraphs")]
	public ConcurrentGraphState()
	{
	}
}
