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
		[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionLargeTextureName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static string GetRegionTextureName(string locationName)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static string GetRegionSaveSlotTextureName(string locationName)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(Utils), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[Calls(Type = typeof(SaveGameSystem), Member = "CreateTextureData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLocalizedExperienceMode")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DateTime), Member = "ToShortDateString")]
	[Calls(Type = typeof(DateTime), Member = "ToShortTimeString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void RefreshDetails(SaveSlotInfo slotInfo, DetailsObjets details, DetailsType type)
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	public static void ProcessMenu(BasicMenu basicMenu, bool canRename, bool canDelete, Action onAutoBack, GameObject renameButton, Action onRename, GameObject deleteButton, Action onDelete)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ProcessMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	public static void UpdateButtonLegend(BasicMenu basicMenu, bool canLoad, bool canRename, bool canDelete, ButtonLegendContainer buttonLegendContainer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public UtilsPanelChoose()
	{
	}
}
