using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ToggleComponentsDuringTimelinePlayback : MonoBehaviour
{
	public Behaviour[] m_EnableDuringPlayback;

	public Behaviour[] m_DisableDuringPlayback;

	private bool m_TimelinePlaybackActive;

	public bool TimelinePlaybackActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ToggleComponentsDuringTimelinePlayback), Member = "UpdateComponentStates")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToggleComponentsDuringTimelinePlayback), Member = "UpdateComponentStates")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(ToggleComponentsDuringTimelinePlayback), Member = "set_TimelinePlaybackActive")]
	[CalledBy(Type = typeof(ToggleComponentsDuringTimelinePlayback), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateComponentStates()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ToggleComponentsDuringTimelinePlayback()
	{
	}
}
