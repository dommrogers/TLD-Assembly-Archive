using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InteractiveScrollText : MonoBehaviour
{
	public float m_ControllerScrollScale;

	public float m_KeyboardScrollScale;

	public UILabel m_Label;

	public UILocalize m_Localize;

	public UIScrollView m_ScrollView;

	private bool m_FirstUpdate;

	private bool m_EnableScrolling;

	private Action m_OnScrollAction;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteractiveScrollText), Member = "RefreshLocalization")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetScroll")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InteractiveScrollText), Member = "Scroll")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
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
	[CallerCount(Count = 41)]
	public void SetScrollingAction(Action action)
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnCameraPositionStateChange")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "UpdateInteractiveScrolling")]
	public void SetScrollingEnabled(bool isEnabled)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	public void RefreshLocalization()
	{
	}

	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
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
	[CallsUnknownMethods(Count = 2)]
	private void UpdateButtonDisplay()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public InteractiveScrollText()
	{
	}
}
