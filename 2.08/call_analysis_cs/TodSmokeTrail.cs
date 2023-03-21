using System;
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
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TodSmokeTrail), Member = "UpdateMiddayObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[CallsUnknownMethods(Count = 6)]
	public void Update()
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[Calls(Type = typeof(TodSmokeTrail), Member = "ForceMiddayObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	public void ForceUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	private void ForceToOriginalState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	private void ForceToOffState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	private void InterpolateToOriginalState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	private void InterpolateToOffState()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ForceDayOnlyObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CallsUnknownMethods(Count = 2)]
	private void ForceNightOnlyObject()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	private void ForceMiddayObject()
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateDayOnlyObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateNightOnlyObject()
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void UpdateMiddayObject()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TodSmokeTrail()
	{
	}
}
