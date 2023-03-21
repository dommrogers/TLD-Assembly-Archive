using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MB_AtlasesAndRects
{
	public Texture2D[] atlases;

	[NonSerialized]
	public List<MB_MaterialAndUVRect> mat2rect_map;

	public string[] texPropertyNames;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MB_AtlasesAndRects()
	{
	}
}
