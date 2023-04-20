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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	public WaterfallTod()
	{
	}
}
