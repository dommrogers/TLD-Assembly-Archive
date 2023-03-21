using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Fear : MonoBehaviour
{
	private PanelReference<Panel_Subtitles> m_Subtitles;

	public LocalizedString m_NoSleepString;

	public LocalizedString m_NoPassTimeString;

	public LocalizedString m_FearLocalizedString;

	public LocalizedString m_FearDescription;

	public LocalizedString m_FearTreatment;

	public string m_FearIcon;

	public LocalizedString m_FearCause;

	public bool m_CanPassTime;

	public float m_HealthLossPerMinute;

	public string m_AudioEvent;

	public float m_SubtitleDisplayTime;

	private uint m_AudioPlayingID;

	private bool m_HasAffliction;

	private static FearSaveDataProxy m_FearSaveDataProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetNoSleepString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanPassTime()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetNoPassTimeString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionLocId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public string GetAfflictionTreatment()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionDescription()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionCause()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public void StartAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 2)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopAffliction(bool silent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODMinutes")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public Fear()
	{
	}
}
