using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MarkerListDisplayItem : MonoBehaviour
{
	public delegate void OnItemClicked(int index);

	public UISprite m_Background;

	public UIButton m_Button;

	public UILabel m_DisplayName;

	public GameObject m_Root;

	public Color m_Normal;

	public Color m_Selected;

	public UISprite m_Icon;

	public GameObject m_MouseDeleteGroup;

	public GameObject m_MouseOpenGroup;

	public GameObject m_GamepadDeleteGroup;

	public GameObject m_GamepadOpenGroup;

	[NonSerialized]
	public int m_Index;

	[NonSerialized]
	public OnItemClicked m_ClickedDelegate;

	[NonSerialized]
	public OnItemClicked m_ClickedDeleteDelegate;

	[NonSerialized]
	public OnItemClicked m_ClickedOpenDelegate;

	private bool m_CanDeleteMarker;

	private bool m_CanOpenMarker;

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "ClearDisplay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Clear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnButtonClicked()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnClickedDelete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnClickedOpen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "RefreshButtons")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "SetupDisplay")]
	[CallerCount(Count = 1)]
	public void Setup(MapElementSaveData marker)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallsUnknownMethods(Count = 1)]
	public static bool CanDelete(MapElementSaveData marker)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	public static bool CanOpen(MapElementSaveData marker)
	{
		return false;
	}

	[CalledBy(Type = typeof(MarkerListDisplayItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "SetSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshButtons(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MarkerListDisplayItem()
	{
	}
}
