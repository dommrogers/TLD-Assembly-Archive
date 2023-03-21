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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(Action_SetInteractiveLightsourceState), Member = "OnExecute")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "Deserialize")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "OnInteractComplete")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SetInteractiveLightsourceState), Member = "SetLightsourceState")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "OnInteractComplete")]
	[CallsUnknownMethods(Count = 2)]
	public void SetState(bool isOn)
	{
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	public void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsUnknownMethods(Count = 6)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[CallsUnknownMethods(Count = 4)]
	public void OnInteractComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void HideInteraction()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InteractiveLightsource), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 10)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 7)]
	private string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(InteractiveLightsource), Member = "DeserializeAll")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
