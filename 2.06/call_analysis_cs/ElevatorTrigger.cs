using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
	public ElevatorPrototypeController m_ElevatorController;

	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ElevatorTrigger()
	{
	}
}
