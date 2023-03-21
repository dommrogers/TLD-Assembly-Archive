using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ToggleComponentsDuringTimelinePlayback : MonoBehaviour
{
	public Behaviour[] m_EnableDuringPlayback;

	public Behaviour[] m_DisableDuringPlayback;

	private bool m_TimelinePlaybackActive;

	public bool TimelinePlaybackActive
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ToggleComponentsDuringTimelinePlayback), Member = "Start")]
	[CalledBy(Type = typeof(ToggleComponentsDuringTimelinePlayback), Member = "set_TimelinePlaybackActive")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
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
