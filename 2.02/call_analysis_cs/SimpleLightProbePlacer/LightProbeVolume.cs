using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SimpleLightProbePlacer;

public class LightProbeVolume : TransformVolume
{
	private LightProbeVolumeType m_type;

	private Vector3 m_densityFixed;

	private Vector3 m_densityFloat;

	public LightProbeVolumeType Type
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(LightProbeVolumeType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector3 Density
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public static Color EditorColor
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LightProbeVolume), Member = "CreatePositionsFixed")]
	[Calls(Type = typeof(LightProbeVolume), Member = "CreatePositionsFloat")]
	[CallsUnknownMethods(Count = 2)]
	public List<Vector3> CreatePositions()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LightProbeVolume), Member = "CreatePositionsFloat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LightProbeVolume), Member = "CreatePositionsFixed")]
	public List<Vector3> CreatePositions(LightProbeVolumeType type)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CalledBy(Type = typeof(LightProbeVolume), Member = "CreatePositions")]
	[CalledBy(Type = typeof(LightProbeVolume), Member = "CreatePositions")]
	[CallsUnknownMethods(Count = 15)]
	public static List<Vector3> CreatePositionsFixed(Transform volumeTransform, Vector3 origin, Vector3 size, Vector3 density)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(LightProbeVolume), Member = "CreatePositions")]
	[CalledBy(Type = typeof(LightProbeVolume), Member = "CreatePositions")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static List<Vector3> CreatePositionsFloat(Transform volumeTransform, Vector3 origin, Vector3 size, Vector3 density)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightProbeVolume()
	{
	}
}
