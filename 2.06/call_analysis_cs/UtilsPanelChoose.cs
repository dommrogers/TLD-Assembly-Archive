using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.Scenes;
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
		[CallerCount(Count = 6)]
		public DetailsObjets()
		{
		}
	}

	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[CallerCount(Count = 0)]
	private static string GetRegionLargeTextureName(string locationName)
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetLargeRegionBackgroundName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetLargeRegionBackgroundName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetLargeRegionBackgroundName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionLargeTextureName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private static string GetRegionTextureName(string locationName)
	{
		return null;
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionSpriteName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionSpriteName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionSpriteName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static string GetRegionSaveSlotTextureName(string locationName)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[Calls(Type = typeof(SaveGameSystem), Member = "CreateTextureData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(SceneSet), Member = "get_LocalizedRegionGroupName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DateTime), Member = "ToShortDateString")]
	[Calls(Type = typeof(DateTime), Member = "ToShortTimeString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	public static void RefreshDetails(SaveSlotInfo slotInfo, DetailsObjets details, DetailsType type)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetLargeRegionBackgroundName(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[CallerCount(Count = 0)]
	private static string GetRegionSpriteName(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	public static void ProcessMenu(BasicMenu basicMenu, bool canRename, bool canDelete, Action onAutoBack, GameObject renameButton, Action onRename, GameObject deleteButton, Action onDelete)
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	public static void UpdateButtonLegend(BasicMenu basicMenu, bool canLoad, bool canRename, bool canDelete, ButtonLegendContainer buttonLegendContainer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public UtilsPanelChoose()
	{
	}
}
