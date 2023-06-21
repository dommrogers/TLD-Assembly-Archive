using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Interactions;
using TLD.Logging;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

namespace TLD.BigCarry;

public class BigCarrySystem : MonoBehaviour
{
	private enum State
	{
		Active,
		Removed
	}

	private struct BigCarryItemInfo
	{
		public BigCarryItem m_Handle;

		public State m_State;

		public bool m_TrackRemoval;
	}

	public static readonly LogFilter s_LogFilter;

	private static BigCarrySystem _003CInstance_003Ek__BackingField;

	private bool _003CAllowTransferBetweenZones_003Ek__BackingField;

	private BigCarryItem _003CCarriedItem_003Ek__BackingField;

	private bool _003CIsDroppingItem_003Ek__BackingField;

	private bool m_RestoringCarry;

	private GearItem m_DummyGearItem;

	private const string ITEM_ROOT = "DesignBigCarry";

	private Dictionary<string, BigCarryItemInfo> m_BigCarryItems;

	private Transform m_BigCarryItemRoot;

	public static BigCarrySystem Instance
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool AllowTransferBetweenZones
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

	public BigCarryItem CarriedItem
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 57)]
		private set
		{
		}
	}

	public bool IsDroppingItem
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
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarrySystem), Member = "UpdateItems")]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BigCarryItem), Member = "CarryCallback")]
	[CallerCount(Count = 1)]
	public void Carry(BigCarryItem carryItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(BigCarrySystem), Member = "PlayHoistEffortAudio")]
	[Calls(Type = typeof(BigCarrySystem), Member = "SetupCarry")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarrySystem), Member = "PlayHoistEffortAudio")]
	[Calls(Type = typeof(BigCarrySystem), Member = "SetupCarry")]
	private void BeginCarry()
	{
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "HandleItemInHands")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "BeginCarry")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "Drop")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayHoistEffortAudio(bool pickingUp)
	{
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "HandleItemInHands")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "BeginCarry")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "Restore")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(BigCarrySystem), Member = "SetupFPH")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void SetupCarry(bool restoringCarry)
	{
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "SetupCarry")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "TryInstantiateAsset")]
	[Calls(Type = typeof(GearItem), Member = "CacheComponents")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MoveToTempParent")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CopyChildObject")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "PlayAnimation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetupFPH()
	{
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BigCarrySystem), Member = "SetupCarry")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void Restore(BigCarryItem bigCarryItem, BigCarryItemSaveData saveData, bool replacedOriginal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarrySystem), Member = "Drop")]
	public bool MaybeDrop()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool MaybeDropImmediate()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoBodyDrop")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "MaybeDrop")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BigCarrySystem), Member = "FindOrCreateBigCarryItemRoot")]
	[Calls(Type = typeof(BigCarrySystem), Member = "StickCarryItemGroundAtPlayersFeet")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(BigCarrySystem), Member = "FinishDrop")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(BigCarrySystem), Member = "PlayHoistEffortAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_PlacementMode_Place")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	public bool Drop(CarryDropOptions opts)
	{
		return false;
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "Drop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void FinishDrop()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_travois")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "Drop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool StickCarryItemGroundAtPlayersFeet(Transform carryItemTransform)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoBodyPlacement")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool MaybeBeginPlacement()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void CancelPlacement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarrySystem), Member = "RemoveItem")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[CallsUnknownMethods(Count = 1)]
	public void PrepareForSceneTransition()
	{
	}

	[CallerCount(Count = 0)]
	public bool CanInteractWithObject(IInteraction interaction)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceCurrentPlaceable")]
	[CalledBy(Type = typeof(BigCarryItem), Member = "CanInteractWithItem")]
	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "CanInteractWithItem")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "GetFromGuid")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowError(CarryDisplayError error)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigCarrySystem), Member = "FindOrCreateBigCarryItem")]
	[Calls(Type = typeof(BigCarrySystem), Member = "AddItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	public BigCarryItem SpawnBigCarryItem(string addressablesKey)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_travois")]
	[CalledBy(Type = typeof(BigCarryItem), Member = "Awake")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "SpawnBigCarryItem")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "Deserialize")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "TryFindBigCarryItemInPlayer")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "DeserializeScene")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AddItem(BigCarryItem item, bool trackRemoval)
	{
	}

	[CalledBy(Type = typeof(BigCarryItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "PrepareForSceneTransition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveItem(BigCarryItem item)
	{
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateItems()
	{
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "Drop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "CreateOrFindGameObjectFromPath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Transform FindOrCreateBigCarryItemRoot()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "TryDeserializeObject")]
	[Calls(Type = typeof(BigCarrySystem), Member = "TryFindBigCarryItemInPlayer")]
	[Calls(Type = typeof(BigCarrySystem), Member = "FindOrCreateBigCarryItem")]
	[Calls(Type = typeof(BigCarrySystem), Member = "AddItem")]
	[Calls(Type = typeof(BigCarrySystem), Member = "Restore")]
	[Calls(Type = typeof(BigCarrySystem), Member = "SetupCarry")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string data)
	{
	}

	[CalledBy(Type = typeof(BigCarrySystem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(BigCarrySystem), Member = "AddItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	private bool TryFindBigCarryItemInPlayer(string guid, out BigCarryItem bigCarryItem)
	{
		bigCarryItem = null;
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public string SerializeScene()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "TryDeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BigCarrySystem), Member = "FindOrCreateBigCarryItem")]
	[Calls(Type = typeof(BigCarrySystem), Member = "AddItem")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void DeserializeScene(string data)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_spawn_travois")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "SpawnBigCarryItem")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "Deserialize")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "DeserializeScene")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(AssetHelper), Member = "TryInstantiateAsset")]
	[Calls(Type = typeof(BigCarryItem), Member = "SetGUID")]
	[CallsUnknownMethods(Count = 1)]
	private BigCarryItem FindOrCreateBigCarryItem(string guid, string addressablesKey, out bool instantiated)
	{
		instantiated = default(bool);
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BigCarrySystem()
	{
	}
}
