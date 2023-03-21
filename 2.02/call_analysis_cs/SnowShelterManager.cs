using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowShelterManager : MonoBehaviour
{
	public SnowShelter m_SnowShelterPrefab;

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

	public static List<SnowShelter> m_SnowShelters;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Add(SnowShelter ss)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void Remove(SnowShelter ss)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SnowShelter), Member = "Serialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterSaveList), Member = ".ctor")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SnowShelter), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(ObjectGuid), Member = "Register")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void RegisterAnySnowShelterGuid()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SnowSheltersUnlockInStory()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public int GetNumSticksInInventory()
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public int GetNumClothInInventory()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "CanAttemptToPlaceSnowShelter")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoSnowShelterMessage")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumClothInInventory")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetNumSticksInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool CanAttemptToPlaceSnowShelter()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "OnUse")]
	[CallsUnknownMethods(Count = 13)]
	public void EnterShelter(SnowShelter ss)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SnowShelter), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public void ExitShelter(SnowShelter ss)
	{
	}

	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool PlayerInShelter()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SnowShelter), Member = "GetHoverText")]
	[CalledBy(Type = typeof(SnowShelter), Member = "ProcessInteraction")]
	public SnowShelter GetPlayerOccupiedSnowShelter()
	{
		return null;
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenSnowShelterRest")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenSnowShelterRest")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void ExitShelterDueToStruggle()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DeserializePostSceneLoadFixup")]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 2)]
	public void ForceIntoSnowShelterSilent(Vector3 cameraPos)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	private void EnterShelterAfterFadeOut()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallsUnknownMethods(Count = 73)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void EnterShelterAfterFadeOutCommon()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetSafeExitPoint")]
	private void ExitShelterAfterFadeOut()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private Vector3 GetSafeExitPoint()
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SnowShelterManager()
	{
	}
}
