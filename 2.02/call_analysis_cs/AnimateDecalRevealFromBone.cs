using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimateDecalRevealFromBone : MonoBehaviour
{
	private Transform m_RevealBone;

	private TransformAxis m_RevealAnimatedAxis;

	private Transform m_EraseBone;

	private TransformAxis m_EraseAnimatedAxis;

	private float m_EraseThreshold;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDecalReveal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AnimateDecalRevealFromBone()
	{
	}
}
