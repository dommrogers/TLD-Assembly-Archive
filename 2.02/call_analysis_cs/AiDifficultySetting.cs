using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiDifficultySetting : MonoBehaviour
{
	public AiDifficulty m_AiDifficulty;

	public AiSubType m_AiSubType;

	public float m_StruggleTapStrengthScale;

	public float m_StrugglePlayerDamageReceivedIntervalScale;

	public float m_StrugglePlayerDamageReceivedScale;

	public float m_StrugglePlayerClothingDamageScale;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public float GetStruggleTapStrenthScale()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 0)]
	public float GetStrugglePlayerDamageReceivedIntervalScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[CalledBy(Type = typeof(ClothingDamageEvent), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public float GetStrugglePlayerClothingDamageScale()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	public float GetStrugglePlayerDamageReceivedScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AiDifficultySetting()
	{
	}
}
