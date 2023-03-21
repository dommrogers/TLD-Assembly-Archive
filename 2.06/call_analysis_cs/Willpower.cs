using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class Willpower : MonoBehaviour
{
	public float m_TimeRemainingSeconds;

	public float m_ConditionBonusPerSecond;

	public float m_ConditionBonusCap;

	public float m_ConditionDamageScale;

	private bool m_StartHasBeenCalled;

	private static WillpowerSaveDataProxy m_WillpowerSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Condition), Member = "MaybeIncreaseConditionFromWillpower")]
	public bool GetActive()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetActive(float timeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetConditionBonusPerSecond()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetConditionBonusCap()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetConditionDamageScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Willpower()
	{
	}
}
