using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraLightingSimple : MonoBehaviour
{
	public MinMax m_AuroraThresholdActivate;

	public MinMax m_AuroraThresholdStable;

	public string m_Audio;

	public bool m_LightFadeWithAurora;

	public float m_UpdateThresholdPercent;

	public MinMax m_LightPrimaryIntensity;

	public MinMax m_LightPrimaryFrequency;

	public bool m_RequiresAuroraField;

	public bool m_ExternalPowerActive;

	public float m_MaximumDistanceFromCamera;

	public float m_MaxConsoleDistanceFromCamera;

	public float m_SwitchIndoorPercent;

	public float m_XboxPs4IndoorPercent;

	public float m_PcIndoorPercent;

	public float m_FadeDistancePercent;

	private float m_CurPriFreq;

	private float m_PriPeriod;

	private float m_PhiPri;

	private float m_PhiTimer;

	private float m_CurIntensity;

	private float m_StaticIntensity;

	private float m_CurLowThreshold;

	private float m_CurStableThreshold;

	private float m_AuroraLightFade;

	private Shader m_EmissiveShader;

	private AuroraField m_ActiveAuroraField;

	private List<Material> m_LocalMaterials;

	private Light[] m_LocalLights;

	private uint m_AudioInstanceID;

	private bool m_HasStopped;

	private bool m_SetDistances;

	private float m_MaximumSqrDistanceFromCamera;

	private float m_MaximumSqrFadeFromCamera;

	private float m_IntensitySentToWise;

	private float m_FadeIntensity;

	private static readonly int EmissiveStrength;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "StopAll")]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void FindLights()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void FindMaterials()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "StopAll")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "Start")]
	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "CheckActivation")]
	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "OnDisable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "UpdateLight")]
	[CallerCount(Count = 3)]
	public void StopAll()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "CheckActivation")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "UpdateLight")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "UpdateEmissiveObjects")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallsUnknownMethods(Count = 2)]
	public void ManualUpdate(float camDistSqr, float fadeIntensity, float auroraIntensity, float deltaTime)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(AuroraLightingSimple), Member = "StopAll")]
	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckActivation(float camDistSqr, float fadeIntensity, float auroraIntensity)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateIntensity(float deltaTime)
	{
	}

	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "StopAll")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateLight(bool allOff = false)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "ManualUpdate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "StopAll")]
	private void UpdateEmissiveObjects(bool allOff = false)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(AuroraLightingSimple), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAudio()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	private void StopAudio()
	{
	}

	[CallerCount(Count = 0)]
	public void SetLocationDistances(bool useOutdoorValues)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentLowThreshold()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentStableThreshold()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsElectrolized()
	{
		return default(bool);
	}

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void SetAuroraField(AuroraField auroraField)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetIntensityNormalized()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetExternalPowerState(bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public AuroraLightingSimple()
	{
	}
}
