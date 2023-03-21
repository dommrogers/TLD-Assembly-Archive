using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WaterfallTod : MonoBehaviour
{
	public GameObject m_WaterfallObject;

	public ScaledCurve m_SaturationControl;

	public ScaledCurve m_GlowValue;

	private Renderer m_Renderer;

	private MaterialPropertyBlock m_PropertyBlock;

	private float m_OrgSaturation;

	private static readonly int s_SaturationShaderID;

	private static readonly int s_GlowAmountShaderID;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Update()
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	public WaterfallTod()
	{
	}
}
