using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimateDecalRevealFromBone : MonoBehaviour
{
	private Transform m_RevealBone;

	private TransformAxis m_RevealAnimatedAxis;

	private Transform m_EraseBone;

	private TransformAxis m_EraseAnimatedAxis;

	private float m_EraseThreshold;

	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDecalReveal")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public AnimateDecalRevealFromBone()
	{
	}
}
