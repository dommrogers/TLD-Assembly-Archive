using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class MatchesItem : MonoBehaviour
{
	public float m_MinBurnTimeGametimeSeconds;

	public float m_MaxBurnTimeGametimeSeconds;

	public float m_BlowOutWindSpeedMPH;

	public string m_IgniteAudio;

	public string m_BurnOutAudio;

	public float m_IgniteDelaySeconds;

	public MatchesType m_MatchesType;

	public MatchesIntensity m_IntensityComponent;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_FireStart> m_FireStartPanel;

	private float m_BurnTimeGametimeSeconds;

	private float m_ElapsedBurnGametimeSeconds;

	private bool m_Ignited;

	private StackableItem m_StackableItem;

	private bool m_IgniteAfterDelay;

	private float m_ElapsedIgniteDelaySeconds;

	private Transform m_FXTransform;

	private GearItem m_GearItem;

	private bool m_IsFresh;

	private static MatchesItemSaveDataProxy m_MatchesItemSaveDataProxy;

	private GearItem m_ClonedStack;

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	public void OnDroppedInWater()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnEquip()
	{
	}

	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(MatchesItem), Member = "UpdateFXTransform")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(MatchesItem), Member = "Ignite")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Wind), Member = "TooWindyForPlayerAction")]
	public void UpdateWhileInHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Wind), Member = "TooWindyForPlayerAction")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void IgniteDelayed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[CallsUnknownMethods(Count = 3)]
	public void IgniteAfterDelay()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Ignite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearClonedStack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[CallsUnknownMethods(Count = 3)]
	public void CancelIgnite()
	{
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(MatchesItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void PutOut(bool burntOut)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsBurning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsFresh()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetBurnProgress()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsUnknownMethods(Count = 4)]
	private void OnIgniteCompleteCallback()
	{
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSItemGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	private void UpdateFXTransform(float percentComplete)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MatchesItem()
	{
	}
}
