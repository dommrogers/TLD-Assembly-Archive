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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
	{
		return null;
	}

	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[CallsUnknownMethods(Count = 102)]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "GetRects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "ScaleAtlasToFitMaxDim")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 88)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "GetRects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "normalizeRects")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "PopLargestThatFits")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "ScaleAtlasToFitMaxDim")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private AtlasPackingResult[] _GetRectsMultiAtlasVertical(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "GetRects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 88)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "normalizeRects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "ScaleAtlasToFitMaxDim")]
	[Calls(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "PopLargestThatFits")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private AtlasPackingResult[] _GetRectsMultiAtlasHorizontal(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private Image PopLargestThatFits(List<Image> images, int spaceRemaining, int maxDim, bool emptyAtlas)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public MB2_TexturePackerHorizontalVert()
	{
	}
}
