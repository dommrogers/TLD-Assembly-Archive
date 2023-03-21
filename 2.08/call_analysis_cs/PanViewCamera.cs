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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[CallsUnknownMethods(Count = 10)]
	public void PanToLocation(Vector3 location, Quaternion rotation)
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "PerformInteraction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToLocation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public void PanToTransform(Transform target)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCancel")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsPanning()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PanViewCamera()
	{
	}
}
