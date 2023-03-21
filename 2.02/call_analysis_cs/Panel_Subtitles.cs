using System.Collections.Generic;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Subtitles : Panel_Base
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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "FadeSpeakerName")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetIsUnknownSpeaker(bool isUnknownSpeaker)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayableBehaviourSubtitle), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "IsSubtitleClosedCaptioning")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Phone), Member = "StartSingleRing")]
	public bool ShowSubtitles(string locID)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "IsSubtitleClosedCaptioning")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 4)]
	public bool ShowSubtitles(string locID, float duration)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	public void ShowSubtitlesForced(string locID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	public void ShowSubtitlesForced(string locID, float duration)
	{
	}

	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitlesForced")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitlesForced")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void DisplaySubtitleText(string locID)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "GetSpeakerMappingFromLocID")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "IsSubtitleClosedCaptioning")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	private string FormatSubtitleText(string locID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "IsSubtitleClosedCaptioning")]
	private bool ShouldShowSpeakerName(string locID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NPCVoice), Member = "AnySpeaking")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 22)]
	public void HideSubtitles(float secondsUntilHide = 0.5f)
	{
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Update")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[CalledBy(Type = typeof(PlayableBehaviourSubtitle), Member = "OnBehaviourPause")]
	[CallsUnknownMethods(Count = 5)]
	public void HideSubtitlesImmediate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	public void EnableLargeSubtitles(bool enableLargeSubtitles)
	{
	}

	[CalledBy(Type = typeof(Fear), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerCough), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(NPCVoice), Member = "MaybeForceSubtitles")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(Anxiety), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeForceSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "LocIdFromEvent")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	public bool MaybeShowSubtitleForAudioEvent(string eventName, bool forced)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TLD_SayTrack), Member = "RefreshClips")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string LocIdFromEvent(string eventName, out string audioPrefix)
	{
		audioPrefix = null;
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayableBehaviourSpeakerName), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "GetSpeakerMappingFromLocID")]
	[CallsDeduplicatedMethods(Count = 5)]
	public void ShowSpeakerNameDuringPhoneCalls(string locID, bool isCommunitySpeaker)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public void HideSpeakerName()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void FadeSpeakerName(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "GetSpeakerMappingFromLocID")]
	private string GetSpeakerName(string locID)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShouldShowSpeakerName")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSubtitleClosedCaptioning(string locID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "GetSpeakerName")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSpeakerNameDuringPhoneCalls")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring")]
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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Panel_Subtitles()
	{
	}
}
