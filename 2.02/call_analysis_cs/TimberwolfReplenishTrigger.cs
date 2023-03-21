using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimberwolfReplenishTrigger : MonoBehaviour
{
	public GameObject m_targetGameObject;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TimberwolfReplenishTrigger()
	{
	}
}
