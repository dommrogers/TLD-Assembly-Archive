using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraActivatedToggle : MonoBehaviour
{
	public AuroraActivatedToggleState m_ToggleState;

	public string m_ToggleOnAudio;

	public string m_ToggleOffAudio;

	private bool m_ChildrenEnabled;

	private AuroraField m_ActiveAuroraField;

	public bool m_RequiresAuroraField;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraActivatedToggle), Member = "UpdateChildStatus")]
	private void Start()
	{
	}

	[Calls(Type = typeof(AuroraActivatedToggle), Member = "UpdateChildStatus")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 38)]
	public void SetAuroraField(AuroraField auroraField)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void SetState(AuroraActivatedToggleState state)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CalledBy(Type = typeof(AuroraActivatedToggle), Member = "Start")]
	[CalledBy(Type = typeof(AuroraActivatedToggle), Member = "Update")]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateChildStatus(bool forceUpdate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShouldEnableChildren()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public AuroraActivatedToggle()
	{
	}
}
