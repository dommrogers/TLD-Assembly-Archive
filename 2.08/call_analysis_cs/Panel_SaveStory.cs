using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_SaveStory : Panel_AutoReferenced
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

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	private sealed class _003COnOverwriteConfirmedCoroutine_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Panel_SaveStory _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
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
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
		[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
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
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
		[Calls(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDestroy()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Enable")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddLineBreak")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 6)]
	private void AddSavesOfTypeToMenu(string[] slotPrefixes, string[] displayLocIds = null, int[] limits = null, bool showTimeSinceSave = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void BackWithouSFX()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	private void ProcessMenu()
	{
	}

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallerCount(Count = 0)]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmed")]
	[CallsUnknownMethods(Count = 1)]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnRename()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnRenameExistingStoryCancelled(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void OnRenameExistingStoryConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowDeleteConfirmationPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDelete()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	private void DeleteSaveSlot()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[Calls(Type = typeof(EpisodeManager), Member = "GetEpisodeGenericNameLocId")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	private void OnSlotClicked()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	private void OnNewSave()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnCancelled(bool wasCancelled)
	{
	}

	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnNewSaveNamed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private void OnOverwriteConfirmed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003COnOverwriteConfirmedCoroutine_003Ed__56))]
	private IEnumerator OnOverwriteConfirmedCoroutine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CallsUnknownMethods(Count = 1)]
	private void OnOverwriteSaveNamed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(_003COnQuicksaveCoroutine_003Ed__58))]
	[CallerCount(Count = 0)]
	private IEnumerator OnQuicksaveCoroutine()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 3)]
	private void EnableSingleAnimItem(int targetIndex)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private AnimMenuItems GetAnimMenuItem(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnimation")]
	private bool IsPlayingAnySelectionAnimation()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnimation")]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnySelectionAnimation")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation(int stateHash)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PlaySelectedAnimation(AnimMenuItems menuItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayDeselectedAnimation(AnimMenuItems menuItem)
	{
	}

	[Calls(Type = typeof(Panel_SaveStory), Member = "GetAnimMenuItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "EnableSingleAnimItem")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetAnimMenuItem")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "EnableSingleAnimItem")]
	private void UpdateAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_SaveStory()
	{
	}
}
