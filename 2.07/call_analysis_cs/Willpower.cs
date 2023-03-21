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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	public bool GetActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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
	[CallerCount(Count = 0)]
	public Willpower()
	{
	}
}
