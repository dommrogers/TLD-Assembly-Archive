using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightDistanceCull : MonoBehaviour
{
	private struct LightDef
	{
		public Light m_Light;

		public float m_StartIntensity;

		public Vector3 m_Position;
	}

	public float m_LowDistance;

	public float m_MediumDistance;

	public float m_HighDistance;

	public float m_UltraDistance;

	public float m_FadePercentage;

	public int m_MaxLightsPerFrame;

	public bool m_UseCurrentLightIntensity;

	public List<Light> m_LightList;

	private List<LightDef> m_LightDef;

	private float m_MaxDistSqr;

	private float m_FadeDistSqr;

	private bool m_IsBigLoop;

	private int m_LoopStart;

	private int m_LoopEnd;

	private int m_LoopSteps;

	private int m_LoopCurStep;

	private QualityLodBias m_CachedQuality;

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ScriptLight), Member = "GetScriptLight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(LightDistanceCull), Member = "UpdateQualityValues")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LightDistanceCull), Member = "UpdateLights")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(LightDistanceCull), Member = "LateUpdate")]
	private void UpdateQualityValues()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float DistanceToPlayer(Vector3 lightPos, Vector3 camPos)
	{
		return default(float);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CalledBy(Type = typeof(LightDistanceCull), Member = "LateUpdate")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	private void UpdateLights()
	{
	}

	[CallerCount(Count = 0)]
	public LightDistanceCull()
	{
	}
}
