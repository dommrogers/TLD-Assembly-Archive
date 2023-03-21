using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class AtlasPackingResult
{
	public int atlasX;

	public int atlasY;

	public int usedW;

	public int usedH;

	public Rect[] rects;

	public AtlasPadding[] padding;

	public int[] srcImgIdxs;

	public object data;

	[DeduplicatedMethod]
	[CallerCount(Count = 24)]
	public AtlasPackingResult(AtlasPadding[] pds)
	{
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "MergeAtlasPackingResultStackBonA")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void CalcUsedWidthAndHeight()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	public override string ToString()
	{
		return null;
	}
}
