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
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighlightFogManager), Member = "UpdateHeadings")]
	[Calls(Type = typeof(HighlightFogManager), Member = "UpdateTOD")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "ManualUpdateAngles")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "UpdateDrive")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "UpdateMaterial")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateHeadings()
	{
	}

	[CalledBy(Type = typeof(HighlightFogManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendState")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetTODBlendPercent")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTOD()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighlightFogManaged), Member = "ManualUpdateAngles")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "UpdateDrive")]
	[Calls(Type = typeof(HighlightFogManaged), Member = "UpdateMaterial")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateQuads()
	{
	}

	[CallerCount(Count = 0)]
	private Vector3 Heading3D(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HighlightFogManager()
	{
	}
}
