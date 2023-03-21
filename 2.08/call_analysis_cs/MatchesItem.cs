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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[CallerCount(Count = 0)]
	public void OnDroppedInWater()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnEquip()
	{
	}

	[Calls(Type = typeof(MatchesItem), Member = "UpdateFXTransform")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(MatchesItem), Member = "Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Wind), Member = "TooWindyForPlayerAction")]
	[CallerCount(Count = 1)]
	public void UpdateWhileInHands()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Wind), Member = "TooWindyForPlayerAction")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void IgniteDelayed()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	public void IgniteAfterDelay()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	public void Ignite()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(MatchesItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	public void PutOut(bool burntOut)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsBurning()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSItemGameObject")]
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
