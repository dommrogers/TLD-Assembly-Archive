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

	[Calls(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "Scroll")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool GetScrollingEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public void SetScrollingAction(Action action)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "UpdateInteractiveScrolling")]
	public void SetScrollingEnabled(bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CallsUnknownMethods(Count = 1)]
	public void RefreshLocalization()
	{
	}

	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Scroll(float amount)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ScrollToBottom()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollToTop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
