using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueOptionsAnimationTree : MonoBehaviour
{
	private List<DialogueSequenceFP> m_DialogueSequenceFPList;

	public static string m_DebugCurrentTextSelected;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DialogueOptionsAnimationSubTree), Member = "InstantiateLabels")]
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

	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdleUI")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateClosestToCenter")]
	public void UpdateClosestToCenter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DialogueOptionsAnimationTree()
	{
	}
}
