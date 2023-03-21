using System;
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MoveGridSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Panel_Log), Member = "SetLogGridItemIndex")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public void SetSelected()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public void SetupAsDayEntry(int entryNum, bool hasNotes)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 2)]
	public void SetupAsCollectionEntry(int entryNum, string textureName, int entryDisplayNum)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void SetupAsCollectibleEntry(int entryNum, GearItem gearItem)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
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
	[CallerCount(Count = 10)]
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
