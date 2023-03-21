using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
	public ElevatorPrototypeController m_ElevatorController;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ElevatorTrigger()
	{
	}
}
