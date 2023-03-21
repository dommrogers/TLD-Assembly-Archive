using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Playables;

[Serializable]
public class PlayableBehaviourChangeTOD : PlayableBehaviour
{
	public string m_OptionalStartTOD;

	public string m_TargetTOD;

	public bool m_Instant;

	private bool m_HasValidTOD;

	private float m_NormalizedStartTOD;

	private float m_NormalizedTargetTOD;

	private TimeOfDay m_TimeOfDay;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayableBehaviourChangeTOD()
	{
	}
}
