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

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	public void OnTriggerStay(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AudioStateZoneTrigger()
	{
	}
}
