using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

public class WeatherActivatedEffectsController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public WeatherActivatedEffectData data;

		public WeatherActivatedEffectsController _003C_003E4__this;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(UnityEvent), Member = "Invoke")]
		[CallsUnknownMethods(Count = 9)]
		internal void _003COnWeatherChanged_003Eb__0(AsyncOperationHandle<GameObject> opHandle)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public WeatherActivatedEffectData data;

		public WeatherActivatedEffect effect;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		internal void _003CStopAndReleaseInstances_003Eb__0()
		{
		}
	}

	private WeatherActivatedEffectData[] m_Data;

	private WeatherStageChangeEvent m_WeatherStageChangeEvent;

	private WeatherStage m_LastWeatherStage;

	private Dictionary<WeatherActivatedEffectData, WeatherActivatedEffect> m_LoadedInstances;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "OnWeatherChanged")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "StopAndReleaseInstances")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "StopAndReleaseInstances")]
	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	private void OnWeatherChanged()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnWeatherChanged")]
	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnDisable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(WeatherActivatedEffect), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void StopAndReleaseInstances(bool immediate)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public WeatherActivatedEffectsController()
	{
	}
}
