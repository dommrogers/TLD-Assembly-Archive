using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RumbleEffect : MonoBehaviour
{
	public AnimationCurve m_LowFrequency;

	public AnimationCurve m_HighFrequency;

	public float m_Duration;

	public bool m_Loop;

	private float m_CurrentTime;

	private bool m_IsPlaying;

	private float m_CurrentLowFrequencyValue;

	private float m_CurrentHighFrequencyValue;

	[CallerCount(Count = 0)]
	public void StartEffect()
	{
	}

	[CallerCount(Count = 0)]
	public void StopEffect()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void ResetEffect()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 2)]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetHighFrequencyValue()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetLowFrequencyValue()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public RumbleEffect()
	{
	}
}
