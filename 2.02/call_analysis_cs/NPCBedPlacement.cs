using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCBedPlacement : MonoBehaviour
{
	public float YOffset;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsUnknownMethods(Count = 25)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NPCBedPlacement()
	{
	}
}
