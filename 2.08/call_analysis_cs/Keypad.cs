using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Keypad : MonoBehaviour
{
	public Lock[] m_AttachedLocks;

	public string m_ButtonPressingAudio;

	public string m_ButtonPressingAudioNoAurora;

	public string m_ButtonPressingWithCodeFailAudio;

	public string m_ButtonPressingWithSuccessAudio;

	public int m_Code;

	public GameObject m_LockedFX;

	public GameObject m_UnlockedFX;

	public Light m_AttractionLight;

	private uint m_PlayingAudioID;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Keypad), Member = "IsLocked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Keypad), Member = "IsLocked")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Keypad), Member = "CodeIsKnownByPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Keypad), Member = "Update")]
	[CalledBy(Type = typeof(Keypad), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsLocked()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Keypad), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	private bool CodeIsKnownByPlayer()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsUnknownMethods(Count = 2)]
	private void OnAkCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Keypad()
	{
	}
}
