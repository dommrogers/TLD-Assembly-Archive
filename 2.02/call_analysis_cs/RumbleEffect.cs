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
		return false;
	}

	[CallerCount(Count = 0)]
	public void ResetEffect()
	{
	}

	[CalledBy(Type = typeof(RumbleEffectManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ManualUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetHighFrequencyValue()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetLowFrequencyValue()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RumbleEffect()
	{
	}
}
