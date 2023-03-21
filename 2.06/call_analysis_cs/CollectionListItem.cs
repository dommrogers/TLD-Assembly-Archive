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

	[DeduplicatedMethod]
	[CallerCount(Count = 31)]
	public CollectionListItemInfo GetItemInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "AddTrustEntryToList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "AddWhatIKnowEntryToList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildTrustList")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "AddEntryToList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectionsList")]
	public void SetItemInfo(CollectionListItemInfo itemInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowListItemsColor")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTrustListItemsColor")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectionListItemsColor")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CollectionListItem()
	{
	}
}
