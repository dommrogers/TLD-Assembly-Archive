using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HighlightFogManager : MonoBehaviour
{
	public List<HighlightFogManaged> m_FogQuads;

	public bool m_FadeAtNight;

	private UniStormWeatherSystem m_UniStorm;

	private List<Vector3> m_Headings;

	private float m_TODMultiplier;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[Calls(Type = typeof(HighlightFogManager), Member = "UpdateHeadings")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighlightFogManager), Member = "UpdateTOD")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateHeadings()
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	private void UpdateTOD()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighlightFogManaged), Member = "ManualUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateQuads()
	{
	}

	[CallerCount(Count = 0)]
	private Vector3 Heading3D(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public HighlightFogManager()
	{
	}
}
