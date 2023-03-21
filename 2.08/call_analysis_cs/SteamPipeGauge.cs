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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SteamPipeGauge), Member = "UpdateGaugeNeedle")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeGauge), Member = "UpdateGaugeNeedle")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SteamPipeGauge), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SteamPipeGauge), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Renderer), Member = "get_isVisible")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void UpdateGaugeNeedle()
	{
	}

	[CallerCount(Count = 0)]
	public SteamPipeGauge()
	{
	}
}
