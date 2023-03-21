using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TerrainMountainRoadMaker;

public class TerrainMountainRoadMaker : MonoBehaviour
{
	public int roadWidth;

	public int roadResolution;

	public float roundingCorner;

	public bool showLabel;

	public bool showArrows;

	public bool showSpheres;

	public bool showLines;

	public bool directInput;

	public List<BezierInfo> Points;

	public List<float[,]> hightUndo;

	public List<float[,,]> alphaUndo;

	public int splatIndex;

	public GUIStyle style;

	public Terrain _terrain;

	public TerrainCollider _collider;

	public Terrain terrain
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public TerrainCollider collider
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 33)]
	public TerrainMountainRoadMaker()
	{
	}
}
