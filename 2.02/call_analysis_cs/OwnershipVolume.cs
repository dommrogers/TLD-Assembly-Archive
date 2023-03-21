using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OwnershipVolume : MonoBehaviour
{
	public BoxCollider m_BoxCollider;

	public string m_TrustId;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected void OnTriggerEntrer(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected void OnTriggerExit(Collider collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected void OnTriggerStay(Collider collider)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	[CalledBy(Type = typeof(OwnershipManager), Member = "GetOwnershipVolumeContaining")]
	public bool Contains(GameObject item)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public OwnershipVolume()
	{
	}
}
