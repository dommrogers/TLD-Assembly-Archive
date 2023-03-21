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

	[Calls(Type = typeof(InteractiveScrollText), Member = "Scroll")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetScrollingEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 13)]
	public void SetScrollingAction(Action action)
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "UpdateInteractiveScrolling")]
	public void SetScrollingEnabled(bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Awake")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void RefreshLocalization()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void Scroll(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollToBottom()
	{
	}

	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollToTop()
	{
	}

	[Calls(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateButtonDisplay()
	{
	}

	[CallerCount(Count = 0)]
	public InteractiveScrollText()
	{
	}
}
