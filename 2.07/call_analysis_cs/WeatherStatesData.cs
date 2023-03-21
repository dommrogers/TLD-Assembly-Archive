using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class WeatherStatesData : ScriptableObject
{
	public string m_StateJSONName;

	public WeatherStage m_WeatherStage;

	public TODStateData m_DawnColors;

	public TODStateData m_MorningColors;

	public TODStateData m_MiddayColors;

	public TODStateData m_AfternoonColors;

	public TODStateData m_DuskColors;

	public TODStateData m_NightColors;

	public float m_GrassTintScalar;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WeatherStatesData()
	{
	}
}
