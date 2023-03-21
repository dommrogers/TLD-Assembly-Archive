using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClimbingBuff : MonoBehaviour
{
	public float m_SprainRollOddsModifier;

	public float m_StaminaPerSecondModifier;

	public float m_WeakIceTimeSecondsModifier;

	private GearItem m_GearItem;

	private float m_SprainModifier;

	private float m_StaminaModifier;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetSprainRollOddsModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
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
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ClimbingBuff()
	{
	}
}
