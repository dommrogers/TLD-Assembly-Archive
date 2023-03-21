using System;
using System.Collections.Generic;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using UnityEngine;

public class Panel_Subtitles : Panel_AutoReferenced
{
	private const string CENSORED_ID_SUFFIX = "_PG";

	private const string SPEAKER_FORMAT = "[c]{2}[{0}]:[-] {3}{1}[-][/c]";

	private const string SPEAKER_ID_PREFIX = "_SM";

	private const int SPEAKER_ID_LENGTH = 3;

	private static readonly string[] AUDIO_EVENT_REPLACEMENTS;

	private const string AUDIO_PREFIX_PLAY = "Play_";

	private const string AUDIO_PREFIX_SNDVO = "SndVO";

	public Color m_DefaultSubtitleColor;

	public UILabel m_Label_Subtitles;

	public UISprite m_Background_Subtitles;

	public UILabel m_Label_Subtitles_Oversized;

	public UISprite m_Background_Subtitles_Oversized;

	public int m_SubtitleSizeNormal;

	public int m_SubtitleSizeLarge;

	public int m_MaximumSubtitleLineCount;

	public Episode m_EarliestEnabledEpisode;

	public LocalizedString m_UnknownSpeakerName;

	public SubtitleSpeakerMapping[] m_SpeakerMapping;

	public GameObject m_SpeakerLabelGameObject;

	public UILabel m_SpeakerLabel;

	public UISprite m_PhoneIcon;

	public UISprite m_CommSpeakerIcon;

	public UISprite m_SpeakerBackground;

	public UISprite m_IconBackground;

	private Dictionary<string, SubtitleSpeakerMapping> m_SpeakerMappingDict;

	private float m_TimeToHideSubtitles;

	private bool m_IsUnknownSpeaker;

	private static readonly int s_Stop;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "FadeSpeakerName")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetIsUnknownSpeaker(bool isUnknownSpeaker)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[CalledBy(Type = typeof(PlayableBehaviourSubtitle), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CalledBy(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	public bool ShowSubtitles(string locID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public bool ShowSubtitles(string locID, float duration)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	public void ShowSubtitlesForced(string locID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	public void ShowSubtitlesForced(string locID, float duration)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitlesForced")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitlesForced")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	private void DisplaySubtitleText(string locID)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string FormatSubtitleText(string locID)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	private bool ShouldShowSpeakerName(string _)
	{
		return default(bool);
	}

	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "AnySpeaking")]
	[CallsUnknownMethods(Count = 4)]
	public void HideSubtitles(float secondsUntilHide = 0.5f)
	{
	}

	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Update")]
	[CalledBy(Type = typeof(PlayableBehaviourSubtitle), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Start")]
	public void HideSubtitlesImmediate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	public void EnableLargeSubtitles(bool enableLargeSubtitles)
	{
	}

	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(VoiceTracker), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeForceSubtitles")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerCough), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(NPCVoice), Member = "MaybeForceSubtitles")]
	[CalledBy(Type = typeof(Fear), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(Anxiety), Member = "OnAkVoiceEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "LocIdFromEvent")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "OnAkVoiceEvent")]
	public bool MaybeShowSubtitleForAudioEvent(string eventName, bool forced)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TLD_SayTrack), Member = "RefreshClips")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 2)]
	public static string LocIdFromEvent(string eventName, out string audioPrefix)
	{
		audioPrefix = null;
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CalledBy(Type = typeof(PlayableBehaviourSpeakerName), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "GetSpeakerMappingFromLocID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void ShowSpeakerNameDuringPhoneCalls(string locID, bool isCommunitySpeaker)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayableBehaviourSpeakerName), Member = "OnBehaviourPause")]
	[CallsUnknownMethods(Count = 2)]
	public void HideSpeakerName()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void FadeSpeakerName(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "GetSpeakerMappingFromLocID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetSpeakerName(string locID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSubtitleClosedCaptioning(string locID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "GetSpeakerName")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSpeakerNameDuringPhoneCalls")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private SubtitleSpeakerMapping GetSpeakerMappingFromLocID(string locID)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "OnAkVoiceEvent")]
	[CallsUnknownMethods(Count = 3)]
	public bool AreSubtitlesVisible()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Panel_Subtitles()
	{
	}
}
