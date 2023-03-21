using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB2_TexturePackerHorizontalVert : MB2_TexturePacker
{
	public enum TexturePackingOrientation
	{
		horizontal,
		vertical
	}

	public TexturePackingOrientation packingOrientation;

	public bool stretchImagesToEdges;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "GetRects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "ScaleAtlasToFitMaxDim")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 102)]
	private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "GetRects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "PopLargestThatFits")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "ScaleAtlasToFitMaxDim")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "normalizeRects")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 88)]
	private AtlasPackingResult[] _GetRectsMultiAtlasVertical(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "GetRects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "PopLargestThatFits")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "ScaleAtlasToFitMaxDim")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "normalizeRects")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 88)]
	private AtlasPackingResult[] _GetRectsMultiAtlasHorizontal(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private Image PopLargestThatFits(List<Image> images, int spaceRemaining, int maxDim, bool emptyAtlas)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public MB2_TexturePackerHorizontalVert()
	{
	}
}
