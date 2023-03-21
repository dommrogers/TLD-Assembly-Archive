using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB2_TexturePackerRegular : MB2_TexturePacker
{
	private class ProbeResult
	{
		public int w;

		public int h;

		public int outW;

		public int outH;

		public Node root;

		public bool largerOrEqualToMaxDim;

		public float efficiency;

		public float squareness;

		public float totalAtlasArea;

		public int numAtlases;

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
		public void Set(int ww, int hh, int outw, int outh, Node r, bool fits, float e, float sq)
		{
		}

		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
		public float GetScore(bool doPowerOfTwoScore)
		{
			return default(float);
		}

		[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "printTree")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void PrintTree()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ProbeResult()
		{
		}
	}

	internal class Node
	{
		internal NodeType isFullAtlas;

		internal Node[] child;

		internal PixRect r;

		internal Image img;

		private ProbeResult bestRoot;

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
		[CalledBy(Type = typeof(Node), Member = "Insert")]
		[CalledBy(Type = typeof(Node), Member = "Insert")]
		internal Node(NodeType rootType)
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 0)]
		private bool isLeaf()
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(Node), Member = "Insert")]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
		[Calls(Type = typeof(Node), Member = ".ctor")]
		[Calls(Type = typeof(Node), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Node), Member = "Insert")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(Node), Member = "Insert")]
		[Calls(Type = typeof(Node), Member = "Insert")]
		[CallsUnknownMethods(Count = 94)]
		internal Node Insert(Image im, bool handed)
		{
			return null;
		}
	}

	private ProbeResult bestRoot;

	public int atlasY;

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(ProbeResult), Member = "PrintTree")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "printTree")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "printTree")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void printTree(Node r, string spc)
	{
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "flattenTree")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "flattenTree")]
	private static void flattenTree(Node r, List<Image> putHere)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "drawGizmosNode")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "drawGizmosNode")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "DrawGizmos")]
	[CallsUnknownMethods(Count = 18)]
	private static void drawGizmosNode(Node r)
	{
	}

	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	private static Texture2D createFilledTex(Color c, int w, int h)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "drawGizmosNode")]
	[CallsUnknownMethods(Count = 3)]
	public void DrawGizmos()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(ProbeResult), Member = "Set")]
	[Calls(Type = typeof(Node), Member = "Insert")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "GetExtent")]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool ProbeSingleAtlas(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDimX, int maxAtlasDimY, ProbeResult pr)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	private bool ProbeMultiAtlas(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDimX, int maxAtlasDimY, ProbeResult pr)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "GetExtent")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "GetExtent")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
	internal void GetExtent(Node r, ref int x, ref int y)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	private int StepWidthHeight(int oldVal, int step, int maxDim)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int atPadding)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
	{
		return null;
	}

	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "StepWidthHeight")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "flattenTree")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "ScaleAtlasToFitMaxDim")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "GetRects")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CallsUnknownMethods(Count = 202)]
	[Calls(Type = typeof(ProbeResult), Member = "GetScore")]
	[Calls(Type = typeof(ProbeResult), Member = "GetScore")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "StepWidthHeight")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "RoundToNearestPositivePowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "normalizeRects")]
	[CallsUnknownMethods(Count = 210)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "GetRects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "RoundToNearestPositivePowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "RoundToNearestPositivePowerOfTwo")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "RoundToNearestPositivePowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeMultiAtlas")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "GetExtent")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "flattenTree")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "RoundToNearestPositivePowerOfTwo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeMultiAtlas")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeMultiAtlas")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private AtlasPackingResult[] _GetRectsMultiAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB2_TexturePackerRegular()
	{
	}
}
