using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB_TexSet
{
	private interface PipelineVariation
	{
		void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect);

		void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment);

		Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex);

		void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props);
	}

	private class PipelineVariationAllTexturesUseSameMatTiling : PipelineVariation
	{
		private MB_TexSet texSet;

		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		public PipelineVariationAllTexturesUseSameMatTiling(MB_TexSet ts)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
		{
			allPropsUseSameTiling_encapsulatingSamplingRect = default(Rect);
			propsUseDifferntTiling_obUVRect = default(Rect);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
		{
			return default(Rect);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
		{
		}
	}

	private class PipelineVariationSomeTexturesUseDifferentMatTiling : PipelineVariation
	{
		private MB_TexSet texSet;

		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		public PipelineVariationSomeTexturesUseDifferentMatTiling(MB_TexSet ts)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
		{
			allPropsUseSameTiling_encapsulatingSamplingRect = default(Rect);
			propsUseDifferntTiling_obUVRect = default(Rect);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
		{
			return default(Rect);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
		[Calls(Type = typeof(Material), Member = "SetTextureScale")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 16)]
		public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
		{
		}
	}

	public MeshBakerMaterialTexture[] ts;

	public MatsAndGOs matsAndGOs;

	private bool _003CallTexturesUseSameMatTiling_003Ek__BackingField;

	private bool _003CthisIsOnlyTexSetInAtlas_003Ek__BackingField;

	private MB_TextureTilingTreatment _003CtilingTreatment_003Ek__BackingField;

	private Vector2 _003CobUVoffset_003Ek__BackingField;

	private Vector2 _003CobUVscale_003Ek__BackingField;

	public int idealWidth;

	public int idealHeight;

	private PipelineVariation pipelineVariation;

	public bool allTexturesUseSameMatTiling
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool thisIsOnlyTexSetInAtlas
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public MB_TextureTilingTreatment tilingTreatment
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(MB_TextureTilingTreatment);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public Vector2 obUVoffset
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public Vector2 obUVscale
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	internal DRect obUVrect
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(DRect);
		}
	}

	[CalledBy(Type = typeof(MB3_TestRenderTextureTestHarness), Member = "TestRender")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	public MB_TexSet(MeshBakerMaterialTexture[] tss, Vector2 uvOffset, Vector2 uvScale, MB_TextureTilingTreatment treatment)
	{
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<>c__DisplayClass8_1", Member = "<__Step1_CollectDistinctMatTexturesAndUsedObjects>b__0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DRect), Member = "Equals")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "AreTexturesEqual")]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "NonTexturePropertiesAreEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
	internal bool IsEqual(object obj, bool fixOutOfBoundsUVs, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "CalculateAtlasRectangles")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_width")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_height")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Vector2 GetMaxRawTextureHeightWidth()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private Rect GetEncapsulatingSamplingRectIfTilingSame()
	{
		return default(Rect);
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetEncapsulatingSamplingRectWhenMergingTexSets(DRect newEncapsulatingSamplingRect)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SetEncapsulatingSamplingRectForTesting(int propIdx, DRect newEncapsulatingSamplingRect)
	{
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<CalculateIdealSizesForTexturesInAtlasAndPadding>d__10", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void SetEncapsulatingRect(int propIdx, bool considerMeshUVs)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "_createTemporaryTexture")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
	[Calls(Type = typeof(MB_Utility), Member = "setSolidColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void CreateColoredTexToReplaceNull(string propName, int propIdx, bool considerMeshUVs, MB3_TextureCombiner combiner, Color col)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetThisIsOnlyTexSetInAtlasTrue()
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void SetAllTexturesUseSameMatTilingTrue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "CalculateAtlasRectangles")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<CalculateIdealSizesForTexturesInAtlasAndPadding>d__10", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
	{
		allPropsUseSameTiling_encapsulatingSamplingRect = default(Rect);
		propsUseDifferntTiling_obUVRect = default(Rect);
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step3_BuildAndSaveAtlasesAndStoreResults>d__13", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
	{
		return default(Rect);
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[CallsUnknownMethods(Count = 11)]
	internal void CalcInitialFullSamplingRects(bool fixOutOfBoundsUVs)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	internal void CalcMatAndUVSamplingRects()
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "AreTexturesEqual")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "NonTexturePropertiesAreEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	public bool AllTexturesAreSameForMerge(MB_TexSet other, bool considerNonTextureProperties, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "GetShiftTransformToFitBinA")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public void DrawRectsToMergeGizmos(Color encC, Color innerC)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(MatAndTransformToMerged), Member = "GetMaterialName")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	internal string GetDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(MatAndTransformToMerged), Member = "GetMaterialName")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	internal string GetMatSubrectDescriptions()
	{
		return null;
	}
}
