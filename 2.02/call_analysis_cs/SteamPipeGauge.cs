using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SteamPipeGauge : MonoBehaviour
{
	public SteamPipe m_SteamPipe;

	public Transform m_GaugeNeedle;

	public float m_GaugeNeedleMaxFlow;

	public float m_GaugeNeedleMinFlow;

	public float m_GaugeNeedleMaxAngle;

	public float m_GaugeNeedleMinAngle;

	public Vector3 m_GaugeNeedleRotationAngleFactors;

	public bool m_MeasureOutput;

	public float m_AnimationSmoothing;

	public float m_MaxFlowRandomness;

	private Renderer m_NeedleRenderer;

	private float m_GaugeNeedleCurrentAngle;

	private float m_GaugeNeedleTargetAngle;

	private float m_GaugeNeedleFlowRange;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeGauge), Member = "UpdateGaugeNeedle")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeGauge), Member = "UpdateGaugeNeedle")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SteamPipeGauge), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeGauge), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Renderer), Member = "get_isVisible")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void UpdateGaugeNeedle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SteamPipeGauge()
	{
	}
}
