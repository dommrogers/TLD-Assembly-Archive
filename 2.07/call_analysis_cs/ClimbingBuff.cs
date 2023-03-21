using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClimbingBuff : MonoBehaviour
{
	public float m_SprainRollOddsModifier;

	public float m_StaminaPerSecondModifier;

	public float m_WeakIceTimeSecondsModifier;

	private float m_SprainModifier;

	private float m_StaminaModifier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsActive(PlayerManager playerManager)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSprainRollOddsModifier()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetStaminaModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetWeakIceTimeSecondsModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public ClimbingBuff()
	{
	}
}
