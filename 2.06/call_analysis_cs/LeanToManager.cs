using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class LeanToManager : MonoBehaviour
{
	private PanelReference<Panel_Rest> m_Rest;

	public LeanTo m_LeanToPrefab;

	public LeanTo m_LeanToNoCampfirePrefab;

	public float m_BuildRangeMin;

	public float m_BuildRangeMax;

	public float m_RemoveRuinedAfterTimeHours;

	public float m_TemperatureIncreaseCelsius;

	public float m_FOV;

	public Vector2 m_PitchLimitDegrees;

	public Vector2 m_YawLimitDegrees;

	public float m_FadeOutSeconds;

	public float m_FadeInSeconds;

	public string m_BuildAudio;

	public string m_RepairAudio;

	public string m_DismantleAudio;

	public string m_RotateAudio;

	public string m_EnterAudio;

	public string m_ExitAudio;

	public static bool m_Locked;

	public static bool m_LeanTosUnlockedInStory;

	private bool m_PlayerEnteringLeanTo;

	private LeanTo m_PlayerOccupiedLeanTo;

	private LeanTo m_PendingPlayerOccupiedLeanTo;

	private float m_StartCameraFOV;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	public static List<LeanTo> m_LeanToList;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Add(LeanTo lt)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(LeanTo lt)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LeanTo), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(LeanTo), Member = "ShouldRemove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(LeanTo), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void RegisterAnyLeanToGuid()
	{
	}

	[CallerCount(Count = 0)]
	public void LeanTosUnlockInStory()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	public bool LeanTosAreUnlocked()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetTemperatureIncreaseCelsius()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public int GetNumSticksInInventory()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public int GetNumBranchesInInventory()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LeanToManager), Member = "CanAttemptToPlaceLeanTo")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoLeanToMessage")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LeanToManager), Member = "GetNumBranchesInInventory")]
	[Calls(Type = typeof(LeanToManager), Member = "GetNumSticksInInventory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	[Calls(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool CanAttemptToPlaceLeanTo()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnUse")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void EnterLeanTo(LeanTo lt)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CalledBy(Type = typeof(LeanTo), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 7)]
	public void ExitLeanTo(LeanTo lt)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsPlaceable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool PlayerInLeanTo()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LeanTo), Member = "GetHoverText")]
	[CalledBy(Type = typeof(LeanTo), Member = "ProcessInteraction")]
	public LeanTo GetPlayerOccupiedLeanTo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerInNonRuinedLeanTo()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool PlayerEnteringLeanTo()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenLeanToRest")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenLeanToRest")]
	[CallsUnknownMethods(Count = 1)]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void ExitShelterDueToStruggle()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DeserializePostSceneLoadFixup")]
	[Calls(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ForceIntoLeanToSilent(Vector3 cameraPos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[CallsUnknownMethods(Count = 1)]
	private void EnterLeanToAfterFadeOut()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void EnterLeanToAfterFadeOutCommon()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(LeanToManager), Member = "GetSafeExitPoint")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void ExitLeanToAfterFadeOut()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private Vector3 GetSafeExitPoint()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public LeanToManager()
	{
	}
}
