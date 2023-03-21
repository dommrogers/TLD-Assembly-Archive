using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_SafeCracking> m_SafeCracking;

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

	private Action m_OnSafeOpened;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	public void Start()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "IsCurrentSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsOpen()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(OpenClose), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(OpenClose), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	private float GetDialDelta()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(SafeCracking), Member = "HitTick")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(SafeCracking), Member = "GetDialDelta")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	public void UpdateDial(Panel_SafeCracking safeCracking)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[CalledBy(Type = typeof(SafeCracking), Member = "ResetSafe")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CalledBy(Type = typeof(SafeCracking), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	private void ResetTumblers(Panel_SafeCracking safeCracking)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	[CallsUnknownMethods(Count = 1)]
	private void UnlockSafe()
	{
	}

	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "SetTumblerStatus")]
	private void UnlockCurrentTumbler(Panel_SafeCracking safeCracking)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SafeCracking), Member = "UpdateDial")]
	[Calls(Type = typeof(SafeCracking), Member = "UnlockCurrentTumbler")]
	[Calls(Type = typeof(SafeCracking), Member = "PlayResetTumblersSound")]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[Calls(Type = typeof(SafeCracking), Member = "PlayDialSpinClick")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(SafeCracking), Member = "PlayResetTumblersSound")]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	private void HitTick(Panel_SafeCracking safeCracking, float deltaDegrees)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	private void ResetSafe(Panel_SafeCracking safeCracking)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void PlayDialSpinClick()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CalledBy(Type = typeof(SafeCracking), Member = "HitTick")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayResetTumblersSound()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlaySafeClickSound()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayTumblerFallSound()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int TickToDialNumber(float tick)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "EnableOpenSafeButton")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SafeCracking), Member = "IsCurrentSafe")]
	[CallsDeduplicatedMethods(Count = 5)]
	public void EnableSafeCrackingInterface(Action safeOpenedCallback = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void DisableSafeCrackingInterface()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "OnOpen")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "Update")]
	[CalledBy(Type = typeof(SafeCracking), Member = "OpenSafe")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "ClearLastUnequippedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void ExitInterfaceAndOpenSafe()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeCracking), Member = "ExitInterfaceAndOpenSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	public void OpenSafe(bool isImmediate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void CloseSafe(bool isImmediate)
	{
	}

	[CallerCount(Count = 0)]
	public SafeCracking()
	{
	}
}
