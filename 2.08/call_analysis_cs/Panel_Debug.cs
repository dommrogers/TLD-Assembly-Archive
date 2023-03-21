using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.OptionalContent;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_Debug : Panel_AutoReferenced
{
	public class DebugElement
	{
		public string m_Name;

		public string m_SetName;

		public string m_Initial;

		public string[] m_Options;

		private Func<ConsoleComboBox, bool> m_OnApplyDelegate;

		private Func<string[]> m_PopulateOptionsDelegate;

		private Func<string> m_GetInitialValueDelegate;

		private ConsoleComboBox m_ConsoleComboBox;

		[CalledBy(Type = typeof(DebugElement), Member = ".ctor")]
		[CalledBy(Type = typeof(DebugElement), Member = ".ctor")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(DebugElement), Member = ".ctor")]
		[CalledBy(Type = typeof(DebugElement), Member = ".ctor")]
		private DebugElement(string name, string setName, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[Calls(Type = typeof(DebugElement), Member = ".ctor")]
		[CallerCount(Count = 16)]
		public DebugElement(string name, string setName, string initial, string[] options, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[Calls(Type = typeof(DebugElement), Member = ".ctor")]
		[CallerCount(Count = 3)]
		public DebugElement(string name, string setName, string initial, Func<string[]> populateOptionsDelegate, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugElement), Member = ".ctor")]
		public DebugElement(string name, string setName, Func<string> getInitialValueDelegate, string[] options, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugElement), Member = ".ctor")]
		public DebugElement(string name, string setName, Func<string> getInitialValueDelegate, Func<string[]> populateOptionsDelegate, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[CallsUnknownMethods(Count = 9)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		public void AssignComboBox(ConsoleComboBox comboBox)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public bool OnApply()
		{
			return default(bool);
		}
	}

	public class Location
	{
		public string m_Scene;

		public Vector3 m_Coordinates;

		public string m_LocId;

		public string m_EnglishLocationName;

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationLookup")]
		public Location(string scene, Vector3 coordinates, string locId, string englishLocaitonName)
		{
		}
	}

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_Map> m_Map;

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	public Texture m_DebugAiBackgroundTexture;

	private bool m_ResumeGameOnExit;

	private static Panel_Debug s_Instance;

	public ConsoleComboBox[] m_ComboBoxes;

	private List<DebugElement> m_Elements;

	private Dictionary<string, List<DebugElement>> m_SetDictionary;

	private List<string> m_SetNames;

	public float m_MenuItemSpacing;

	public List<string> m_LocationList;

	public Dictionary<string, List<Location>> m_LocationLookup;

	[CalledBy(Type = typeof(Panel_Debug), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 168)]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(Panel_Debug), Member = "GenerateLocationLookup")]
	[Calls(Type = typeof(Panel_Debug), Member = "GenerateLocationList")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	private void InitializeOptions()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void InitializeSet()
	{
	}

	[Calls(Type = typeof(Panel_AutoReferenced), Member = "Awake")]
	[CallerCount(Count = 0)]
	protected override void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
	[CallerCount(Count = 0)]
	protected override void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnBack()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ExitDebugPanel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDebugPanelNav()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void SetLineActive(int index, bool state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyTerrainTrees(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	private bool ApplyInstanceTrees(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool ApplyRenderObjectInstances(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyFarElectrolyzerOptim(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool ApplyAiFrustimCulling(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyFilterWorldLightsForFp(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "EnableShadows")]
	[Calls(Type = typeof(Utils), Member = "EnableShadows")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	private bool ApplyShadows(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplySpecular(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyDebugTerrain(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	private bool ApplyTerrainPixelError(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	private bool ApplyToggleVsync(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	private static string[] PopulateAchievements()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private bool UnlockAchievement(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	private static bool UnlockEpisode(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Map), Member = "ClearData")]
	[Calls(Type = typeof(MapDetailManager), Member = "LockAll")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	private bool ApplySurvey(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 93)]
	[CallerCount(Count = 0)]
	private string[] PopulateLoadZoneOptions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 409)]
	private string[] PopulateLoadInteriorOptions()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[Calls(Type = typeof(Location), Member = ".ctor")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	private void GenerateLocationLookup()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void GenerateLocationList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Debug), Member = "PopulateTimelineOptions")]
	[CallsUnknownMethods(Count = 1)]
	public string[] PopulateTimelineOptionsToArray()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "PopulateTimelineOptionsToArray")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	public static List<string> PopulateTimelineOptions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string[] PopulateLoadLocationOptions()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	private bool ApplyLoadLocationLoad(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool ApplyShowTODSlider(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetFilenameList")]
	private string[] PopulateMovieOptions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	private bool ApplyPlayMovie(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool ApplyPlayTimeline(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyShowDaysSurvived(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	private bool Toggle4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	private bool OverrideDay4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private bool TransitionToDay4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool CompleteTimer4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool ResetBadgeProgress4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	private bool DisableSpecialEvent(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_breath")]
	private bool DisableAimBreathing(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_sway")]
	[CallerCount(Count = 0)]
	private bool DisableAimSway(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_stamina")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimStamina(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_shake")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimShake(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool DisableAmbientSway(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimDepthOfField(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_shake")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_stamina")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_breath")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_sway")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool DisableAllAimingMotion(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool ChangeSteamControllerMenuScrollSensitivity(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CallsUnknownMethods(Count = 7)]
	private string[] PopulateSaveFiles()
	{
		return null;
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool LoadSelectedSave(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsUnknownMethods(Count = 1)]
	private bool DeleteSelectedSave(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool OverwriteSelectedSave(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyInitializeDLC(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_dlc_list_known_content")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool ApplyListKnownDLC(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_dlc_list_available_content")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyListAvailableDLC(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Debug()
	{
	}
}
