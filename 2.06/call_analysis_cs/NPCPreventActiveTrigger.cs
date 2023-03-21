using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCPreventActiveTrigger : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public NPCPreventActiveTrigger()
	{
	}
}
