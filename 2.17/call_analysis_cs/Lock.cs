using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Serialization;
using UnityEngine;

public class Lock : MonoBehaviour
{
	public delegate void OnLockStateBroken();

	private static LockSaveDataProxy m_LockSaveDataProxy;

	private static List<string> m_UnlockedCompanionGuids;

	public GameModeFilter m_ModeFilter;

	public float m_ChanceLocked;

	public string m_CompanionLockGuid;

	public string m_LockedAudio;

	public string m_UnlockAudio;

	public Keypad m_AttachedKeypad;

	public LocalizedString m_LockedKeypadText;

	public float m_ForceLockDurationSecondsMin;

	public float m_ForceLockDurationSecondsMax;

	public GearItem m_GearPrefabToForceLock;

	public bool m_HideToolRequiredToForceOpenHintText;

	public bool m_UseHoverTextColor;

	public AnimatedInteraction m_AnimatedInteraction;

	public Animator m_AnimatedObjectAnimator;

	public string m_AnimatedObjectTrackName;

	private GearItem m_GearUsedToForceLock;

	private LockState m_LockState;

	private bool m_AttemptedToOpen;

	private bool m_LockStateRolled;

	private bool m_BreakOnUse;

	private ObjectGuid m_ObjectGuid;

	private HoverIconsToShow m_HoverIcons;

	private OnLockStateBroken m_OnLockStateBroken;

	private uint m_ForceLockAudioID;

	private float m_RandomFailureTime;

	private bool m_WasEverLocked;

	private float _003CForceTime_003Ek__BackingField;

	private string _003CForceText_003Ek__BackingField;

	public float ForceTime
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public string ForceText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(Lock), Member = "MaybeGetHoverIconsToShow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameModeFilterExtensions), Member = "PassesGameModeFilter")]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	[Calls(Type = typeof(Lock), Member = "MaybeUnlockDueToCompanionBeingUnlocked")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Serialize")]
	[CalledBy(Type = typeof(LoadScene), Member = "Serialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static string SerializeUnlockedCompanionGuids()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static void DeserializeUnlockedCompanionGuids(string text)
	{
	}

	[DeduplicatedMethod]
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

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Lock), Member = "RollLockedState")]
	[CalledBy(Type = typeof(Lock), Member = "MaybeUnlockDueToCompanionBeingUnlocked")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "Enable")]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "DoWork")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void SetLockState(LockState state)
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	public void RollLockedState()
	{
	}

	[CallerCount(Count = 0)]
	public bool RequiresToolToUnlock()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	public bool PlayerHasRequiredToolToUnlock()
	{
		return false;
	}

	[CalledBy(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "PlayLockedAudio")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanForceLock()
	{
		return false;
	}

	[CalledBy(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void PrepareForceLock()
	{
	}

	[CalledBy(Type = typeof(LockedInteraction), Member = "FinishForceLock")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Lock), Member = "UnlockCompanionLock")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void FinishForceLock(bool complete)
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "PlayerHasRequiredToolToUnlock")]
	[CalledBy(Type = typeof(Lock), Member = "CanForceLock")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 4)]
	public GearItem GetGearItemToForceLock()
	{
		return null;
	}

	[CalledBy(Type = typeof(Lock), Member = "FinishForceLock")]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "DoWork")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UnlockCompanionLock()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUnlockDueToCompanionBeingUnlocked()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "CanForceLock")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PlayLockedAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PlayUnlockAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void AssignBindingOverrides()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Lock), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeGetHoverIconsToShow()
	{
	}

	[CallerCount(Count = 0)]
	public Lock()
	{
	}
}
