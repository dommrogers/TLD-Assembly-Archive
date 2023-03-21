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

		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
		[CallerCount(Count = 1)]
		public void Set(int ww, int hh, int outw, int outh, Node r, bool fits, float e, float sq)
		{
		}

		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
		[CallerCount(Count = 2)]
		public float GetScore(bool doPowerOfTwoScore)
		{
			return 0f;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "printTree")]
		[CallsDeduplicatedMethods(Count = 1)]
		public void PrintTree()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeMultiAtlas")]
		[CalledBy(Type = typeof(Node), Member = "Insert")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal Node(NodeType rootType)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		private bool isLeaf()
		{
			return false;
		}

		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
		[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeMultiAtlas")]
		[CalledBy(Type = typeof(Node), Member = "Insert")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Node), Member = "Insert")]
		[Calls(Type = typeof(Node), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 94)]
		internal Node Insert(Image im, bool handed)
		{
			return null;
		}
	}

	private ProbeResult bestRoot;

	public int atlasY;

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "printTree")]
	[CalledBy(Type = typeof(ProbeResult), Member = "PrintTree")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "printTree")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 30)]
	private static void printTree(Node r, string spc)
	{
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "flattenTree")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "flattenTree")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static void flattenTree(Node r, List<Image> putHere)
	{
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "drawGizmosNode")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "DrawGizmos")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "drawGizmosNode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 18)]
	private static void drawGizmosNode(Node r)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static Texture2D createFilledTex(Color c, int w, int h)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "drawGizmosNode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DrawGizmos()
	{
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[Calls(Type = typeof(Node), Member = "Insert")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "GetExtent")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(ProbeResult), Member = "Set")]
	[Calls(Type = typeof(bool), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 40)]
	private bool ProbeSingleAtlas(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDimX, int maxAtlasDimY, ProbeResult pr)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[Calls(Type = typeof(Node), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 83)]
	private bool ProbeMultiAtlas(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDimX, int maxAtlasDimY, ProbeResult pr)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "GetExtent")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "GetExtent")]
	[CallsUnknownMethods(Count = 5)]
	internal void GetExtent(Node r, ref int x, ref int y)
	{
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CallerCount(Count = 2)]
	private int StepWidthHeight(int oldVal, int step, int maxDim)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int atPadding)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsMultiAtlas")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "GetRects")]
	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(List<>), Member = "get_Item")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(Array), Member = "Sort")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "RoundToNearestPositivePowerOfTwo")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeSingleAtlas")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "StepWidthHeight")]
	[Calls(Type = typeof(ProbeResult), Member = "GetScore")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "flattenTree")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "ScaleAtlasToFitMaxDim")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "_GetRectsSingleAtlas")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 200)]
	private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB2_TexturePackerRegular), Member = "GetRects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "RoundToNearestPositivePowerOfTwo")]
	[Calls(Type = typeof(Image), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Sort")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "ProbeMultiAtlas")]
	[Calls(Type = typeof(bool), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Stack<>), Member = "Push")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "flattenTree")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(MB2_TexturePackerRegular), Member = "GetExtent")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "CeilToNearestPowerOfTwo")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(Type = typeof(MB2_TexturePacker), Member = "normalizeRects")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 209)]
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
