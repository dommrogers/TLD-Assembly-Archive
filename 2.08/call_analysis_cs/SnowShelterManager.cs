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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelter), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(SnowShelterManager), Member = "InstantiateSnowShelter")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(SnowShelter), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[CallsUnknownMethods(Count = 4)]
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
	[CallerCount(Count = 0)]
	public float GetTemperatureIncreaseCelsius()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
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

	[CalledBy(Type = typeof(SnowShelterManager), Member = "CanAttemptToPlaceSnowShelter")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	public bool IsMissingMaterials()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoSnowShelterMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CallerCount(Count = 2)]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	public bool CanAttemptToPlaceSnowShelter()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	public float GetMinutesToBuild()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnUse")]
	[CallsUnknownMethods(Count = 2)]
	public void EnterShelter(SnowShelter ss)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowShelter), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallerCount(Count = 2)]
	public void ExitShelter(SnowShelter ss)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsPlaceable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldBreakStruggle")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	public bool PlayerInShelter()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SnowShelter), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(SnowShelter), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public SnowShelter GetPlayerOccupiedSnowShelter()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	public void ExitShelterDueToStruggle()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DeserializePostSceneLoadFixup")]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOut")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 2)]
	private void EnterShelterAfterFadeOutCommon()
	{
	}

	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetSafeExitPoint")]
	private void ExitShelterAfterFadeOut()
	{
	}

	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 5)]
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

	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "InstantiateSnowShelter")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMinutesToBuild")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "UpdateDurationLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	private SnowShelter GetOrLoadSnowShelterPrefab()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SnowShelterManager()
	{
	}
}
