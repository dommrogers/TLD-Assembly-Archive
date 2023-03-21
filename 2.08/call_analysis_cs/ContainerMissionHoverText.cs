using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class ContainerMissionHoverText : MonoBehaviour
{
	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	public string m_ObjectiveID;

	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ContainerMissionHoverText()
	{
	}
}
