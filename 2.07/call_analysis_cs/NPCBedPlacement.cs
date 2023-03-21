using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCBedPlacement : MonoBehaviour
{
	public float YOffset;

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	public NPCBedPlacement()
	{
	}
}
