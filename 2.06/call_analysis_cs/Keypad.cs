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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Keypad), Member = "IsLocked")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keypad), Member = "CodeIsKnownByPlayer")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(Keypad), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsLocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(Keypad), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 8)]
	private bool CodeIsKnownByPlayer()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsUnknownMethods(Count = 2)]
	private void OnAkCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Keypad()
	{
	}
}
