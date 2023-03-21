using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Debug : Panel_Base
{
	public class DebugElement
	{
		public string m_Name;

		public string m_SetName;

		public string m_Initial;

		public string[] m_Options;

		private Func<ConsoleComboBox, bool> m_OnApplyDelegate;

		private Func<string[]> m_PopulateOptionsDelegate;

		private ConsoleComboBox m_ConsoleComboBox;

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
		[CallerCount(Count = 13)]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
		public DebugElement(string name, string setName, string initial, string[] options, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public DebugElement(string name, string setName, string initial, Func<string[]> populateOptionsDelegate, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
		[Calls(Type = typeof(Transform), Member = "Find")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		public void AssignComboBox(ConsoleComboBox comboBox)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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

	public Texture m_DebugAiBackgroundTexture;

	public ConsoleComboBox[] m_ComboBoxes;

	private DebugElement[] m_Elements;

	private Dictionary<string, List<DebugElement>> m_SetDictionary;

	private List<string> m_SetNames;

	public float m_MenuItemSpacing;

	public List<string> m_LocationList;

	public Dictionary<string, List<Location>> m_LocationLookup;

	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	[CallsUnknownMethods(Count = 400)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "Enable")]
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
	[Calls(Type = typeof(Panel_Debug), Member = "GenerateLocationList")]
	[Calls(Type = typeof(Panel_Debug), Member = "GenerateLocationLookup")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugElement), Member = ".ctor")]
	private void InitializeOptions()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void InitializeSet()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsUnknownMethods(Count = 2)]
	public override void Enable(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnCancel()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 0)]
	public void OnBack()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ExitDebugPanel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 10)]
	private void SetLineActive(int index, bool state)
	{
	}

	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "ForceDisableTerrainTrees")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool ApplyTerrainTrees(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableCategory")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsCategoryEnabled")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	private bool ApplyInstanceTrees(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EnableAll")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool ApplyRenderObjectInstances(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyFarElectrolyzerOptim(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool ApplyAiFrustimCulling(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	private bool ApplyFilterWorldLightsForFp(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "EnableShadows")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "EnableShadows")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private bool ApplyShadows(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplySpecular(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ApplyDebugTerrain(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[CallsUnknownMethods(Count = 5)]
	private bool ApplyTerrainPixelError(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool ApplyToggleVsync(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string[] PopulateAchievements()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	private bool UnlockAchievement(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetState")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private static bool UnlockEpisode(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(MapDetailManager), Member = "LockAll")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[Calls(Type = typeof(Panel_Map), Member = "ClearData")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private bool ApplySurvey(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 89)]
	private string[] PopulateLoadZoneOptions()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 409)]
	[CallerCount(Count = 0)]
	private string[] PopulateLoadInteriorOptions()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "TrimEnd")]
	[CallsUnknownMethods(Count = 80)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(string), Member = "TrimStart")]
	[Calls(Type = typeof(string), Member = "TrimStart")]
	[Calls(Type = typeof(string), Member = "TrimStart")]
	[Calls(Type = typeof(Location), Member = ".ctor")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(string), Member = "TrimStart")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void GenerateLocationLookup()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "InitializeOptions")]
	[CallsUnknownMethods(Count = 27)]
	public void GenerateLocationList()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Debug), Member = "PopulateTimelineOptions")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public string[] PopulateTimelineOptionsToArray()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "PopulateTimelineOptionsToArray")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 15)]
	public static List<string> PopulateTimelineOptions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string[] PopulateLoadLocationOptions()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool ApplyLoadLocationLoad(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_show_tod_slider")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ApplyShowTODSlider(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "GetFilenameList")]
	private string[] PopulateMovieOptions()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyPlayMovie(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(TimelineRef), Member = "LoadForPlayerDirector")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool ApplyPlayTimeline(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_show_days_survived")]
	[CallsUnknownMethods(Count = 1)]
	private bool ApplyShowDaysSurvived(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool Toggle4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool OverrideDay4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool TransitionToDay4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool CompleteTimer4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 1)]
	private bool ResetBadgeProgress4DON(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	private bool DisableSpecialEvent(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_breath")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimBreathing(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_sway")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool DisableAimSway(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_stamina")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimStamina(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_shake")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableAimShake(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool DisableAmbientSway(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "NextParameterIsBool")]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	[CallsUnknownMethods(Count = 3)]
	private bool DisableAimDepthOfField(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_breath")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_ambient_sway")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_shake")]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_stamina")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_aim_sway")]
	private bool DisableAllAimingMotion(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ChangeSteamControllerMenuScrollSensitivity(ConsoleComboBox comboBox)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 15)]
	public Panel_Debug()
	{
	}
}
