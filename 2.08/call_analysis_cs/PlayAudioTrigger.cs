using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class PlayAudioTrigger : MonoBehaviour
{
	public TimeToPlay m_TimeOfDayToPlay;

	public string m_AudioFirstTime;

	public string m_AudioSubsequentTimes;

	public bool m_PlayOnlyOnce;

	public GameObject m_ObjectLink;

	private int m_NumPlays;

	private uint m_AudioID;

	private uint m_NumUpdatesSinceSceneLoad;

	private bool m_DidObjectLink;

	private string m_ObjectLinkGuid;

	private bool m_StartHasBeenCalled;

	private static PlayMusicTriggerSaveDataProxy m_PlayMusicTriggerSaveDataProxy;

	private static List<PlayAudioTrigger> m_PlayAudioTriggers;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "Start")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(PlayAudioTrigger), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "FindPlayAudioTriggerByPosition")]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "FindPlayAudioTriggerByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void PlayAudioTriggerEndCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "OnTriggerEnter")]
	public void Play()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "Play")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private static PlayAudioTrigger FindPlayAudioTriggerByPosition(PlayMusicTriggerSaveDataProxy proxy)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	private static PlayAudioTrigger FindPlayAudioTriggerByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public PlayAudioTrigger()
	{
	}
}
