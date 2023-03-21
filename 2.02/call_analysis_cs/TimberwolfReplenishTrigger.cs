using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimberwolfReplenishTrigger : MonoBehaviour
{
	public GameObject m_targetGameObject;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TimberwolfReplenishTrigger()
	{
	}
}
