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
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[Calls(Type = typeof(UnityEvent), Member = "Invoke")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 7)]
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
	[CallsUnknownMethods(Count = 2)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "OnWeatherChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "StopAndReleaseInstances")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WeatherActivatedEffectsController), Member = "StopAndReleaseInstances")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnWeatherChanged()
	{
	}

	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnDisable")]
	[CalledBy(Type = typeof(WeatherActivatedEffectsController), Member = "OnWeatherChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(WeatherActivatedEffect), Member = "Stop")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void StopAndReleaseInstances(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public WeatherActivatedEffectsController()
	{
	}
}
