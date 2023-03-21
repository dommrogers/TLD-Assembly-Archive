using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AudioStateZoneTrigger : MonoBehaviour
{
	public AudioOcclusionLevel m_OcclusionLevel;

	public OpenClose m_Door;

	private bool m_Occluded;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnTriggerStay(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CallsUnknownMethods(Count = 6)]
	public void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AudioStateZoneTrigger()
	{
	}
}
