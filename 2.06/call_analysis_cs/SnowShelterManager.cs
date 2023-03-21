using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gear;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class SnowShelterManager : MonoBehaviour
{
	private PanelReference<Panel_Rest> m_Rest;

	public AssetReferenceWithComponent<SnowShelter> m_SnowShelterReference;

	public float m_BuildRangeMin;

	public float m_BuildRangeMax;

	public float m_TemperatureIncreaseCelsius;

	public float m_FOV;

	public Vector2 m_PitchLimitDegrees;

	public Vector2 m_YawLimitDegrees;

	public float m_FadeOutSeconds;

	public float m_FadeInSeconds;

	public string m_BuildAudio;

	public string m_RepairAudio;

	public string m_DismantleAudio;

	public string m_EnterAudio;

	public string m_ExitAudio;

	public static bool m_Locked;

	public static bool m_SnowSheltersUnlockedInStory;

	private bool m_PlayerEnteringShelter;

	private SnowShelter m_PlayerOccupiedSnowShelter;

	private SnowShelter m_PendingPlayerOccupiedSnowShelter;

	private float m_StartCameraFOV;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	private SnowShelter m_SnowShelterPrefab;

	public static List<SnowShelter> m_SnowShelters;

	private const float MaxDistance = 10f;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Add(SnowShelter ss)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(SnowShelter ss)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SnowShelter), Member = "Serialize")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SnowShelter), Member = "Deserialize")]
	[Calls(Type = typeof(SnowShelterManager), Member = "InstantiateSnowShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void RegisterAnySnowShelterGuid()
	{
	}

	[CallerCount(Count = 0)]
	public void SnowSheltersUnlockInStory()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	public bool SnowSheltersAreUnlocked()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetTemperatureIncreaseCelsius()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	public int GetNumSticksInInventory()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumClothInInventory()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "CanAttemptToPlaceSnowShelter")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	public bool IsMissingMaterials()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoSnowShelterMessage")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[Calls(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool CanAttemptToPlaceSnowShelter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMinutesToBuild()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnUse")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	public void EnterShelter(SnowShelter ss)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(SnowShelter), Member = "PerformInteraction")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void ExitShelter(SnowShelter ss)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldBreakStruggle")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsPlaceable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	public bool PlayerInShelter()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(SnowShelter), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(SnowShelter), Member = "PerformInteraction")]
	public SnowShelter GetPlayerOccupiedSnowShelter()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool PlayerInNonRuinedShelter()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool PlayerEnteringShelter()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenSnowShelterRest")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenSnowShelterRest")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public void ExitShelterDueToStruggle()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DeserializePostSceneLoadFixup")]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ForceIntoSnowShelterSilent(Vector3 cameraPos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CallsUnknownMethods(Count = 1)]
	private void EnterShelterAfterFadeOut()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void EnterShelterAfterFadeOutCommon()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetSafeExitPoint")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void ExitShelterAfterFadeOut()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private Vector3 GetSafeExitPoint()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public SnowShelter InstantiateSnowShelter()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "InstantiateSnowShelter")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMinutesToBuild")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "UpdateDurationLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	private SnowShelter GetOrLoadSnowShelterPrefab()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SnowShelterManager()
	{
	}
}
