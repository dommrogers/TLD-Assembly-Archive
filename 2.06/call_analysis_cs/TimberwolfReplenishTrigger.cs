using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimberwolfReplenishTrigger : MonoBehaviour
{
	public GameObject m_targetGameObject;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TimberwolfReplenishTrigger()
	{
	}
}
