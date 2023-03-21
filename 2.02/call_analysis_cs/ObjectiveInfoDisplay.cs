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
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Disable")]
	[CalledBy(Type = typeof(ObjectiveInfoDisplay), Member = "OnTweenComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void Disable()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public void Show(string statusLocID, Color statusColor, string infoLocID, string missionId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTweenComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ObjectiveInfoDisplay()
	{
	}
}
