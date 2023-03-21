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

		[CallsUnknownMethods(Count = 9)]
		[Calls(Type = typeof(UnityEvent), Member = "Invoke")]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallerCount(Count = 0)]
		internal void _003COnWeatherChanged_003Eb__0(AsyncOperationHandle<GameObject> opHandle)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public WeatherActivatedEffectData data;

		public WeatherActivatedEffect effect;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CStopAndReleaseInstances_003Eb__0()
		{
		}
	}

	private WeatherActivatedEffectData[] m_Data;

	private WeatherStageChangeEvent m_WeatherStageChangeEvent;

	private WeatherStage m_LastWeatherStage;

	private Dictionary<WeatherActivatedEffectData, WeatherActivatedEffect> m_LoadedInstances;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "OnWeatherChanged")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[CallsUnknownMethods(Count = 6)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "StopAndReleaseInstances")]
	[CallsUnknownMethods(Count = 7)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnEnable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "StopAndReleaseInstances")]
	private void OnWeatherChanged()
	{
	}

	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnWeatherChanged")]
	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WeatherActivatedEffect), Member = "Stop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void StopAndReleaseInstances(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public WeatherActivatedEffectsController()
	{
	}
}
