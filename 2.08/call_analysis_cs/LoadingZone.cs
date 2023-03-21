using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class LoadingZone : TimedHoldInteraction
{
	public LocalizedString m_LocalizedTransitionType;

	public LoadScene m_PartnerLoadScene;

	private Vector3 m_Forward;

	private bool m_LoadingZoneActive;

	public override bool CanInteract
	{
		[Calls(Type = typeof(BaseHoldInteraction), Member = "get_CanInteract")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override bool CanCancel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(LoadScene), Member = "Activate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadingZone), Member = "ComputeTriggerForwardDirection")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LoadingZone), Member = "DeactivateLoadingZone")]
	private void OnTriggerStay(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(LoadingZone), Member = "DeactivateLoadingZone")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	private void ComputeTriggerForwardDirection()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void ActivateLoadingZone()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 1)]
	private void DeactivateLoadingZone()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LoadingZone()
	{
	}
}
