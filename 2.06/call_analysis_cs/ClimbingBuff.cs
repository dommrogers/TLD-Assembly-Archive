using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClimbingBuff : MonoBehaviour
{
	public float m_SprainRollOddsModifier;

	public float m_StaminaPerSecondModifier;

	public float m_WeakIceTimeSecondsModifier;

	private float m_SprainModifier;

	private float m_StaminaModifier;

	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsActive(PlayerManager playerManager)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
