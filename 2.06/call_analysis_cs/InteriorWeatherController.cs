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

	[CalledBy(Type = typeof(DarkLightingManager), Member = "MaybeSetInteriorWeather")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	public void SetInteriorWeather(WeatherStage currentWeatherStage)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public InteriorWeatherController()
	{
	}
}
