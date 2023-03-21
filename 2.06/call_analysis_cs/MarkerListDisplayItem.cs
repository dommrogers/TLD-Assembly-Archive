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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "ClearDisplay")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "RefreshButtons")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetSelected(bool selected)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "SetupDisplay")]
	public void Setup(MapElementSaveData marker)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallsUnknownMethods(Count = 1)]
	public static bool CanDelete(MapElementSaveData marker)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	public static bool CanOpen(MapElementSaveData marker)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "SetSelected")]
	[CalledBy(Type = typeof(MarkerListDisplayItem), Member = "SetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshButtons(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MarkerListDisplayItem()
	{
	}
}
