using Cpp2ILInjected.CallAnalysis;
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetConditionDamageScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public Willpower()
	{
	}
}
