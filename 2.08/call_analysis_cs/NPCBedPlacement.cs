using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCBedPlacement : MonoBehaviour
{
	public float YOffset;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsUnknownMethods(Count = 16)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	public NPCBedPlacement()
	{
	}
}
