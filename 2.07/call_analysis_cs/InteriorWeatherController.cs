using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InteriorWeatherController : MonoBehaviour
{
	[Serializable]
	public struct InteriorWeatherSet
	{
		public WeatherStage m_WeatherType;

		public GameObject m_WeatherHierarchy;
	}

	public List<InteriorWeatherSet> m_InteriorWeatherList;

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "MaybeSetInteriorWeather")]
	[CallsUnknownMethods(Count = 5)]
	public void SetInteriorWeather(WeatherStage currentWeatherStage)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InteriorWeatherController()
	{
	}
}
