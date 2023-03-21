using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LogGridItem : MonoBehaviour
{
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
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetSelected()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void SetupAsDayEntry(int entryNum, bool hasNotes)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	public void SetupAsCollectionEntry(int entryNum, string textureName, int entryDisplayNum)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	public void SetupAsCollectibleEntry(int entryNum, GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallerCount(Count = 1)]
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
	[CallerCount(Count = 11)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LogGridItem()
	{
	}
}
