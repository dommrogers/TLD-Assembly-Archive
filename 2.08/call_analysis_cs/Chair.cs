using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class Chair : MonoBehaviour
{
	public float m_ApproachAngle;

	public float m_ApproachAngleAcceptableOffset;

	public PlayerInConstrainedCamera.ConstrainedCameraInfo m_ConstrainedCameraInfo;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Chair), Member = "CanInteract")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(Chair), Member = "InitializeInteraction")]
	private bool CanInteract()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Chair()
	{
	}
}
