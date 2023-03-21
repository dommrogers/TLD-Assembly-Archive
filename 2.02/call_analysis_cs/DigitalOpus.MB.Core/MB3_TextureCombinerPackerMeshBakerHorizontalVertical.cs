using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

internal class MB3_TextureCombinerPackerMeshBakerHorizontalVertical : MB3_TextureCombinerPackerMeshBaker
{
	private interface IPipeline
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		MB2_PackingAlgorithmEnum GetPackingAlg();

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight);

		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		MB_TextureTilingTreatment GetEdge2EdgeTreatment();

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
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

		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsUnknownMethods(Count = 2)]
		public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY)
		{
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref AatlasToFinal) = null;
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref BatlasToFinal) = null;
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref atlasX) = null;
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref atlasY) = null;
		}

		[CallerCount(Count = 0)]
		public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight)
		{
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref atlasRegularMaxWidth) = null;
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref atlasRegularMaxHeight) = null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

		[CallsUnknownMethods(Count = 7)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsUnknownMethods(Count = 2)]
		public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY)
		{
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref AatlasToFinal) = null;
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref BatlasToFinal) = null;
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref atlasX) = null;
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref atlasY) = null;
		}

		[CallerCount(Count = 0)]
		public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight)
		{
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref atlasRegularMaxWidth) = null;
			System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref atlasRegularMaxHeight) = null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CreateTexturePacker")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "MergeAtlasPackingResultStackBonA")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 28)]
	[Calls(Type = typeof(MB_TexSet), Member = "SetTilingTreatmentAndAdjustEncapsulatingSamplingRect")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB_TexSet), Member = "GetMaxRawTextureHeightWidth")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CreateTexturePacker")]
	[CallsUnknownMethods(Count = 229)]
	public override AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "MergeAtlasPackingResultStackBonA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AtlasPackingResult TestStackRectanglesHorizontal(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "MergeAtlasPackingResultStackBonA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AtlasPackingResult TestStackRectanglesVertical(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "TestStackRectanglesHorizontal")]
	[CallsUnknownMethods(Count = 52)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "TestStackRectanglesVertical")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "CalculateAtlasRectangles")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(AtlasPackingResult), Member = "CalcUsedWidthAndHeight")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private static AtlasPackingResult MergeAtlasPackingResultStackBonA(AtlasPackingResult a, AtlasPackingResult b, int maxWidthDim, int maxHeightDim, bool stretchBToAtlasWidth, IPipeline pipeline)
	{
		return null;
	}
}
