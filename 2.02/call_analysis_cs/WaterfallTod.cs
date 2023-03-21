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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScaledCurve), Member = ".ctor")]
	[Calls(Type = typeof(ScaledCurve), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public WaterfallTod()
	{
	}
}
