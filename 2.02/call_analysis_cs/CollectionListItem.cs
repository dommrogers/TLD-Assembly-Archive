using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CollectionListItem : MonoBehaviour
{
	public UIWidget m_FadeOnDeselectWidget;

	public UISprite m_CollectionIcon;

	public UILabel m_CompletionLabel;

	public UILabel m_CollectionNameLabel;

	public GameObject m_SelectedObj;

	public GameObject m_UnselectedObj;

	public float m_DeslectedAlphaValue;

	public GameObject m_NotificationFlag;

	public bool m_IsSelected;

	private CollectionListItemInfo m_ItemInfo;

	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	public CollectionListItemInfo GetItemInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "AddWhatIKnowEntryToList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "AddEntryToList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_Log), Member = "AddTrustEntryToList")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetItemInfo(CollectionListItemInfo itemInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetSelected(bool selected)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CollectionListItem()
	{
	}
}
