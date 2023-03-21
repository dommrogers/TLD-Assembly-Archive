using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

internal class MB3_TextureCombinerPackerMeshBakerHorizontalVertical : MB3_TextureCombinerPackerMeshBaker
{
	private interface IPipeline
	{
		MB2_PackingAlgorithmEnum GetPackingAlg();

		void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight);

		MB_TextureTilingTreatment GetEdge2EdgeTreatment();

		void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue);

		void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY);

		void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight);
	}

	private class VerticalPipeline : IPipeline
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public MB2_PackingAlgorithmEnum GetPackingAlg()
		{
			return default(MB2_PackingAlgorithmEnum);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public MB_TextureTilingTreatment GetEdge2EdgeTreatment()
		{
			return default(MB_TextureTilingTreatment);
		}

		[CallerCount(Count = 0)]
		public void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY)
		{
			AatlasToFinal = default(Rect);
			BatlasToFinal = default(Rect);
			atlasX = default(int);
			atlasY = default(int);
		}

		[CallerCount(Count = 0)]
		public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight)
		{
			atlasRegularMaxWidth = default(int);
			atlasRegularMaxHeight = default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public VerticalPipeline()
		{
		}
	}

	private class HorizontalPipeline : IPipeline
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public MB2_PackingAlgorithmEnum GetPackingAlg()
		{
			return default(MB2_PackingAlgorithmEnum);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public MB_TextureTilingTreatment GetEdge2EdgeTreatment()
		{
			return default(MB_TextureTilingTreatment);
		}

		[CallerCount(Count = 0)]
		public void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY)
		{
			AatlasToFinal = default(Rect);
			BatlasToFinal = default(Rect);
			atlasX = default(int);
			atlasY = default(int);
		}

		[CallerCount(Count = 0)]
		public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight)
		{
			atlasRegularMaxWidth = default(int);
			atlasRegularMaxHeight = default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public HorizontalPipeline()
		{
		}
	}

	public enum AtlasDirection
	{
		horizontal,
		vertical
	}

	private AtlasDirection _atlasDirection;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB3_TextureCombinerPackerMeshBakerHorizontalVertical(AtlasDirection ad)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MB_TexSet), Member = "SetTilingTreatmentAndAdjustEncapsulatingSamplingRect")]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CreateTexturePacker")]
	[Calls(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "MergeAtlasPackingResultStackBonA")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 229)]
	public override AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "MergeAtlasPackingResultStackBonA")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static AtlasPackingResult TestStackRectanglesHorizontal(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "MergeAtlasPackingResultStackBonA")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static AtlasPackingResult TestStackRectanglesVertical(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "CalculateAtlasRectangles")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "TestStackRectanglesHorizontal")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "TestStackRectanglesVertical")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 52)]
	private static AtlasPackingResult MergeAtlasPackingResultStackBonA(AtlasPackingResult a, AtlasPackingResult b, int maxWidthDim, int maxHeightDim, bool stretchBToAtlasWidth, IPipeline pipeline)
	{
		return null;
	}
}
