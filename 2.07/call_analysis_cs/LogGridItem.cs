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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnClick()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "GetTotalNumGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "DeselectLogGridItems")]
	[Calls(Type = typeof(Panel_Log), Member = "LogListItemCallback")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void SetupAsDayEntry(int entryNum, bool hasNotes)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public void SetupAsCollectionEntry(int entryNum, string textureName, int entryDisplayNum)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public void SetupAsCollectibleEntry(int entryNum, GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void HideAll()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSelected()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public GearItem GetGearItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void DeselectItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LogGridItem()
	{
	}
}
