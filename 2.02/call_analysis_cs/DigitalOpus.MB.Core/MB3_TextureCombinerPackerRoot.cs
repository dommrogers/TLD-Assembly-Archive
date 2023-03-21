using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

internal abstract class MB3_TextureCombinerPackerRoot : MB_ITextureCombinerPacker
{
	private sealed class _003CConvertTexturesToReadableFormats_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MB3_TextureCombinerPipeline.TexturePipelineData data;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public ProgressUpdateDelegate progressInfo;

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

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003CConvertTexturesToReadableFormats_003Ed__3(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[CallsUnknownMethods(Count = 17)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexture2D")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity._003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerFast._003CCreateAtlases_003Ed__2), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCreateAtlases_003Ed__0), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB_TexSet), Member = "CreateColoredTexToReplaceNull")]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "GetColorForTemporaryTexture")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	internal static void CreateTemporaryTexturesForAtlas(List<MB_TexSet> distinctMaterialTextures, MB3_TextureCombiner combiner, int propIdx, MB3_TextureCombinerPipeline.TexturePipelineData data)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerFast), Member = "CalculateAtlasRectangles")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CalculateAtlasRectangles")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CreateTexturePacker")]
	public static AtlasPackingResult[] CalculateAtlasRectanglesStatic(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void MakeProceduralTexturesReadable(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[Calls(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CalculateAtlasRectanglesStatic")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL);

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected MB3_TextureCombinerPackerRoot()
	{
	}
}
