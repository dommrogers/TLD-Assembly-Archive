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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSprainRollOddsModifier()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetStaminaModifier()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWeakIceTimeSecondsModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ClimbingBuff()
	{
	}
}
