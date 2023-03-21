using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCPreventActiveTrigger : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NPCPreventActiveTrigger()
	{
	}
}
