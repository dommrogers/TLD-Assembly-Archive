using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Anxiety : MonoBehaviour
{
	private PanelReference<Panel_Subtitles> m_Subtitles;

	public LocalizedString m_NoSleepString;

	public LocalizedString m_NoPassTimeString;

	public LocalizedString m_AnxietyLocalizedString;

	public LocalizedString m_AnxietyDescription;

	public LocalizedString m_AnxietyTreatment;

	public string m_AnxietyIcon;

	public LocalizedString m_AnxietyCause;

	public bool m_CanPassTime;

	public float m_HealthLossPerMinute;

	public string m_AudioEvent;

	public float m_SubtitleDisplayTime;

	private uint m_AudioPlayingID;

	private bool m_HasAffliction;

	private static AnxietySaveDataProxy m_AnxietySaveDataProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string GetNoSleepString()
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

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionTreatment()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public string GetAfflictionCause()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetAfflictionDescription()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(PassTime), Member = "HasFearOrAnxiety")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Rest), Member = "IsFearOrAnxietyPreventingSleep")]
	public bool CanPassTime()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetNoPassTimeString()
	{
		return null;
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public void StartAffliction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	public void StopAffliction(bool silent)
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODMinutes")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public Anxiety()
	{
	}
}
