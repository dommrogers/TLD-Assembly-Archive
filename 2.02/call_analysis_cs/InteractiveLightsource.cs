using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class InteractiveLightsource : MonoBehaviour
{
	public LightSourceType m_LightType;

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_OnDisplayName;

	public LocalizedString m_OffDisplayName;

	public LocalizedString m_LightPromptText;

	public LocalizedString m_ExtinguishPromptText;

	public LocalizedString m_StartingLightProgress;

	public LocalizedString m_ExtinguishLightProgress;

	public float m_StartFireRealTimeSeconds;

	public float m_StartFireGameTimeMinutes;

	public float m_ExtinguishFireRealTimeSeconds;

	public float m_ExtinguishFireGameTimeMinutes;

	public List<InteractiveLightsource> m_LightsourceLinks;

	private static List<InteractiveLightsource> s_LightsourceObjects;

	public GameObject m_Light;

	public bool m_IsOn;

	private MissionIlluminationArea m_MissionIllumination;

	private float m_MissionIlluminationOnRadius;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "OnInteractComplete")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "OnInteractComplete")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "Deserialize")]
	[CalledBy(Type = typeof(Action_SetInteractiveLightsourceState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetInteractiveLightsourceState), Member = "SetLightsourceState")]
	[CallsUnknownMethods(Count = 3)]
	public void SetState(bool isOn)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[CallsUnknownMethods(Count = 4)]
	public void OnInteractComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InteractiveLightsource), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InteractiveLightsource), Member = "FindLightsourceByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 10)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	private string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "DeserializeAll")]
	private void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	private static InteractiveLightsource FindLightsourceByGuid(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public void ShowHoverButtonPrompts()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsUnknownMethods(Count = 4)]
	public void HideHoverButtonPrompts()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public InteractiveLightsource()
	{
	}
}
