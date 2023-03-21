using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueOptionsAnimationTree : MonoBehaviour
{
	private List<DialogueSequenceFP> m_DialogueSequenceFPList;

	public static string m_DebugCurrentTextSelected;

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(DialogueOptionsAnimationSubTree), Member = "InstantiateLabels")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateClosestToCenter")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdleUI")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
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
