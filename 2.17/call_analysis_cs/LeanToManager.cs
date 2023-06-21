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
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(LeanTo lt)
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
	[Calls(Type = typeof(LeanTo), Member = "ShouldRemove")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(LeanTo), Member = "Serialize")]
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
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(LeanTo), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static void RegisterAnyLeanToGuid()
	{
	}

	[CallerCount(Count = 0)]
	public void LeanTosUnlockInStory()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowShelterRadial")]
	[CallerCount(Count = 2)]
	public bool LeanTosAreUnlocked()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetTemperatureIncreaseCelsius()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumSticksInInventory()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshRepairPanel")]
	[CalledBy(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumBranchesInInventory()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoLeanToMessage")]
	[CalledBy(Type = typeof(LeanToManager), Member = "CanAttemptToPlaceLeanTo")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LeanToManager), Member = "GetNumSticksInInventory")]
	[Calls(Type = typeof(LeanToManager), Member = "GetNumBranchesInInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[CallsUnknownMethods(Count = 5)]
	public bool CanAttemptToPlaceLeanTo()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "OnUse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EnterLeanTo(LeanTo lt)
	{
	}

	[CalledBy(Type = typeof(LeanTo), Member = "ProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void ExitLeanTo(LeanTo lt)
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsPlaceable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool PlayerInLeanTo()
	{
		return false;
	}

	[CalledBy(Type = typeof(LeanTo), Member = "GetHoverText")]
	[CalledBy(Type = typeof(LeanTo), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public LeanTo GetPlayerOccupiedLeanTo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerInNonRuinedLeanTo()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool PlayerEnteringLeanTo()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenLeanToRest")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OpenLeanToRest")]
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
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 19)]
	private void EnterLeanToAfterFadeOutCommon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(LeanToManager), Member = "GetSafeExitPoint")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	private void ExitLeanToAfterFadeOut()
	{
	}

	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private Vector3 GetSafeExitPoint()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public LeanToManager()
	{
	}
}
