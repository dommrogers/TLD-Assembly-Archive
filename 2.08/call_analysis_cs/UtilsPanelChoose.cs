using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.Scenes;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	private static string GetRegionLargeTextureName(string locationName)
	{
		return null;
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionLargeTextureName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetLargeRegionBackgroundName")]
	[CallerCount(Count = 7)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	private static string GetRegionTextureName(string locationName)
	{
		return null;
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionSpriteName")]
	[CallerCount(Count = 6)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	public static string GetRegionSaveSlotTextureName(string locationName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "RefreshDetails")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(DateTime), Member = "ToShortTimeString")]
	[Calls(Type = typeof(DateTime), Member = "ToShortDateString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(SceneSet), Member = "get_LocalizedRegionGroupName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(SaveGameSystem), Member = "CreateTextureData")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	public static void RefreshDetails(SaveSlotInfo slotInfo, DetailsObjets details, DetailsType type)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionTextureName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetLargeRegionBackgroundName(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UtilsPanelChoose), Member = "GetRegionSaveSlotTextureName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetRegionSpriteName(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ProcessMenu")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void ProcessMenu(BasicMenu basicMenu, bool canRename, bool canDelete, Action onAutoBack, GameObject renameButton, Action onRename, GameObject deleteButton, Action onDelete)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "Update")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ProcessMenu")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMouseConfirmText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateButtonLegend(BasicMenu basicMenu, bool canLoad, bool canRename, bool canDelete, ButtonLegendContainer buttonLegendContainer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public UtilsPanelChoose()
	{
	}
}
