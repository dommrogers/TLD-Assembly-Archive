using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
	public ElevatorPrototypeController m_ElevatorController;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ElevatorTrigger()
	{
	}
}
