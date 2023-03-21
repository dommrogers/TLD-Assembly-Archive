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
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 13)]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[CallsUnknownMethods(Count = 10)]
	public void PanToLocation(Vector3 location, Quaternion rotation)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToLocation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	public void PanToTransform(Transform target)
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
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
	[CallerCount(Count = 2)]
	public bool IsDetached()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPanning()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PanViewCamera()
	{
	}
}
