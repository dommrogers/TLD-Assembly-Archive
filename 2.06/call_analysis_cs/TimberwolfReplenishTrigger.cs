using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimberwolfReplenishTrigger : MonoBehaviour
{
	public GameObject m_targetGameObject;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TimberwolfReplenishTrigger()
	{
	}
}
