using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public abstract class MB2_TexturePacker
{
	internal enum NodeType
	{
		Container,
		maxDim,
		regular
	}

	internal class PixRect
	{
		public int x;

		public int y;

		public int w;

		public int h;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public PixRect()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public PixRect(int xx, int yy, int ww, int hh)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 17)]
		public override string ToString()
		{
			return null;
		}
	}

	internal class Image
	{
		public int imgId;

		public int w;

		public int h;

		public int x;

		public int y;

		[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
		[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
		[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 5)]
		public Image(int id, int tw, int th, AtlasPadding padding, int minImageSizeX, int minImageSizeY)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public Image(Image im)
		{
		}
	}

	internal class ImgIDComparer : IComparer<Image>
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public int Compare(Image x, Image y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ImgIDComparer()
		{
		}
	}

	internal class ImageHeightComparer : IComparer<Image>
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public int Compare(Image x, Image y)
		{
			return default(int);
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public ImageHeightComparer()
		{
		}
	}

	internal class ImageWidthComparer : IComparer<Image>
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public int Compare(Image x, Image y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ImageWidthComparer()
		{
		}
	}

	internal class ImageAreaComparer : IComparer<Image>
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public int Compare(Image x, Image y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ImageAreaComparer()
		{
		}
	}

	public MB2_LogLevel LOG_LEVEL;

	public bool atlasMustBePowerOfTwo;

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CallsUnknownMethods(Count = 3)]
	public static int RoundToNearestPositivePowerOfTwo(int x)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
	public static int CeilToNearestPowerOfTwo(int x)
	{
		return default(int);
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas);

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	internal bool ScaleAtlasToFitMaxDim(Vector2 rootWH, List<Image> images, int maxDimensionX, int maxDimensionY, AtlasPadding padding, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, ref int outW, ref int outH, out float padX, out float padY, out int newMinSizeX, out int newMinSizeY)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref padX) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref padY) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref newMinSizeX) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref newMinSizeY) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	public void normalizeRects(AtlasPackingResult rr, AtlasPadding padding)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected MB2_TexturePacker()
	{
	}
}
