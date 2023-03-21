using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class InteractiveLightsource : MonoBehaviour
{
	public LightSourceType m_LightType;

	public LocalizedString m_LightPromptText;

	public LocalizedString m_ExtinguishPromptText;

	public LocalizedString m_StartingLightProgress;

	public LocalizedString m_ExtinguishLightProgress;

	public float m_StartFireRealTimeSeconds;

	public float m_StartFireGameTimeMinutes;

	public float m_ExtinguishFireRealTimeSeconds;

	public float m_ExtinguishFireGameTimeMinutes;

	public List<InteractiveLightsource> m_LightsourceLinks;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_GenericProgressBar> m_ProgressBar;

	private static List<InteractiveLightsource> s_LightsourceObjects;

	public GameObject m_Light;

	public bool m_IsOn;

	private MissionIlluminationArea m_MissionIllumination;

	private float m_MissionIlluminationOnRadius;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(InteractiveLightsource), Member = "Deserialize")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "OnInteractComplete")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "OnInteractComplete")]
	[CalledBy(Type = typeof(Action_SetInteractiveLightsourceState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetInteractiveLightsourceState), Member = "SetLightsourceState")]
	[CallsUnknownMethods(Count = 2)]
	public void SetState(bool isOn)
	{
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeInteraction()
	{
	}

	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnInteractComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void HideInteraction()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 7)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	private string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(InteractiveLightsource), Member = "DeserializeAll")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static InteractiveLightsource FindLightsourceByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public InteractiveLightsource()
	{
	}
}
