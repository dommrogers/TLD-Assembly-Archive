using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OwnershipVolume : MonoBehaviour
{
	public BoxCollider m_BoxCollider;

	public string m_TrustId;

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void OnTriggerEntrer(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void OnTriggerExit(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void OnTriggerStay(Collider collider)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(OwnershipManager), Member = "GetOwnershipVolumeContaining")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	public bool Contains(GameObject item)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public OwnershipVolume()
	{
	}
}
