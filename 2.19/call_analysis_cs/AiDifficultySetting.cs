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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public float GetStruggleTapStrenthScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetStrugglePlayerDamageReceivedIntervalScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetStrugglePlayerClothingDamageScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetStrugglePlayerDamageReceivedScale()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AiDifficultySetting()
	{
	}
}