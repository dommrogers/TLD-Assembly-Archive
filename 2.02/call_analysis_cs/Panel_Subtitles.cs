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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "FadeSpeakerName")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetIsUnknownSpeaker(bool isUnknownSpeaker)
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StartSingleRing")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[CalledBy(Type = typeof(PlayableBehaviourSubtitle), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "IsSubtitleClosedCaptioning")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool ShowSubtitles(string locID)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "IsSubtitleClosedCaptioning")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool ShowSubtitles(string locID, float duration)
	{
		return false;
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

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitlesForced")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitlesForced")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void DisplaySubtitleText(string locID)
	{
	}

	[CalledBy(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "IsSubtitleClosedCaptioning")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "GetSpeakerMappingFromLocID")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Utils), Member = "ColorToHex")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	private string FormatSubtitleText(string locID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "IsSubtitleClosedCaptioning")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldShowSpeakerName(string locID)
	{
		return false;
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "AnySpeaking")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void HideSubtitles(float secondsUntilHide = 0.5f)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Update")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[CalledBy(Type = typeof(PlayableBehaviourSubtitle), Member = "OnBehaviourPause")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void HideSubtitlesImmediate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableLargeSubtitles(bool enableLargeSubtitles)
	{
	}

	[CalledBy(Type = typeof(Anxiety), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(Fear), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(NPCVoice), Member = "MaybeForceSubtitles")]
	[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerCough), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeForceSubtitles")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "OnAkVoiceEvent")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "LocIdFromEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool MaybeShowSubtitleForAudioEvent(string eventName, bool forced)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CalledBy(Type = typeof(TLD_SayTrack), Member = "RefreshClips")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static string LocIdFromEvent(string eventName, out string audioPrefix)
	{
		audioPrefix = null;
		return null;
	}

	[CalledBy(Type = typeof(PlayableBehaviourSpeakerName), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "GetSpeakerMappingFromLocID")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public void ShowSpeakerNameDuringPhoneCalls(string locID, bool isCommunitySpeaker)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void HideSpeakerName()
	{
	}

	[CalledBy(Type = typeof(Panel_Subtitles), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void FadeSpeakerName(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "GetSpeakerMappingFromLocID")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetSpeakerName(string locID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShouldShowSpeakerName")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSubtitleClosedCaptioning(string locID)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShowSpeakerNameDuringPhoneCalls")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "GetSpeakerName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private SubtitleSpeakerMapping GetSpeakerMappingFromLocID(string locID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "OnAkVoiceEvent")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool AreSubtitlesVisible()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public Panel_Subtitles()
	{
	}
}
