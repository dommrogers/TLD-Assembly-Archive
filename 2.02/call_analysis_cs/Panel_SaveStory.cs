using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

	private sealed class _003COnOverwriteConfirmedCoroutine_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Panel_SaveStory _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
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
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
		[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 19)]
		private bool MoveNext()
		{
			return false;
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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003COnQuicksaveCoroutine_003Ed__58(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
		[Calls(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public override void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(BasicMenu), Member = "RefreshButtonStateColors")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	[Calls(Type = typeof(BasicMenu), Member = "AddLineBreak")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 38)]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	private void AddSavesOfTypeToMenu(string[] slotPrefixes, string[] displayLocIds = null, int[] limits = null, bool showTimeSinceSave = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void BackWithouSFX()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 35)]
	private void ProcessMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRename")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnDelete")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmed")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CallsUnknownMethods(Count = 1)]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public void OnRename()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnRenameExistingStoryCancelled(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void OnRenameExistingStoryConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowDeleteConfirmationPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public void OnDelete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DeleteSaveSlot()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSelectionUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetEpisodeGenericNameLocId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void OnSlotClicked()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 21)]
	private void OnNewSave()
	{
	}

	[CallerCount(Count = 0)]
	public void OnCancelled(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	[Calls(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void OnNewSaveNamed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmedCoroutine")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "OnQuicksaveCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnOverwriteConfirmed()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator OnOverwriteConfirmedCoroutine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void OnOverwriteSaveNamed()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteConfirmed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator OnQuicksaveCoroutine()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void EnableSingleAnimItem(int targetIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private AnimMenuItems GetAnimMenuItem(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsPlayingAnySelectionAnimation()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnySelectionAnimation")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation(int stateHash)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PlaySelectedAnimation(AnimMenuItems menuItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PlayDeselectedAnimation(AnimMenuItems menuItem)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnyDeselectionAnimation")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "GetAnimMenuItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Panel_SaveStory), Member = "EnableSingleAnimItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Panel_SaveStory()
	{
	}
}
