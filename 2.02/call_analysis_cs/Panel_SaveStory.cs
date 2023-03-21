using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_SaveStory : Panel_Base
{
	[Serializable]
	public class AnimMenuItems
	{
		public GameObject m_Display;

		public Episode m_Type;

		public AnimationStateRef m_PlayOnSelect;

		public AnimationStateRef m_PlayOnDeselect;

		[NonSerialized]
		public int m_PlayOnSelectHash;

		[NonSerialized]
		public int m_PlayOnDeselectHash;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		public AnimMenuItems()
		{
		}
	}

	private enum AnimationState
	{
		None,
		Select,
		Deselect
	}

	private sealed class _003COnOverwriteConfirmedCoroutine_003Ed__56 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Panel_SaveStory _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003COnOverwriteConfirmedCoroutine_003Ed__56(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 19)]
		[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003COnQuicksaveCoroutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Panel_SaveStory _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003COnQuicksaveCoroutine_003Ed__58(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
		[Calls(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static string[] SPECIAL_SLOT_PREFIXES;

	private static string[] SPECIAL_SLOT_LOCIDS;

	private static int[] SPECIAL_SLOT_LIMITS;

	private static string[] STORY_SLOT_PREFIXES;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UtilsPanelChoose.DetailsObjets m_DetailObjects;

	public UILabel m_EpisodeValue;

	public UILabel m_ProgressValue;

	public List<AnimMenuItems> m_AnimMenuItems;

	public Animator m_Animator;

	public string m_TitleLocalizationId;

	public string m_TitleHeaderLocalizationId;

	public Vector3 m_TitleHeaderOffset;

	public GameObject m_BasicMenuRoot;

	public UILabel m_SlotsUsedLabel;

	public Color m_SlotsUsedColorNormal;

	public Color m_SlotsUsedColorFull;

	public GameObject m_MouseButtonDelete;

	public GameObject m_MouseButtonRename;

	public UILabel m_CloudMessageLabel;

	private SaveSlotInfo m_SlotToRename;

	private SaveSlotInfo m_SlotToDelete;

	private SaveSlotInfo m_SlotToOverwrite;

	private BasicMenu m_BasicMenu;

	private CloudSaveMenuExtension m_CloudSaveMenuExtension;

	private AnimationState m_CurrentEpisodeAnimationState;

	private const int INVALID_INDEX = -1;

	private const int ANIMATION_BASE_LAYER = 0;

	private int m_PreviousAnimIndex;

	private int m_TargetAnimIndex;

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "AddLineBreak")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	private void ConfigureMenu()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void AddSavesOfTypeToMenu(string[] slotPrefixes, string[] displayLocIds = null, int[] limits = null, bool showTimeSinceSave = false)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnClickBack()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void BackWithouSFX()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void ProcessMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 18)]
	public void OnRename()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnRenameExistingStoryCancelled(bool wasCancelled)
	{
	}

	[Calls(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void OnRenameExistingStoryConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowDeleteConfirmationPanel")]
	[CallsUnknownMethods(Count = 16)]
	public void OnDelete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DeleteSaveSlot()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetEpisodeGenericNameLocId")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	private void OnSlotClicked()
	{
	}

	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	private void OnNewSave()
	{
	}

	[CallerCount(Count = 0)]
	public void OnCancelled(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	private void OnNewSaveNamed()
	{
	}

	[Calls(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmedCoroutine")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "OnQuicksaveCoroutine")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnOverwriteConfirmed()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmed")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator OnOverwriteConfirmedCoroutine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CallsUnknownMethods(Count = 7)]
	private void OnOverwriteSaveNamed()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmed")]
	[CallerCount(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator OnQuicksaveCoroutine()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 6)]
	private void EnableSingleAnimItem(int targetIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private AnimMenuItems GetAnimMenuItem(int index)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsPlayingAnySelectionAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnyDeselectionAnimation")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnySelectionAnimation")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsPlayingAnimation(int stateHash)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void PlaySelectedAnimation(AnimMenuItems menuItem)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PlayDeselectedAnimation(AnimMenuItems menuItem)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "EnableSingleAnimItem")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "EnableSingleAnimItem")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetAnimMenuItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetAnimMenuItem")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	private void UpdateAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Panel_SaveStory()
	{
	}
}
