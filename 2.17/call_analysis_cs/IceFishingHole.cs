using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.Gameplay.Fishing;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.AddressableAssets;

public class IceFishingHole : MonoBehaviour
{
	public const string CAUGHT_FISH_EVENT_NAME = "GearItem_CaughtFish";

	private float m_MinutesBeforeFreezingStartsAfterClearing;

	private float m_FreezePercentPerGameHour;

	private float m_MinGameMinutesCatchFish;

	private float m_MaxGameMinutesCatchFish;

	private float m_EmptyTipupTimeMultiplier;

	private FishLootTableData m_LootTable;

	private float m_PlacedTipupHourlyDecay;

	private float m_TipupLineSnapDecay;

	private float m_OverfishingRange;

	private int m_OverfishingLimit;

	private float m_OverfishingTimeMultiplier;

	public Vector3 m_PlacementMeshOffset;

	private LocalizedString m_ClearedHoleText;

	private LocalizedString m_FrozenPercentPostFix;

	private LocalizedString m_NoFishingGearText;

	private LocalizedString m_FishingInProgressText;

	private LocalizedString m_FishingLineSnappedText;

	private LocalizedString m_TipupBrokeText;

	private GameObject m_PlacementGroup;

	private GameObject m_IceHoleGroup;

	private SnowImprintCustom m_IceHoleImprint;

	private GameObject m_TipUp;

	private Animator m_TipUpAnimator;

	private AK.Wwise.Event m_FishingProgressAudioEvent;

	private AK.Wwise.Event m_CatchFishAudioEvent;

	private AK.Wwise.Event m_FreeFishAudioEvent;

	private AK.Wwise.Event m_BreakThroughIceAudioEvent;

	private AK.Wwise.Event m_FishingLineSnapAudioEvent;

	private AK.Wwise.Event m_TipupBreakAudioEvent;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_IceFishing> m_IceFishingPanel;

	private PanelReference<Panel_IceFishingHoleClear> m_ClearHolePanel;

	private FishingState m_State;

	private bool _003CHasCaughtFish_003Ek__BackingField;

	private float _003CNormalizedFrozen_003Ek__BackingField;

	private AssetReference _003CAssetReference_003Ek__BackingField;

	private bool m_IsUserPlaced;

	public NavMeshObstacle m_NavmeshCut;

	private bool _003CPauseFreezing_003Ek__BackingField;

	private int m_FrozenPercent;

	private float m_MinutesSinceLastClearing;

	private CatchParameters m_NextCatch;

	private float m_CatchMaxTimeModifier;

	private GearItem m_SelectedTackle;

	private GearItem m_SelectedLure;

	private GearItem m_SelectedBait;

	private SerializedTackle m_SerializedBait;

	private SerializedTackle m_SerializedLure;

	private GearItem m_ActiveTipup;

	private static readonly IceFishingHoleSaveData s_IceFishingHoleSaveData;

	private static List<IceFishingHole> s_IceFishingHoles;

	private int m_AnimParameter_TipUpCatch;

	private int m_AnimParameter_TipUpFreezeAmount;

	private static readonly int s_FreezeAmountShaderID;

	public AK.Wwise.Event CatchFishAudioEvent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public AK.Wwise.Event FreeFishAudioEvent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public bool IsFishingInProgress
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool HasCaughtFish
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public float NormalizedFrozen
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public AssetReference AssetReference
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		set
		{
		}
	}

	public bool PauseFreezing
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "ResetCatchParameters")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetToPlacementMode")]
	[Calls(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnBuild()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSelectedTackle(GearItem tackleGearItem)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DestroyLure")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelectedLure(GearItem lureGearItem)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "ConsumeBait")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelectedBait(GearItem baitGearItem)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void SetActiveTipup(GearItem tipupGearItem)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(IceFishingHole), Member = "RollNextCatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void StartActiveFishing(float progressBarSeconds, float ingameMinutes)
	{
	}

	[CallerCount(Count = 0)]
	public void OnActiveFishingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "MaybeRemoveAndGrabGear")]
	[Calls(Type = typeof(IceFishingHole), Member = "RollNextCatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void StartFishing(FishingState fishingType)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private GearItem MaybeRemoveAndGrabGear(GearItem gearItem)
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Awake")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ResetCatchParameters()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "StartActiveFishing")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFishing")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(IceFishingHole), Member = "CountNearbyActiveFishingHoles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(RandomTableData), Member = "get_RandomRange")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void RollNextCatch()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "CountNearbyActiveFishingHoles")]
	private float GetOverfishingScale()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "RollNextCatch")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "GetOverfishingScale")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private int CountNearbyActiveFishingHoles()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdateFishing")]
	[Calls(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdatePlayerPlacedHoleFreezingOver")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	private void UpdateFrozenState(float timePassedInMinutes)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(IceFishingHole), Member = "RollNextCatch")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateFishing(float timePassedInMinutes)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdatePlayerPlacedHoleFreezingOver()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetTipupAnimationTrigger(bool triggered)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeExitFishing()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "PerformInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IceFishingHole), Member = "ConsumeBait")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "InstantiateFish")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(IceFishingHole), Member = "ResetCatchParameters")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(IceFishingHole), Member = "DestroyLure")]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void CollectFish()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(IceFishingHole), Member = "DestroyLure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeDestroyTipup()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetSelectedBait")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void ConsumeBait()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeDestroyTipup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetSelectedLure")]
	[CallsUnknownMethods(Count = 1)]
	private void DestroyLure()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "TryInstantiateAsset")]
	[Calls(Type = typeof(GearItem), Member = "CacheComponents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private GearItem InstantiateFish(AssetReference fishReference)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "CanDoFishing")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[Calls(Type = typeof(IceFishingHole), Member = "MaybeDestroyTipup")]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "OnBuild")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnPlaceIceFishingHole")]
	[CalledBy(Type = typeof(FishingHolePlacementSettings), Member = "Instantiate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetToPlacementMode(bool enabled)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Awake")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "ClearHole")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetNormalizedFrozen(float normalized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ClearHole()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDisable")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(IceFishingHole), Member = "PickupTackle")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetSelectedBait")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetSelectedLure")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetActiveTipup")]
	[Calls(Type = typeof(IceFishingHole), Member = "ResetCatchParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void CancelFishing(bool userCancelled)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "InstantiateAndDeserializeGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void PickupTackle(GearItem selectedTackle, SerializedTackle serializedTackle)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateAndDeserializeGearItem")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetActiveTipup")]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdatePlayerPlacedHoleFreezingOver")]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdateFishing")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(IceFishingHoleSaveData saveData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatingFreezingMaterialProperties(MaterialPropertyBlock propertyBlock)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "TryDeserializeObject")]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByGuid")]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByPosition")]
	[Calls(Type = typeof(IceFishingHole), Member = "CreateIceFishingHole")]
	[Calls(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "TryInstantiateAsset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static IceFishingHole CreateIceFishingHole(AssetReference assetReference, Vector3 position)
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private static IceFishingHole FindIceFishingHoleByPosition(IceFishingHoleSaveData proxy)
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	private static IceFishingHole FindIceFishingHoleByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public IceFishingHole()
	{
	}
}
