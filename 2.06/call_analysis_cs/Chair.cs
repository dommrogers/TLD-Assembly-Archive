using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class Chair : MonoBehaviour
{
	public float m_ApproachAngle;

	public float m_ApproachAngleAcceptableOffset;

	public PlayerInConstrainedCamera.ConstrainedCameraInfo m_ConstrainedCameraInfo;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Chair), Member = "CanInteract")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(Chair), Member = "InitializeInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private bool CanInteract()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Chair()
	{
	}
}
