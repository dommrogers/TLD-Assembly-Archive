using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.UI;

public class MiniTopNavButton : MonoBehaviour
{
	public bool m_IsCurrentView;

	private PanelReference m_TargetPanel;

	private BoxCollider m_BoxCollider;

	private UIButton m_UIButton;

	private UIButtonScale m_UIButtonScale;

	private Panel_Base m_PanelOwner;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 70)]
	public void SetOwner(Panel_Base owner)
	{
	}

	[CalledBy(Type = typeof(MiniTopNav), Member = "Show")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void SetEnabled(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 4)]
	public bool CanShow()
	{
		return false;
	}

	[CalledBy(Type = typeof(MiniTopNav), Member = "OnButtonClickPrevious")]
	[CalledBy(Type = typeof(MiniTopNav), Member = "OnButtonClickNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnButtonClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MiniTopNavButton()
	{
	}
}
