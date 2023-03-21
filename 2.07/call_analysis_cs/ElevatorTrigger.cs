using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
	public ElevatorPrototypeController m_ElevatorController;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ElevatorTrigger()
	{
	}
}
