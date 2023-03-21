using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PanViewCamera : MonoBehaviour
{
	public float m_PanViewSeconds;

	public int m_EasingLevel;

	private Vector3 m_TargetPos;

	private Quaternion m_TargetRot;

	private Vector3 m_OriginalPos;

	private Quaternion m_OriginalRot;

	private Vector3 m_LerpStartPos;

	private Quaternion m_LerpStartRot;

	private bool m_IsDetachedFromPlayer;

	private bool m_IsPanning;

	private bool m_IsPanningToPlayer;

	private float m_PanStartTime;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	public void PanToLocation(Vector3 location, Quaternion rotation)
	{
	}

	[CalledBy(Type = typeof(CustomCameraPosition), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToLocation")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void PanToTransform(Transform target)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Enable")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void ReattachToPlayer()
	{
	}

	[CallerCount(Count = 0)]
	public void MaybeReattachToPlayer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public bool IsDetached()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPanning()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PanViewCamera()
	{
	}
}
