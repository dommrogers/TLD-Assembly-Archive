using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerGameStats : MonoBehaviour
{
	public float m_CaloriesBurned;

	public float m_CaloriesEaten;

	public float m_BodyTempHigh;

	public float m_BodyTempLow;

	public float m_DistanceTraveledDay;

	public float m_DistanceTravelledNight;

	public float m_ConditionGained;

	public float m_ConditionLost;

	public float m_CaloriesExpendedToday;

	private bool m_StartHasBeenCalled;

	private static PlayerGameStatsProxy m_PlayerGameStatsProxy;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerGameStats()
	{
	}
}
