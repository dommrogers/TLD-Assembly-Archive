using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueOptionsAnimationTree : MonoBehaviour
{
	private List<DialogueSequenceFP> m_DialogueSequenceFPList;

	public static string m_DebugCurrentTextSelected;

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DialogueOptionsAnimationSubTree), Member = "InstantiateLabels")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void InstantiateLabels(GameObject labelPrefab)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetScreenCenterPosition()
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdleUI")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateClosestToCenter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void UpdateClosestToCenter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DialogueOptionsAnimationTree()
	{
	}
}
