using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UnspawnPredatorRadialTrigger : MonoBehaviour
{
	public float m_DistanceRadiusToUnspawn;

	public bool m_DisableAfterTriggering;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(AiUtils), Member = "DespawnHostileAiAroundPoint")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UnspawnPredatorRadialTrigger()
	{
	}
}
