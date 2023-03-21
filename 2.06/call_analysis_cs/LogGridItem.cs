using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class LogGridItem : MonoBehaviour
{
	private PanelReference<Panel_Log> m_Log;

	public UIWidget m_WidgetParent;

	public UILabel m_LabelCenter;

	public UILabel m_LabelTopLeft;

	public UITexture m_TextureCenter;

	public UISprite m_SpriteTopLeft;

	public TweenScale m_TweenScale;

	public GameObject m_NotificationFlag;

	private bool m_IsSelected;

	private int m_EntryNum;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void OnClick()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	public void SetSelected()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public void SetupAsDayEntry(int entryNum, bool hasNotes)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallsUnknownMethods(Count = 7)]
	public void SetupAsCollectionEntry(int entryNum, string textureName, int entryDisplayNum)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	public void SetupAsCollectibleEntry(int entryNum, GearItem gearItem)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallsUnknownMethods(Count = 1)]
	public void HideAll()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSelected()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 31)]
	public GearItem GetGearItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void DeselectItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LogGridItem()
	{
	}
}
