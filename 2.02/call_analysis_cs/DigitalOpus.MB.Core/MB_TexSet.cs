using System;
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
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex);

		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props);
	}

	private class PipelineVariationAllTexturesUseSameMatTiling : PipelineVariation
	{
		private MB_TexSet texSet;

		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		public PipelineVariationAllTexturesUseSameMatTiling(MB_TexSet ts)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
		{
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref allPropsUseSameTiling_encapsulatingSamplingRect) = null;
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref propsUseDifferntTiling_obUVRect) = null;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 4)]
		public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
		{
			return default(Rect);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
		{
		}
	}

	private class PipelineVariationSomeTexturesUseDifferentMatTiling : PipelineVariation
	{
		private MB_TexSet texSet;

		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		public PipelineVariationSomeTexturesUseDifferentMatTiling(MB_TexSet ts)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
		{
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref allPropsUseSameTiling_encapsulatingSamplingRect) = null;
			System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref propsUseDifferntTiling_obUVRect) = null;
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 7)]
		public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
		{
			return default(Rect);
		}

		[CallsUnknownMethods(Count = 16)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "SetTextureScale")]
		[CallerCount(Count = 0)]
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
			return default(bool);
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(bool);
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	[CallsUnknownMethods(Count = 30)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(MB3_TestRenderTextureTestHarness), Member = "TestRender")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	public MB_TexSet(MeshBakerMaterialTexture[] tss, Vector2 uvOffset, Vector2 uvScale, MB_TextureTilingTreatment treatment)
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C_003Ec__DisplayClass8_1), Member = "<__Step1_CollectDistinctMatTexturesAndUsedObjects>b__0")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DRect), Member = "Equals")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "AreTexturesEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "NonTexturePropertiesAreEqual")]
	internal bool IsEqual(object obj, bool fixOutOfBoundsUVs, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
	{
		return default(bool);
	}

	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_height")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "CalculateAtlasRectangles")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_width")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "CalculateAtlasRectangles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[CallsUnknownMethods(Count = 5)]
	public Vector2 GetMaxRawTextureHeightWidth()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private Rect GetEncapsulatingSamplingRectIfTilingSame()
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SetEncapsulatingSamplingRectWhenMergingTexSets(DRect newEncapsulatingSamplingRect)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SetEncapsulatingSamplingRectForTesting(int propIdx, DRect newEncapsulatingSamplingRect)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void SetEncapsulatingRect(int propIdx, bool considerMeshUVs)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "_createTemporaryTexture")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
	[Calls(Type = typeof(MB_Utility), Member = "setSolidColor")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
	[CallsUnknownMethods(Count = 5)]
	public void CreateColoredTexToReplaceNull(string propName, int propIdx, bool considerMeshUVs, MB3_TextureCombiner combiner, Color col)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetThisIsOnlyTexSetInAtlasTrue()
	{
	}

	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "CalculateAtlasRectangles")]
	[CallsUnknownMethods(Count = 2)]
	public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
	{
		System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref allPropsUseSameTiling_encapsulatingSamplingRect) = null;
		System.Runtime.CompilerServices.Unsafe.As<Rect, @null>(ref propsUseDifferntTiling_obUVRect) = null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__13), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[CallsUnknownMethods(Count = 11)]
	internal void CalcInitialFullSamplingRects(bool fixOutOfBoundsUVs)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void CalcMatAndUVSamplingRects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "AreTexturesEqual")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "NonTexturePropertiesAreEqual")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "AreTexturesEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 30)]
	public bool AllTexturesAreSameForMerge(MB_TexSet other, bool considerNonTextureProperties, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(MB3_UVTransformUtility), Member = "GetShiftTransformToFitBinA")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void DrawRectsToMergeGizmos(Color encC, Color innerC)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(MatAndTransformToMerged), Member = "GetMaterialName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	internal string GetDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MatAndTransformToMerged), Member = "GetMaterialName")]
	internal string GetMatSubrectDescriptions()
	{
		return null;
	}
}
