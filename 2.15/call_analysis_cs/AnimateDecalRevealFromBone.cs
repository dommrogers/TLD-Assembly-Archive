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
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public AnimateDecalRevealFromBone()
	{
	}
}
