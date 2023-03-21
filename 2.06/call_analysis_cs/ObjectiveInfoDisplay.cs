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
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CallsUnknownMethods(Count = 19)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "OnTweenComplete")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void Show(string statusLocID, Color statusColor, string infoLocID, string missionId)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Disable")]
	[CallerCount(Count = 0)]
	private void OnTweenComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ObjectiveInfoDisplay()
	{
	}
}
