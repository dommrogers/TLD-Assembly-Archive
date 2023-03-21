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

	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "MaybeSetInteriorWeather")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void SetInteriorWeather(WeatherStage currentWeatherStage)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public InteriorWeatherController()
	{
	}
}
