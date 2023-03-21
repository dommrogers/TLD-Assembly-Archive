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

		[CalledBy(Type = typeof(Panel_Story), Member = "BuildStoryTree")]
		[CalledBy(Type = typeof(Panel_Story), Member = "BuildStoryTree")]
		[CalledBy(Type = typeof(Panel_Story), Member = "BuildStoryTree")]
		[CalledBy(Type = typeof(Panel_Story), Member = "BuildSandboxTree")]
		[CallsUnknownMethods(Count = 9)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(Panel_Story), Member = "BuildChallengeTree")]
		[CallsDeduplicatedMethods(Count = 3)]
		public void AddChild(JumpNavTree child)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
		public StoryMenuItem()
		{
		}
	}

	[Serializable]
	public class MissionJumpDisplayInfo
	{
		public string m_Description;

		public string m_MissionString;

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal bool _003CBuildChallengeTree_003Eb__5_0(JumpData jmp)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal bool _003CBuildSandboxTree_003Eb__7_0(JumpData jmp)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CBuildStoryTree_003Eb__8_0(JumpData jmp)
		{
			return default(bool);
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CBuildStoryTree_003Eb__1(JumpData jmp)
		{
			return default(bool);
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
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(JumpNavTree), Member = "AddChild")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Story), Member = "SortJumpData")]
	private void BuildChallengeTree()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Story), Member = "LoadAllJumpData")]
	[CallsUnknownMethods(Count = 8)]
	private void BuildJumpTree()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateAsyncLoading")]
	[Calls(Type = typeof(JumpNavTree), Member = "AddChild")]
	[Calls(Type = typeof(Panel_Story), Member = "SortJumpData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void BuildSandboxTree()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateAsyncLoading")]
	[CallsUnknownMethods(Count = 78)]
	[Calls(Type = typeof(JumpNavTree), Member = "AddChild")]
	[Calls(Type = typeof(Panel_Story), Member = "SortJumpData")]
	[Calls(Type = typeof(JumpNavTree), Member = "AddChild")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JumpNavTree), Member = "AddChild")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void BuildStoryTree()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	private void CancelAsyncLoad()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	private bool CanSwitchView()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private void Cleanup()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(JumpManager), Member = "Load")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void DoFileJump()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	private string GetFileJumpCategory()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void NavigateDown()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[CallerCount(Count = 0)]
	private bool OnJumpBack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateJumpMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnJumpBack")]
	[CalledBy(Type = typeof(Panel_Story), Member = "NavigateDown")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Story), Member = "UpdateSelectedJump")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	private void SetupJumpScrollList()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Story), Member = "BuildChallengeTree")]
	[CalledBy(Type = typeof(Panel_Story), Member = "BuildSandboxTree")]
	[CalledBy(Type = typeof(Panel_Story), Member = "BuildStoryTree")]
	[CallsUnknownMethods(Count = 15)]
	private List<JumpData> SortJumpData(IEnumerable<JumpData> jumplist)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_Story), Member = "BuildJumpTree")]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	private void LoadAllJumpData()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	private void OnJumpLoadComplete(List<JumpData> jumps)
	{
	}

	[Calls(Type = typeof(Panel_Story), Member = "BuildChallengeTree")]
	[Calls(Type = typeof(Panel_Story), Member = "BuildSandboxTree")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Story), Member = "BuildStoryTree")]
	private void UpdateAsyncLoading()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateJumpButtonLegend()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[Calls(Type = typeof(InputManager), Member = "GetInteractPressed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void UpdateJumpMenu()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SaveGameSystem), Member = "CreateTextureData")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateSelectedJump()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void ProcessCheat()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Story), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 21)]
	public Action GetActionFromType(StoryMenuItem.MenuType type)
	{
		return null;
	}

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Panel_Story), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CalledBy(Type = typeof(Panel_Story), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Story), Member = "GetActionFromType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Story), Member = "UpdateMainState")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void UpdateMainState()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void ScrollUp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ScrollDown()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 14)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void OnStartButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	public void OnBack()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	private VoicePersona GetStoryGender()
	{
		return default(VoicePersona);
	}

	[Calls(Type = typeof(Utils), Member = "SendGameStartAnalyticsEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "OnNameStoryConfirmed")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Panel_Story), Member = "GetStoryGender")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(StatsManager), Member = "Reset")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeMenuItem")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	public void OnNewEpisode(string saveDisplayName)
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "RunInitCommandStory")]
	public void OnNewEpisodeFadeCallback()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnMissionJump()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickResume")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnSlotClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Story), Member = "LoadStory")]
	public bool OnLoadStory(SaveSlotInfo ssi)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStory")]
	[CallsUnknownMethods(Count = 14)]
	public void LoadStorySaveSlot(SaveSlotInfo ssi)
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	private void DeserializeStoryManagerCallback()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void EnterMenuState(StoryMenuState newState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNotEnoughSaveSlotsAvailableNotification")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	public void OnClickNew()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnClickLoad()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickResume()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnClickBack()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnDoubleClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnSwitchView()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Story), Member = "LoadStorySaveSlot")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "RunInitCommandStory")]
	private void LoadStory(SaveSlotInfo ssi)
	{
	}

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(Panel_Story), Member = "GetStoryGender")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Story), Member = "GetStoryGender")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "RunInitCommandStory")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeMenuItem")]
	[Calls(Type = typeof(StatsManager), Member = "Reset")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void LoadStoryForMigration(SaveSlotInfo ssi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Panel_Story()
	{
	}
}
