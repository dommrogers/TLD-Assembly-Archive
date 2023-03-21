using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Story : Panel_Base
{
	internal class JumpNavTree
	{
		public List<JumpNavTree> children;

		public List<JumpData> jumplist;

		public JumpNavTree parent;

		public string name;

		[CalledBy(Type = typeof(Panel_Story), Member = "BuildChallengeTree")]
		[CalledBy(Type = typeof(Panel_Story), Member = "BuildSandboxTree")]
		[CalledBy(Type = typeof(Panel_Story), Member = "BuildStoryTree")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		public void AddChild(JumpNavTree child)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public JumpNavTree()
		{
		}
	}

	public enum StoryMenuState
	{
		MainState,
		SelectSlot
	}

	[Serializable]
	public class StoryMenuItem
	{
		public enum MenuType
		{
			NewStory,
			LoadStory,
			ResumeStory
		}

		public MenuType m_Type;

		public string m_LabelLocalizationId;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public StoryMenuItem()
		{
		}
	}

	[Serializable]
	public class MissionJumpDisplayInfo
	{
		public string m_Description;

		public string m_MissionString;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public MissionJumpDisplayInfo(string missionString, string description)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<JumpData, bool> _003C_003E9__5_0;

		public static Func<JumpData, bool> _003C_003E9__7_0;

		public static Func<JumpData, bool> _003C_003E9__8_0;

		public static Func<JumpData, string> _003C_003E9__8_2;

		public static Func<JumpData, DateTime> _003C_003E9__17_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CBuildChallengeTree_003Eb__5_0(JumpData jmp)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CBuildSandboxTree_003Eb__7_0(JumpData jmp)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CBuildStoryTree_003Eb__8_0(JumpData jmp)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003CBuildStoryTree_003Eb__8_2(JumpData jmp)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal DateTime _003CSortJumpData_003Eb__17_0(JumpData jmp)
		{
			return default(DateTime);
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Episode currentEpisode;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CBuildStoryTree_003Eb__1(JumpData jmp)
		{
			return false;
		}
	}

	private JumpNavTree m_CurrentNav;

	private JumpNavTree m_TreeRoot;

	private List<JumpData> m_JumpList;

	private bool m_AsyncLoadCompleted;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_StoryEnabledObj;

	public GameObject m_StoryDisabledObj;

	public GameObject m_TopMenuStoryObj;

	public GameObject m_MainStoryObject;

	public ScrollList m_ScrollList;

	public UILabel m_MissionJumpDescription;

	public UILabel m_CategoryLabel;

	public GameObject m_ThumbnailDefault;

	public UITexture m_ThumbnailTexture;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	public List<StoryMenuItem> m_MenuItems;

	public UILabel m_CloudMessageLabel;

	public GameObject m_SwitchViewButton;

	public UILabel m_LoadingDisplay;

	private BasicMenu m_BasicMenu;

	private CloudMenuExtension m_CloudMenuExtension;

	private StoryMenuState m_MenuState;

	private string m_NewGameMissionJumpString;

	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateAsyncLoading")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[Calls(Type = typeof(Panel_Story), Member = "SortJumpData")]
	[Calls(Type = typeof(JumpNavTree), Member = "AddChild")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void BuildChallengeTree()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Story), Member = "LoadAllJumpData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void BuildJumpTree()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateAsyncLoading")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[Calls(Type = typeof(Panel_Story), Member = "SortJumpData")]
	[Calls(Type = typeof(JumpNavTree), Member = "AddChild")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void BuildSandboxTree()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateAsyncLoading")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[Calls(Type = typeof(JumpNavTree), Member = "AddChild")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Enumerable), Member = "GroupBy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enumerable), Member = "First")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Story), Member = "SortJumpData")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 78)]
	private void BuildStoryTree()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void CancelAsyncLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanSwitchView()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private void Cleanup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(JumpManager), Member = "Load")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DoFileJump()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private string GetFileJumpCategory()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void NavigateDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[CallsUnknownMethods(Count = 1)]
	private bool OnJumpBack()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "NavigateDown")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnJumpBack")]
	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateJumpMenu")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Story), Member = "UpdateSelectedJump")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 31)]
	private void SetupJumpScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "BuildChallengeTree")]
	[CalledBy(Type = typeof(Panel_Story), Member = "BuildSandboxTree")]
	[CalledBy(Type = typeof(Panel_Story), Member = "BuildStoryTree")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private List<JumpData> SortJumpData(IEnumerable<JumpData> jumplist)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "BuildJumpTree")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	private void LoadAllJumpData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnJumpLoadComplete(List<JumpData> jumps)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Story), Member = "BuildStoryTree")]
	[Calls(Type = typeof(Panel_Story), Member = "BuildSandboxTree")]
	[Calls(Type = typeof(Panel_Story), Member = "BuildChallengeTree")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAsyncLoading()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateJumpButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInteractPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateJumpMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SaveGameSystem), Member = "CreateTextureData")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateSelectedJump()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void ProcessCheat()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "AddMenuItem")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public Action GetActionFromType(StoryMenuItem.MenuType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[Calls(Type = typeof(Panel_Story), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Story), Member = "GetActionFromType")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Story), Member = "UpdateMainState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateMainState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ScrollUp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ScrollDown()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	public override void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void OnStartButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnBack()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private VoicePersona GetStoryGender()
	{
		return default(VoicePersona);
	}

	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "OnNameStoryConfirmed")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeMenuItem")]
	[Calls(Type = typeof(StatsManager), Member = "Reset")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Story), Member = "GetStoryGender")]
	[Calls(Type = typeof(Utils), Member = "SendGameStartAnalyticsEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	public void OnNewEpisode(string saveDisplayName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "RunInitCommandStory")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnNewEpisodeFadeCallback()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void OnMissionJump()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickResume")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Story), Member = "LoadStory")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool OnLoadStory(SaveSlotInfo ssi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void LoadStorySaveSlot(SaveSlotInfo ssi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void DeserializeStoryManagerCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EnterMenuState(StoryMenuState newState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNotEnoughSaveSlotsAvailableNotification")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void OnClickNew()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnClickLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickResume()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickBack()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void OnDoubleClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void OnSwitchView()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "RunInitCommandStory")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(Panel_Story), Member = "LoadStorySaveSlot")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void LoadStory(SaveSlotInfo ssi)
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(StatsManager), Member = "Reset")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "RunInitCommandStory")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeMenuItem")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(Panel_Story), Member = "GetStoryGender")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void LoadStoryForMigration(SaveSlotInfo ssi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Panel_Story()
	{
	}
}
