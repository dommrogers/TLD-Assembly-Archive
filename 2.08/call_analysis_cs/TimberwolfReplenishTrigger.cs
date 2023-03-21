using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimberwolfReplenishTrigger : MonoBehaviour
{
	public GameObject m_targetGameObject;

	[Calls(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TimberwolfReplenishTrigger()
	{
	}
}
