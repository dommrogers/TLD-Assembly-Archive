using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Chair : MonoBehaviour
{
	public float m_ApproachAngle;

	public float m_ApproachAngleAcceptableOffset;

	public PlayerInConstrainedCamera.ConstrainedCameraInfo m_ConstrainedCameraInfo;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Chair), Member = "CanInteract")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CallsUnknownMethods(Count = 2)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Chair), Member = "CanInteract")]
	public string GetHoverText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Chair), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(Chair), Member = "GetHoverText")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallerCount(Count = 2)]
	private bool CanInteract()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public Chair()
	{
	}
}
