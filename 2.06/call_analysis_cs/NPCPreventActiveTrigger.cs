using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCPreventActiveTrigger : MonoBehaviour
{
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public NPCPreventActiveTrigger()
	{
	}
}
