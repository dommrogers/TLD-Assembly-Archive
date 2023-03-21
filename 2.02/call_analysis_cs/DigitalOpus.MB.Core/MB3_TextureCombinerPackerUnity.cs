using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

internal class MB3_TextureCombinerPackerUnity : MB3_TextureCombinerPackerRoot
{
	private sealed class _003CCreateAtlases_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AtlasPackingResult packedAtlasRects;

		public MB3_TextureCombinerPipeline.TexturePipelineData data;

		public MB2_LogLevel LOG_LEVEL;

		public MB3_TextureCombiner combiner;

		public ProgressUpdateDelegate progressInfo;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public Texture2D[] atlases;

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
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CCreateAtlases_003Ed__1(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Texture2D), Member = "PackTextures")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
		[Calls(Type = typeof(Vector2), Member = "get_one")]
		[Calls(Type = typeof(Material), Member = "SetTextureScale")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_destroyTemporaryTextures")]
		[Calls(Type = typeof(GC), Member = "Collect")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 107)]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "_copyTexturesIntoAtlas")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 11)]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = "get_numAtlases")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_ShouldWeCreateAtlasForThisProperty")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_getNumTemporaryTextures")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "GetAdjustedForScaleAndOffset2")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "TintTextureWithTextureCombiner")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_resizeTexture")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_createTextureCopy")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public override AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(MB_Utility), Member = "resampleTexture")]
	[CalledBy(Type = typeof(_003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(MB_Utility), Member = "setSolidColor")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 1)]
	internal static Texture2D _copyTexturesIntoAtlas(Texture2D[] texToPack, int padding, Rect[] rs, int w, int h, MB3_TextureCombiner combiner)
	{
		return null;
	}

	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "_createTemporaryTexture")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
	[CalledBy(Type = typeof(_003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 31)]
	internal static Texture2D GetAdjustedForScaleAndOffset2(string propertyName, MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public MB3_TextureCombinerPackerUnity()
	{
	}
}
