using System;
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

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	public void Start()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "IsCurrentSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsOpen()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(OpenClose), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	private float GetDialDelta()
	{
		return default(float);
	}

	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(SafeCracking), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(SafeCracking), Member = "HitTick")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(SafeCracking), Member = "GetDialDelta")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	public void UpdateDial()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[CalledBy(Type = typeof(SafeCracking), Member = "ResetSafe")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CalledBy(Type = typeof(SafeCracking), Member = "Start")]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "SetTumblerStatus")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	private void ResetTumblers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	[CallsUnknownMethods(Count = 1)]
	private void UnlockSafe()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "SetTumblerStatus")]
	private void UnlockCurrentTumbler()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[Calls(Type = typeof(SafeCracking), Member = "PlayResetTumblersSound")]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[Calls(Type = typeof(SafeCracking), Member = "UnlockCurrentTumbler")]
	[Calls(Type = typeof(SafeCracking), Member = "PlayDialSpinClick")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	[Calls(Type = typeof(SafeCracking), Member = "PlayResetTumblersSound")]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void HitTick(float deltaDegrees)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	private void ResetSafe()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void PlayDialSpinClick()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayResetTumblersSound()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void PlaySafeClickSound()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayTumblerFallSound()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private int TickToDialNumber(float tick)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(OpenClose), Member = "OnLockBroken")]
	[CalledBy(Type = typeof(OpenClose), Member = "StartSafeCrackingInterface")]
	[CalledBy(Type = typeof(OpenClose), Member = "ForceLock")]
	[CalledBy(Type = typeof(Container), Member = "StartSafeCrackingInterface")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "IsCurrentSafe")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	public void EnableSafeCrackingInterface()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableSafeCrackingInterface()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SafeCracking), Member = "OpenSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public void ExitInterfaceAndOpenSafe()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SafeCracking), Member = "ExitInterfaceAndOpenSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnLockBroken")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "OnOpen")]
	[CallsUnknownMethods(Count = 1)]
	public void OpenSafe(bool isImmediate)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void CloseSafe(bool isImmediate)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public SafeCracking()
	{
	}
}
