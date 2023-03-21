using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class Chair : MonoBehaviour
{
	public float m_ApproachAngle;

	public float m_ApproachAngleAcceptableOffset;

	public PlayerInConstrainedCamera.ConstrainedCameraInfo m_ConstrainedCameraInfo;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Chair), Member = "CanInteract")]
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
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	private bool CanInteract()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Chair()
	{
	}
}
