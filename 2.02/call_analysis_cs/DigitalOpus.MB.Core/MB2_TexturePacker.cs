using System.Collections.Generic;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public PixRect()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public PixRect(int xx, int yy, int ww, int hh)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
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

		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
		[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
		[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
		[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ImageAreaComparer()
		{
		}
	}

	public MB2_LogLevel LOG_LEVEL;

	public bool atlasMustBePowerOfTwo;

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static int RoundToNearestPositivePowerOfTwo(int x)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static int CeilToNearestPowerOfTwo(int x)
	{
		return 0;
	}

	public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding);

	public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas);

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal bool ScaleAtlasToFitMaxDim(Vector2 rootWH, List<Image> images, int maxDimensionX, int maxDimensionY, AtlasPadding padding, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, ref int outW, ref int outH, out float padX, out float padY, out int newMinSizeX, out int newMinSizeY)
	{
		padX = default(float);
		padY = default(float);
		newMinSizeX = default(int);
		newMinSizeY = default(int);
		return false;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasVertical")]
	[CalledBy(Type = typeof(MB2_TexturePackerHorizontalVert), Member = "_GetRectsMultiAtlasHorizontal")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void normalizeRects(AtlasPackingResult rr, AtlasPadding padding)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected MB2_TexturePacker()
	{
	}
}
