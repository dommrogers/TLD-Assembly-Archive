using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClimbingBuff : MonoBehaviour
{
	public float m_SprainRollOddsModifier;

	public float m_StaminaPerSecondModifier;

	public float m_WeakIceTimeSecondsModifier;

	private float m_SprainModifier;

	private float m_StaminaModifier;

	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsActive(PlayerManager playerManager)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSprainRollOddsModifier()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public ClimbingBuff()
	{
	}
}
