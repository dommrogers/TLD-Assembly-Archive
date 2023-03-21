using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ProfileState
{
	[Serializable]
	public class MaineMenuViewedState
	{
		public bool m_ChallengesMenuViewed;

		public bool m_LogsMenuViewed;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public MaineMenuViewedState()
		{
		}
	}

	public int m_Version;

	public bool m_ShowTimeOfDaySlider;

	public bool m_ShowFrametime;

	public float m_MasterVolume;

	public float m_SoundVolume;

	public float m_MusicVolume;

	public float m_VoiceVolume;

	public PanningRule m_PanningRule;

	public int m_QualityLevel;

	public GraphicsMode m_GraphicsMode;

	public int m_DisplayNumber;

	public Resolution m_Resolution;

	public bool m_SSAOEnabled;

	public MeasurementUnits m_Units;

	public HudPref m_HudPref;

	public HudSize m_HudSize;

	public HudType m_HudType;

	public bool m_InvertY;

	public bool m_InvertX;

	public bool m_LockMouseToScreen;

	public bool m_EnableGamepad;

	public Vector2 m_MouseSensitivity;

	public Vector2 m_ZoomSensitivity;

	public Vector2 m_AnalogSticksSensitivity;

	public float m_MouseSensitivityPercentage;

	public float m_ZoomSensitivityPercentage;

	public float m_GamepadCameraSensitivityPercentage;

	public bool m_ConsoleUnlocked;

	public float m_FieldOfView;

	public int m_NumGamesPlayed;

	public VoicePersona m_VoicePersona;

	public Dictionary<string, string> m_KeyBindings;

	public bool m_VsyncEnabled;

	public SubtitlesState m_SubtitlesState;

	public LanguageState m_LanguageState;

	public string m_Language;

	public bool m_CoastalRegionLocked;

	public bool m_RuralRegionLocked;

	public bool m_WhalingStationRegionLocked;

	public bool m_CrashMountainRegionLocked;

	public bool m_FrameDumperUnlocked;

	public bool m_HasSeenIntroVideo;

	public List<string> m_RewiredKeyboardMap;

	public List<string> m_RewiredMouseMap;

	public bool m_NoResumeSave;

	public string m_AllTimeStats;

	public List<SandboxRecord> m_SandboxRecords;

	public bool m_SendUserReports;

	public bool m_SendTelemetryData;

	public int m_ChangelistValidatedAgainst;

	public List<UpSell> m_UpsellsViewed;

	public float m_BestTimeHunted;

	public float m_BestTimeRescue;

	public float m_BestTimeWhiteout;

	public float m_BestTimeNomad;

	public float m_BestTimeHunted2;

	public float m_BestTimeArchivist;

	public float m_BestTimeDeadMan;

	public float m_BestTimeNowhereToHide;

	public ExperienceModeType m_MostRecentSandboxMode;

	public ExperienceModeType m_MostRecentChallengeMode;

	public ExperienceModeType m_MostRecentEpisodeMode;

	public float m_Brightness;

	public float m_PaperWhite;

	public float m_PeakBrightness;

	public bool m_DoneBrightnessAdjustment;

	public List<string> m_UnlockedBadgesViewed;

	public HashSet<string> m_CinematicsViewed;

	public string m_FeatsSerialized;

	public string m_EpisodeManagerSerialized;

	public string m_QualityLevelSettingsSerialized;

	public bool m_DisableClickHold;

	public int m_AutosaveMinutes;

	public string m_NewGameCustomModeString;

	public bool m_FoundAllCachesEpisodeOne;

	public bool m_FoundAllCachesEpisodeTwo;

	public List<Achievement> m_UnlockedAchievements;

	public bool m_ReduceCameraMotion;

	public bool m_LargeSubtitles;

	public bool m_AccessibleStruggle;

	public bool m_MouseSmoothing;

	public bool m_WolfMeterEnabled;

	public bool m_ShowStoryPlayerPosition;

	public bool m_AutoWalkEnabled;

	public bool m_SwearFilterEnabled;

	public bool m_MisophoniaFilterEnabled;

	public bool m_LockFPSAt30;

	public HashSet<string> m_ViewedNotifications;

	public List<bool> m_DaysCompleted4DON;

	public List<bool> m_DaysCompleted4DON2019;

	public string m_SteamCloudToken;

	public bool m_SteamCloudSyncSavesEnabled;

	public List<int> m_CanadianFeastFoodEaten;

	public bool m_UnlockedBadgeWE2020CanadianFeast;

	public bool m_UnlockedBadgeWE2020WinterInJuly;

	public bool m_UnlockedBadgeN2H2020Badge1;

	public bool m_UnlockedBadgeN2H2020Badge2;

	public long m_LastValidUtcTicks;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 52)]
	public ProfileState()
	{
	}
}
