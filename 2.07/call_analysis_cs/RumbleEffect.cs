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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetHighFrequencyValue()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float GetLowFrequencyValue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RumbleEffect()
	{
	}
}
