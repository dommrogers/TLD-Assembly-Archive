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

	[CalledBy(Type = typeof(HUDObjectives), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallsUnknownMethods(Count = 21)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Disable")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "OnTweenComplete")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void Show(string statusLocID, Color statusColor, string infoLocID, string missionId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Disable")]
	private void OnTweenComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public ObjectiveInfoDisplay()
	{
	}
}
