using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class HUDChapter : MonoBehaviour
{
	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	public UILabel m_ChapterName;

	public UILabel m_ChapterNumber;

	public bool m_RestoreDisplay;

	private int m_ActiveTweens;

	private List<UITweener> m_Tweens;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(HUDChapter), Member = "OnTweenComplete")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallsUnknownMethods(Count = 6)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void Enqueue(string id)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void HideDisplay()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RestoreDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(HUDChapter), Member = "Disable")]
	[CallerCount(Count = 0)]
	private void OnTweenComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HUDChapter()
	{
	}
}
