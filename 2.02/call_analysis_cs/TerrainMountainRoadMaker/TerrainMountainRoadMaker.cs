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
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		get
		{
			return null;
		}
	}

	public TerrainCollider collider
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public TerrainMountainRoadMaker()
	{
	}
}
