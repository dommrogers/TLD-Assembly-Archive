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
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[Calls(Type = typeof(TodSmokeTrail), Member = "UpdateMiddayObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(TodSmokeTrail), Member = "ForceMiddayObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void ForceUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ForceDayOnlyObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ForceNightOnlyObject()
	{
	}

	[CalledBy(Type = typeof(TodSmokeTrail), Member = "ForceUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ForceMiddayObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateDayOnlyObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateNightOnlyObject()
	{
	}

	[CalledBy(Type = typeof(TodSmokeTrail), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMiddayObject()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TodSmokeTrail()
	{
	}
}
