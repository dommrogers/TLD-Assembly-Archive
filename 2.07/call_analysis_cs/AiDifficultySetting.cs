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

	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[CalledBy(Type = typeof(ClothingDamageEvent), Member = "OnExecute")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	public float GetStrugglePlayerClothingDamageScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	public float GetStrugglePlayerDamageReceivedScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AiDifficultySetting()
	{
	}
}
