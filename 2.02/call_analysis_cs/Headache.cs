using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Headache : MonoBehaviour
{
	public string m_HeadachePulseEvent;

	public string m_HeadacheStartAudio;

	private HeadacheParams m_HeadacheParams;

	private float m_LastHeadachePulseTime;

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Headache), Member = "MaybeUpdateHeadacheEffects")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	public bool GetHeadacheActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public float GetHeadacheDurationPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetActiveHoursRemaining()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetHeadacheDuration()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ApplyHeadache(float durationHours, float pulseFrequencyStart, float pulseFrequencyEnd)
	{
	}

	[Calls(Type = typeof(Headache), Member = "ApplyHeadacheExitEffects")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveHeadache()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "HeadachePulse")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Headache), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Headache), Member = "ApplyHeadacheExitEffects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeUpdateHeadacheEffects()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadacheEffects")]
	[CalledBy(Type = typeof(Headache), Member = "RemoveHeadache")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void ApplyHeadacheExitEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Headache()
	{
	}
}
