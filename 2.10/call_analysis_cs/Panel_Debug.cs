using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.OptionalContent;
using TLD.SaveState;
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
		[CalledBy(Type = typeof(DebugElement), Member = ".ctor")]
		[CalledBy(Type = typeof(DebugElement), Member = ".ctor")]
		[CallerCount(Count = 4)]
		private DebugElement(string name, string setName, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(DebugElement), Member = ".ctor")]
		public DebugElement(string name, string setName, string initial, string[] options, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DebugElement), Member = ".ctor")]
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 9)]
		public void AssignComboBox(ConsoleComboBox comboBox)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public bool OnApply()
		{
			return false;
		}
	}

	public class Location
	{
		public string m_Scene;

		public Vector3 m_Coordinates;

		public string m_LocId;

		public string m_EnglishLocationName;

		[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationLookup")]
		[CallerCount(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Debug), Member = "GenerateLocationLookup")]
	[Calls(Type = typeof(Panel_Debug), Member = "GenerateLocationList")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 168)]
	private void InitializeOptions()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void InitializeSet()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_AutoReferenced), Member = "Awake")]
	protected override void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsUnknownMethods(Count = 2)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetLineActive(int index, bool state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyTerrainTrees(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyInstanceTrees(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyRenderObjectInstances(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyFarElectrolyzerOptim(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyAiFrustimCulling(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyFilterWorldLightsForFp(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(Utils), Member = "EnableShadows")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyShadows(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplySpecular(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyDebugTerrain(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[CallsUnknownMethods(Count = 3)]
	private bool ApplyTerrainPixelError(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool ApplyToggleVsync(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	private static string[] PopulateAchievements()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private bool UnlockAchievement(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private static bool UnlockEpisode(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Map), Member = "ClearData")]
	[Calls(Type = typeof(MapDetailManager), Member = "LockAll")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ApplySurvey(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 93)]
	private string[] PopulateLoadZoneOptions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 425)]
	private string[] PopulateLoadInteriorOptions()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(Location), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void GenerateLocationLookup()
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void GenerateLocationList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Debug), Member = "PopulateTimelineOptions")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsUnknownMethods(Count = 1)]
	public string[] PopulateTimelineOptionsToArray()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "PopulateTimelineOptionsToArray")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "FindAllAssetsLocations")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public static List<string> PopulateTimelineOptions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsUnknownMethods(Count = 1)]
	private string[] PopulateLoadLocationOptions()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	private bool ApplyLoadLocationLoad(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyShowTODSlider(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetFilenameList")]
	private string[] PopulateMovieOptions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	private bool ApplyPlayMovie(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	private bool ApplyPlayTimeline(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyShowDaysSurvived(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool Toggle4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool OverrideDay4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool TransitionToDay4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool CompleteTimer4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool ResetBadgeProgress4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableSpecialEvent(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_breath")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimBreathing(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_sway")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimSway(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_stamina")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimStamina(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_shake")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimShake(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAmbientSway(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimDepthOfField(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_breath")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_sway")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_stamina")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_shake")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAllAimingMotion(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Parse")]
	[CallsUnknownMethods(Count = 1)]
	private bool ChangeSteamControllerMenuScrollSensitivity(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private string[] PopulateSaveFiles()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameManager), Member = "LoadGame")]
	[CallsUnknownMethods(Count = 3)]
	private bool LoadSelectedSave(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsUnknownMethods(Count = 1)]
	private bool DeleteSelectedSave(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CallsUnknownMethods(Count = 1)]
	private bool OverwriteSelectedSave(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "InitializeAsync")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyInitializeDLC(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_dlc_list_known_content")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyListKnownDLC(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_dlc_list_available_content")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyListAvailableDLC(ConsoleComboBox comboBox)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Debug()
	{
	}
}
