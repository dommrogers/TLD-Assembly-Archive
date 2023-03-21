using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectiveInfoDisplay : MonoBehaviour
{
	public delegate void OnObjectiveDisplayComplete();

	public UILabel m_Info;

	public UILabel m_Status;

	public OnObjectiveDisplayComplete m_CompleteDelegate;

	public string m_MissionId;

	private int m_ActiveTweens;

	private List<UITweener> m_Tweens;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CallsUnknownMethods(Count = 7)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "OnTweenComplete")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 2)]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	public void Show(string statusLocID, Color statusColor, string infoLocID, string missionId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Disable")]
	private void OnTweenComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ObjectiveInfoDisplay()
	{
	}
}
