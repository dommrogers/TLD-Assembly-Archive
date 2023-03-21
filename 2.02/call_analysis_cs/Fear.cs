using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Fear : MonoBehaviour
{
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
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
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

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public string GetAfflictionTreatment()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionDescription()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionCause()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 12)]
	public void StartAffliction()
	{
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CallsUnknownMethods(Count = 3)]
	public void StopAffliction(bool silent)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODMinutes")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Fear()
	{
	}
}
