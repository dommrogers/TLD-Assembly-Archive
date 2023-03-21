using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

internal class MB3_TextureCombinerPackerMeshBaker : MB3_TextureCombinerPackerRoot
{
	private sealed class _003CCreateAtlases_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AtlasPackingResult packedAtlasRects;

		public MB2_LogLevel LOG_LEVEL;

		public MB3_TextureCombinerPipeline.TexturePipelineData data;

		public MB3_TextureCombiner combiner;

		public ProgressUpdateDelegate progressInfo;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public Texture2D[] atlases;

		private Rect[] _003CuvRects_003E5__2;

		private int _003CatlasSizeX_003E5__3;

		private int _003CatlasSizeY_003E5__4;

		private int _003CpropIdx_003E5__5;

		private ShaderTextureProperty _003Cproperty_003E5__6;

		private Color[][] _003CatlasPixels_003E5__7;

		private bool _003CisNormalMap_003E5__8;

		private int _003CtexSetIdx_003E5__9;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCreateAtlases_003Ed__0(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(MatAndTransformToMerged), Member = "GetMaterialName")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexName")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexName")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(MB3_TextureCombinerPackerMeshBaker), Member = "CopyScaledAndTiledToAtlas")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = "get_numAtlases")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 166)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 8)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_ShouldWeCreateAtlasForThisProperty")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
		[Calls(Type = typeof(GC), Member = "Collect")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_destroyTemporaryTextures")]
		[Calls(Type = typeof(Material), Member = "SetTextureScale")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[Calls(Type = typeof(Material), Member = "SetTexture")]
		[Calls(Type = typeof(Stopwatch), Member = "Start")]
		[Calls(Type = typeof(Vector2), Member = "get_one")]
		[Calls(Type = typeof(string), Member = "Concat")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CCopyScaledAndTiledToAtlas_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeshBakerMaterialTexture source;

		public MB2_LogLevel LOG_LEVEL;

		public int targX;

		public int targY;

		public int targW;

		public int targH;

		public AtlasPadding padding;

		public DRect srcSamplingRect;

		public MB3_TextureCombinerPipeline.TexturePipelineData data;

		public MB3_TextureCombiner combiner;

		public ShaderTextureProperty shaderPropertyName;

		public MB_TexSet sourceMaterial;

		public ProgressUpdateDelegate progressInfo;

		public Color[][] atlasPixels;

		private int _003Cw_003E5__2;

		private int _003Ch_003E5__3;

		private int _003Ci_003E5__4;

		private int _003Cj_003E5__5;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCopyScaledAndTiledToAtlas_003Ed__1(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[CallsUnknownMethods(Count = 141)]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "TintTextureWithTextureCombiner")]
		[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_createTextureCopy")]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public override IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CCreateAtlases_003Ed__0), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	internal static IEnumerator CopyScaledAndTiledToAtlas(MeshBakerMaterialTexture source, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName, DRect srcSamplingRect, int targX, int targY, int targW, int targH, AtlasPadding padding, Color[][] atlasPixels, bool isNormalMap, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, ProgressUpdateDelegate progressInfo = null, MB2_LogLevel LOG_LEVEL = MB2_LogLevel.info)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MB3_TextureCombinerPackerMeshBaker()
	{
	}
}
