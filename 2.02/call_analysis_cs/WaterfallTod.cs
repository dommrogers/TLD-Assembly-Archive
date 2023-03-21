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
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScaledCurve), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public WaterfallTod()
	{
	}
}
