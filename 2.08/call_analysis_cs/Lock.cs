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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(float);
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
		[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	[Calls(Type = typeof(Lock), Member = "MaybeUnlockDueToCompanionBeingUnlocked")]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	[Calls(Type = typeof(GameModeFilterExtensions), Member = "PassesGameModeFilter")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "MaybeGetHoverIconsToShow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(OpenClose), Member = "Serialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(LoadScene), Member = "Deserialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Lock), Member = "MaybeGetHoverIconsToShow")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void DeserializeUnlockedCompanionGuids(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsLocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool WasEverLocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Lock), Member = "RollLockedState")]
	[CalledBy(Type = typeof(Lock), Member = "MaybeUnlockDueToCompanionBeingUnlocked")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "Enable")]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "DoWork")]
	public void SetLockState(LockState state)
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	public void RollLockedState()
	{
	}

	[CallerCount(Count = 0)]
	public bool RequiresToolToUnlock()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[CallerCount(Count = 0)]
	public bool PlayerHasRequiredToolToUnlock()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Lock), Member = "PlayLockedAudio")]
	[Calls(Type = typeof(Lock), Member = "PlayLockedAudio")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	public bool CanForceLock()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[CallsUnknownMethods(Count = 2)]
	public void PrepareForceLock()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(LockedInteraction), Member = "FinishForceLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Lock), Member = "UnlockCompanionLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void FinishForceLock(bool complete)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[CalledBy(Type = typeof(Lock), Member = "CanForceLock")]
	[CalledBy(Type = typeof(Lock), Member = "PlayerHasRequiredToolToUnlock")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem GetGearItemToForceLock()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "DoWork")]
	[CalledBy(Type = typeof(Lock), Member = "FinishForceLock")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void UnlockCompanionLock()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUnlockDueToCompanionBeingUnlocked()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Lock), Member = "CanForceLock")]
	[CalledBy(Type = typeof(Lock), Member = "CanForceLock")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private void PlayLockedAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayUnlockAudio()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AssignBindingOverrides()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Lock), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeGetHoverIconsToShow()
	{
	}

	[CallerCount(Count = 0)]
	public Lock()
	{
	}
}
