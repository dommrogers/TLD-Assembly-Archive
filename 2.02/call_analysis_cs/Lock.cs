using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Lock : MonoBehaviour
{
	public delegate void OnLockStateBroken();

	public GameModeFilter m_ModeFilter;

	public float m_ChanceLocked;

	public float m_ForceLockDurationSecondsMin;

	public float m_ForceLockDurationSecondsMax;

	public float m_ChanceContainerRuinedWhenToolBreaks;

	public GearItem m_GearPrefabToForceLock;

	public string m_CompanionLockGuid;

	public string m_LockedAudio;

	public string m_UnlockAudio;

	public bool m_UseHoverTextColor;

	public bool m_HideToolRequiredToForceOpenHintText;

	public AnimatedInteraction m_AnimatedInteraction;

	public Animator m_AnimatedObjectAnimator;

	public string m_AnimatedObjectTrackName;

	public static List<string> m_UnlockedCompanionGuids;

	private GearItem m_GearUsedToForceLock;

	private LockState m_LockState;

	private bool m_AttemptedToOpen;

	private bool m_LockStateRolled;

	private bool m_BreakOnUse;

	private bool m_CheckedForUnlockedCompanion;

	private ObjectGuid m_ObjectGuid;

	private HoverIconsToShow m_HoverIcons;

	private OnLockStateBroken m_OnLockStateBroken;

	private bool m_IsBeingInteractedWith;

	private float m_InteractTimer;

	private uint m_ForceLockAudioID;

	private PlayerControlMode m_RestoreControlMode;

	private float m_RandomFailureTime;

	private bool m_WasEverLocked;

	private static LockSaveDataProxy m_LockSaveDataProxy;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(Lock), Member = "MaybeGetHoverIconsToShow")]
	[Calls(Type = typeof(Lock), Member = "AssignBindingOverrides")]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "PassesGameModeFilter")]
	public void Start()
	{
	}

	[Calls(Type = typeof(Lock), Member = "OnForceLockComplete")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Lock), Member = "Cancel")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Lock), Member = "Cancel")]
	[Calls(Type = typeof(Lock), Member = "Cancel")]
	[CallsUnknownMethods(Count = 8)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Serialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(LoadScene), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Lock), Member = "MaybeGetHoverIconsToShow")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Deserialize")]
	[CalledBy(Type = typeof(LoadScene), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string SerializeUnlockedCompanionGuids()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void DeserializeUnlockedCompanionGuids(string text)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLocked()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool WasEverLocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsBroken()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetLockState(LockState state)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool AttemptedToOpen()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	public void RollLockedState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool RequiresToolToUnlock()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool PlayerHasRequiredToolToUnlock()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Lock), Member = "PlayLockedAudio")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CalledBy(Type = typeof(OpenClose), Member = "ForceLock")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Container), Member = "ForceLock")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(LoadScene), Member = "ForceLock")]
	[Calls(Type = typeof(Lock), Member = "StartInteract")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "PlayLockedAudio")]
	[CallerCount(Count = 3)]
	public void ForceLockBegin(OnLockStateBroken onLockStateBroken)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[CalledBy(Type = typeof(OpenClose), Member = "ForceLock")]
	[CalledBy(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CalledBy(Type = typeof(Lock), Member = "PlayerHasRequiredToolToUnlock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem GetGearItemToForceLock()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Lock), Member = "OnForceLockComplete")]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "DoWork")]
	[CallsUnknownMethods(Count = 2)]
	public void UnlockCompainionLock()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Lock), Member = "ForceLockBegin")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "StartInteractInternal")]
	public void StartInteract()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(Lock), Member = "StartInteract")]
	[Calls(Type = typeof(Lock), Member = "OnForceLockComplete")]
	[Calls(Type = typeof(Lock), Member = "Cancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	public void StartInteractInternal()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(Lock), Member = "StartInteractInternal")]
	[CalledBy(Type = typeof(Lock), Member = "Update")]
	[CalledBy(Type = typeof(Lock), Member = "Update")]
	[CalledBy(Type = typeof(Lock), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsUnknownMethods(Count = 9)]
	public void Cancel()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void ProgressBarStarted()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Lock), Member = "UnlockCompainionLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CalledBy(Type = typeof(Lock), Member = "Update")]
	[CalledBy(Type = typeof(Lock), Member = "StartInteractInternal")]
	[CallsUnknownMethods(Count = 9)]
	private void OnForceLockComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeUnlockDueToCompanionBeingUnlocked()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CalledBy(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayLockedAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayUnlockAudio()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AssignBindingOverrides()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Lock), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 18)]
	private void MaybeGetHoverIconsToShow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Lock()
	{
	}
}
