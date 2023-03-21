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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 0)]
	public float GetStruggleTapStrenthScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public float GetStrugglePlayerDamageReceivedIntervalScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(ClothingDamageEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[CallerCount(Count = 2)]
	public float GetStrugglePlayerClothingDamageScale()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	public float GetStrugglePlayerDamageReceivedScale()
	{
		return default(float);
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public AiDifficultySetting()
	{
	}
}
