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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ScriptLight), Member = "GetScriptLight")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightDistanceCull), Member = "UpdateLights")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(LightDistanceCull), Member = "UpdateQualityValues")]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(LightDistanceCull), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	private void UpdateQualityValues()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float DistanceToPlayer(Vector3 lightPos, Vector3 camPos)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(LightDistanceCull), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateLights()
	{
	}

	[CallerCount(Count = 0)]
	public LightDistanceCull()
	{
	}
}
