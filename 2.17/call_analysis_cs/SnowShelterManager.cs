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
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(SnowShelter), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(SnowShelterManager), Member = "InstantiateSnowShelter")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(SnowShelter), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void RegisterAnySnowShelterGuid()
	{
	}

	[CallerCount(Count = 0)]
	public void SnowSheltersUnlockInStory()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CallerCount(Count = 1)]
	public bool SnowSheltersAreUnlocked()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetTemperatureIncreaseCelsius()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumSticksInInventory()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumClothInInventory()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "CanAttemptToPlaceSnowShelter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsMissingMaterials()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoSnowShelterMessage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CallsUnknownMethods(Count = 4)]
	public bool CanAttemptToPlaceSnowShelter()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMinutesToBuild()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnUse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EnterShelter(SnowShelter ss)
	{
	}

	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(SnowShelter), Member = "PerformInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void ExitShelter(SnowShelter ss)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "ShouldFreezeMovement")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsPlaceable")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool PlayerInShelter()
	{
		return false;
	}

	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(SnowShelter), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(SnowShelter), Member = "PerformInteraction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public SnowShelter GetPlayerOccupiedSnowShelter()
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerInNonRuinedShelter()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool PlayerEnteringShelter()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenSnowShelterRest")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenSnowShelterRest")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void ExitShelterDueToStruggle()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DeserializePostSceneLoadFixup")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 20)]
	private void EnterShelterAfterFadeOutCommon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetSafeExitPoint")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void ExitShelterAfterFadeOut()
	{
	}

	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private Vector3 GetSafeExitPoint()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetOrLoadSnowShelterPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 1)]
	public SnowShelter InstantiateSnowShelter()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "UpdateDurationLabel")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "IsMissingMaterials")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMinutesToBuild")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "InstantiateSnowShelter")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[CallsUnknownMethods(Count = 1)]
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
