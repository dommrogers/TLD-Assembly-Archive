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

	[Calls(Type = typeof(MatchesItem), Member = "UpdateFXTransform")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(MatchesItem), Member = "Ignite")]
	[Calls(Type = typeof(Wind), Member = "TooWindyForPlayerAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[CallsUnknownMethods(Count = 7)]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void IgniteAfterDelay()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CallsUnknownMethods(Count = 3)]
	public void Ignite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearClonedStack()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	public void CancelIgnite()
	{
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CalledBy(Type = typeof(MatchesItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[Calls(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	public void PutOut(bool burntOut)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "EnableRenderable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnIgniteCompleteCallback()
	{
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSItemGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateFXTransform(float percentComplete)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MatchesItem()
	{
	}
}
