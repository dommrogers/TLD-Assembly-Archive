using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCPreventActiveTrigger : MonoBehaviour
{
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 0)]
	public NPCPreventActiveTrigger()
	{
	}
}
