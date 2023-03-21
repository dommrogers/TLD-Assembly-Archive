using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SafeCracking : MonoBehaviour
{
	public SafeDifficulty m_Difficulty;

	public bool m_Cracked;

	public GameObject m_DialObjectPrefab;

	public float touchRotationScale;

	public float m_MinRotateDegreesPerSecond;

	public float m_MaxRotateDegreesPerSecond;

	public float m_RotateRampUpTime;

	public int m_NumTicksOnDial;

	public bool m_RollCombination;

	public int[] m_Combination;

	public GameObject m_DialObject;

	public string m_DialSpinAudio;

	public string m_SafeClickAudio;

	public string m_TumblerFallAudio;

	public string m_TumblerResetAudio;

	public bool m_DisableCollisionDuringAnimation;

	private uint m_dialSpinPlayingID;

	private uint m_safeClickPlayingID;

	private int m_NumTumblers;

	private Tumbler[] m_Tumblers;

	private float m_DegreesPerTick;

	private int m_CurrentTumblerIndex;

	private bool m_ReturnToZeroRequired;

	private float m_RotateStartTime;

	private float m_LastDialEulerAnglesZ;

	private vp_Timer m_PlayTumblerSoundTimer;

	private vp_Timer m_ShowOpenButtonTimer;

	private HoverIconsToShow m_HoverIcons;

	private static SafeCrackingSaveDataProxy m_SafeCrackingSaveDataProxy;

	private OpenClose m_OpenClose;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 59)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "IsCurrentSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsOpen()
	{
		return false;
	}

	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private float GetDialDelta()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(SafeCracking), Member = "GetDialDelta")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 27)]
	public void UpdateDial()
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "Start")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CalledBy(Type = typeof(SafeCracking), Member = "ResetSafe")]
	[CalledBy(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "SetTumblerStatus")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void ResetTumblers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UnlockSafe()
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "SetTumblerStatus")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	private void UnlockCurrentTumbler()
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[Calls(Type = typeof(SafeCracking), Member = "PlayResetTumblersSound")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(SafeCracking), Member = "PlayDialSpinClick")]
	[Calls(Type = typeof(SafeCracking), Member = "UnlockCurrentTumbler")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private void HitTick(float deltaDegrees)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	private void ResetSafe()
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void PlayDialSpinClick()
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PlayResetTumblersSound()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void PlaySafeClickSound()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PlayTumblerFallSound()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	private int TickToDialNumber(float tick)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Container), Member = "StartSafeCrackingInterface")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "ForceLock")]
	[CalledBy(Type = typeof(OpenClose), Member = "StartSafeCrackingInterface")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnLockBroken")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "IsCurrentSafe")]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	public void EnableSafeCrackingInterface()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableSafeCrackingInterface()
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "OpenSafe")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void ExitInterfaceAndOpenSafe()
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "OnLockBroken")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "OnOpen")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeCracking), Member = "ExitInterfaceAndOpenSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OpenSafe(bool isImmediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void CloseSafe(bool isImmediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SafeCracking()
	{
	}
}
