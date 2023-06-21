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
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionCause()
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

	[CalledBy(Type = typeof(PassTime), Member = "HasFearOrAnxiety")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(Rest), Member = "IsFearOrAnxietyPreventingSleep")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanPassTime()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetNoPassTimeString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 2)]
	public void StartAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 2)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
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
	public Anxiety()
	{
	}
}
