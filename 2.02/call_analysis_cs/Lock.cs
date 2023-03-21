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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "PassesGameModeFilter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Lock), Member = "Cancel")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Lock), Member = "OnForceLockComplete")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Serialize")]
	[CalledBy(Type = typeof(LoadScene), Member = "Serialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Deserialize")]
	[CalledBy(Type = typeof(LoadScene), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Lock), Member = "MaybeGetHoverIconsToShow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string SerializeUnlockedCompanionGuids()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DeserializeUnlockedCompanionGuids(string text)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLocked()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool WasEverLocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsBroken()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetLockState(LockState state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool AttemptedToOpen()
	{
		return false;
	}

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RollLockedState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool RequiresToolToUnlock()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool PlayerHasRequiredToolToUnlock()
	{
		return false;
	}

	[CalledBy(Type = typeof(Container), Member = "ForceLock")]
	[CalledBy(Type = typeof(OpenClose), Member = "ForceLock")]
	[CalledBy(Type = typeof(LoadScene), Member = "ForceLock")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "StartInteract")]
	[Calls(Type = typeof(Lock), Member = "PlayLockedAudio")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ForceLockBegin(OnLockStateBroken onLockStateBroken)
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "PlayerHasRequiredToolToUnlock")]
	[CalledBy(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CalledBy(Type = typeof(OpenClose), Member = "ForceLock")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public GearItem GetGearItemToForceLock()
	{
		return null;
	}

	[CalledBy(Type = typeof(Lock), Member = "OnForceLockComplete")]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "DoWork")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UnlockCompainionLock()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "StartInteractInternal")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void StartInteract()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "StartInteract")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Cancel")]
	[Calls(Type = typeof(Lock), Member = "OnForceLockComplete")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 30)]
	public void StartInteractInternal()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Update")]
	[CalledBy(Type = typeof(Lock), Member = "StartInteractInternal")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void Cancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ProgressBarStarted()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Update")]
	[CalledBy(Type = typeof(Lock), Member = "StartInteractInternal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Lock), Member = "UnlockCompainionLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void OnForceLockComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUnlockDueToCompanionBeingUnlocked()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void PlayLockedAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void PlayUnlockAudio()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private void AssignBindingOverrides()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Lock), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
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
