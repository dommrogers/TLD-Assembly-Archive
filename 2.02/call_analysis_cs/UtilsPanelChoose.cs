using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UtilsPanelChoose
{
	public enum DetailsType
	{
		Challenges,
		Sandbox,
		Story
	}

	[Serializable]
	public class DetailsObjets
	{
		public GameObject m_Details;

		public UILabel m_TitleLabel;

		public UILabel m_DateLabel;

		public UILabel m_SurvivorLabel;

		public UILabel m_ConditionLabel;

		public UILabel m_XPLabel;

		public UILabel m_SurvivedLabel;

		public UILabel m_ExploredLabel;

		public UILabel m_RegionLabel;

		public UILabel m_LocationLabel;

		public UISprite m_RegionSprite;

		public UITexture m_CenteredTexture;

		public UITexture m_BackgroundTexture;

		public UITexture m_ThumbnailTexture;

		public UILabel m_EpisodeProgressionLabel;

		public UILabel m_SaveVersionLabel;

		public GameObject m_SaveVersionObject;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public DetailsObjets()
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	public static string GetRegionLargeTextureName(string locationName)
	{
		return null;
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionLargeTextureName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetRegionTextureName(string locationName)
	{
		return null;
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetRegionSaveSlotTextureName(string locationName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(DateTime), Member = "ToShortTimeString")]
	[Calls(Type = typeof(DateTime), Member = "ToShortDateString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLocalizedExperienceMode")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(SaveGameSystem), Member = "CreateTextureData")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 39)]
	public static void RefreshDetails(SaveSlotInfo slotInfo, DetailsObjets details, DetailsType type)
	{
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static void ProcessMenu(BasicMenu basicMenu, bool canRename, bool canDelete, Action onAutoBack, GameObject renameButton, Action onRename, GameObject deleteButton, Action onDelete)
	{
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ProcessMenu")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void UpdateButtonLegend(BasicMenu basicMenu, bool canLoad, bool canRename, bool canDelete, ButtonLegendContainer buttonLegendContainer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public UtilsPanelChoose()
	{
	}
}
