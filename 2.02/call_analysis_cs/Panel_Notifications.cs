using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Notifications : Panel_Base
{
	public Notifications m_Notifications;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public Transform m_NotificationsParent;

	public UILabel m_Title;

	public UITexture m_Background;

	public UIPanel m_ScrollablePanel;

	public UILabel m_ScrollableText;

	public GameObject m_Scrollbar;

	public UISprite m_LoadingSprite;

	public int m_TitleFontSize;

	public int m_TitleFontSizeCyrillic;

	public int m_TitleFontSizeInuktitut;

	public LocalizedString m_DefaultTellMeMoreLocID;

	public LocalizedString m_AnaylyticToggleOptInLocID;

	public LocalizedString m_AnaylyticToggleOptOutLocID;

	public GameObject m_ScreenPips;

	public string m_ScreenPipsOutline;

	public string m_ScreenPipsFilled;

	public int m_PipSpacing;

	public GameObject m_NextButton;

	public GameObject m_PrevButton;

	public GameObject m_TellMeMoreButton;

	public GameObject m_AnalyticsToggleButton;

	private int m_NotificationIndex;

	private List<Notification> m_NotificationList;

	private string m_TellMeMoreUrl;

	private float m_ScrollablePanelHeight;

	private bool m_WasContinuePressedWhenEnabled;

	private bool m_WasEscapePressedWhenEnabled;

	private bool m_WasMoreInfoPressedWhenEnabled;

	private bool m_WasAnalyticsTogglePressedWhenEnabled;

	private UILabel m_NextButtonLabel;

	private UISlider m_ScrollbarSlider;

	private UISprite[] m_Pips;

	private UILabel m_AnalyticsToggleLabel;

	private GenericButtonMouseSpawner m_TellMeMoreSpawner;

	private UILabel m_TellMeMoreLabel;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(Panel_Notifications), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Notifications), Member = "OnScrollbarDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Notifications), Member = "OnScrollbarUp")]
	[Calls(Type = typeof(Panel_Notifications), Member = "OnClickToggleAnalytics")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Notifications), Member = "Populate")]
	[Calls(Type = typeof(Panel_Notifications), Member = "OnClickNext")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Notifications), Member = "HasNotifications")]
	[Calls(Type = typeof(Panel_Notifications), Member = "Enable")]
	public void EnableIfPendingNotifications(Notifications.Options opts)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Extras), Member = "OnClickUpdates")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "EnableIfPendingNotifications")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "OnClickNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(Notifications), Member = "GetValidNotifications")]
	[Calls(Type = typeof(Panel_Notifications), Member = "Populate")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Panel_Notifications), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Enable(bool enable, Notifications.Options opts)
	{
	}

	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "EnableIfPendingNotifications")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Notifications), Member = "GetValidNotifications")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasNotifications(Notifications.Options opts)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Notifications), Member = "Populate")]
	[Calls(Type = typeof(Panel_Notifications), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void OnClickNext()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Notifications), Member = "Populate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnClickPrevious()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnClickTellMeMore()
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "EnableAnalytics")]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetAnalyticsToggleButtonText")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public void OnClickToggleAnalytics()
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "UpdateScrollInput")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnScrollbarUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "UpdateScrollInput")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnScrollbarDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Notifications), Member = "UpdateScrollbarSlider")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScrollbarChange()
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "SetAnalyticsToggleButtonText")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private string GetAnalyticsToggleButton()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetNextButtonText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "SetTellMeMoreToggleButtonText")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string GetTellMeMoreText(Notification notification)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "OnClickNext")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "OnClickPrevious")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetBackground")]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetTitle")]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetScrollableText")]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetTellMeMoreButton")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetupPips")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MarkNotificationAsViewed")]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetAnalyticsToggleButtonText")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void Populate(int notificationIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "OnClickToggleAnalytics")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "Populate")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "SetAnalyticsToggleButton")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Notifications), Member = "GetAnalyticsToggleButton")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetAnalyticsToggleButtonText()
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "SetTellMeMoreButton")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Notifications), Member = "GetTellMeMoreText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetTellMeMoreToggleButtonText(Notification notification)
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Populate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private void SetBackground(Texture2D tex, string url)
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Populate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Panel_Notifications), Member = "UpdateScrollbarSlider")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void SetScrollableText(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetAnalyticsToggleButtonText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetAnalyticsToggleButton(Notification notification)
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Populate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Notifications), Member = "SetTellMeMoreToggleButtonText")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetTellMeMoreButton(Notification notification)
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Populate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void SetTitle(string title)
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Populate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void SetupPips(int index, int count)
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Notifications), Member = "GetTellMeMoreText")]
	[Calls(Type = typeof(Panel_Notifications), Member = "GetAnalyticsToggleButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "OnScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "SetScrollableText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateScrollbarSlider()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Panel_Notifications), Member = "OnScrollbarDown")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Notifications), Member = "OnScrollbarUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateScrollInput()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsLoading()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Panel_Notifications()
	{
	}
}
