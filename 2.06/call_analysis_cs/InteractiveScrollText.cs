using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class InteractiveScrollText : MonoBehaviour
{
	public float m_ControllerScrollScale;

	public float m_KeyboardScrollScale;

	public UILabel m_Label;

	public UILocalize m_Localize;

	public UIScrollView m_ScrollView;

	private PanelReference<Panel_HUD> m_HUD;

	private bool m_FirstUpdate;

	private bool m_EnableScrolling;

	private Action m_OnScrollAction;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteractiveScrollText), Member = "RefreshLocalization")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "Scroll")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetScrollingEnabled()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 23)]
	public void SetScrollingAction(Action action)
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "UpdateInteractiveScrolling")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsUnknownMethods(Count = 1)]
	public void SetScrollingEnabled(bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void RefreshLocalization()
	{
	}

	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Scroll(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollToBottom()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollToTop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonDisplay()
	{
	}

	[CallerCount(Count = 0)]
	public InteractiveScrollText()
	{
	}
}
