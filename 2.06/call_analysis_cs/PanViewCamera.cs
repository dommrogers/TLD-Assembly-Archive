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

	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	public void PanToLocation(Vector3 location, Quaternion rotation)
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToLocation")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CallsUnknownMethods(Count = 3)]
	public void PanToTransform(Transform target)
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	public void ReattachToPlayer()
	{
	}

	[CallerCount(Count = 0)]
	public void MaybeReattachToPlayer()
	{
	}

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
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
	[CallerCount(Count = 12)]
	public PanViewCamera()
	{
	}
}
