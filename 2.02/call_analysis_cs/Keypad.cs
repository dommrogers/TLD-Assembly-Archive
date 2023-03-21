using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Keypad : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public string m_ButtonPressingAudio;

	public string m_ButtonPressingAudioNoAurora;

	public string m_ButtonPressingWithCodeFailAudio;

	public string m_ButtonPressingWithSuccessAudio;

	public int m_Code;

	public bool m_Locked;

	public GameObject m_LockedFX;

	public GameObject m_UnlockedFX;

	public Light m_AttractionLight;

	private uint m_PlayingAudioID;

	private static List<Keypad> m_Keypads;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 15)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keypad), Member = "FindKeypadByPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	private bool CodeIsKnownByPlayer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnAkCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Keypad), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 5)]
	private static Keypad FindKeypadByPosition(Vector3 pos)
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Keypad()
	{
	}
}
