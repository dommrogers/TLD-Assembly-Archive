using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TodSmokeTrail : MonoBehaviour
{
	public TodControllerCategory m_Cateogry;

	private SmokeTrail[] m_SmokeTrails;

	private bool m_ForcedUpdate;

	private Light[] m_GimbleLights;

	private List<ParticleSystem> m_GimbleFX;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(TodSmokeTrail), Member = "UpdateMiddayObject")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	public void Update()
	{
	}

	[Calls(Type = typeof(TodSmokeTrail), Member = "ForceMiddayObject")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public void ForceUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	private void ForceToOriginalState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	private void ForceToOffState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	private void InterpolateToOriginalState()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	private void InterpolateToOffState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CallsUnknownMethods(Count = 4)]
	private void ForceDayOnlyObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CallsUnknownMethods(Count = 4)]
	private void ForceNightOnlyObject()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void ForceMiddayObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateDayOnlyObject()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateNightOnlyObject()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateMiddayObject()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TodSmokeTrail()
	{
	}
}
