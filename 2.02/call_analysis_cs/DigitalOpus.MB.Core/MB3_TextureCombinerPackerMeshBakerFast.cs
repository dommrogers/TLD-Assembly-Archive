using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

internal class MB3_TextureCombinerPackerMeshBakerFast : MB_ITextureCombinerPacker
{
	private sealed class _003CConvertTexturesToReadableFormats_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CConvertTexturesToReadableFormats_003Ed__0(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CCreateAtlases_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AtlasPackingResult packedAtlasRects;

		public MB2_LogLevel LOG_LEVEL;

		public MB3_TextureCombinerPipeline.TexturePipelineData data;

		public MB3_TextureCombiner combiner;

		public ProgressUpdateDelegate progressInfo;

		public Texture2D[] atlases;

		public MB2_EditorMethodsInterface textureEditorMethods;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCreateAtlases_003Ed__2(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[Calls(Type = typeof(GameObject), Member = "AddComponent")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = "get_numAtlases")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_ShouldWeCreateAtlasForThisProperty")]
		[Calls(Type = typeof(GC), Member = "Collect")]
		[Calls(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CreateTemporaryTexturesForAtlas")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(bool), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB3_AtlasPackerRenderTexture), Member = "OnRenderAtlas")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Material), Member = "SetTexture")]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
		[Calls(Type = typeof(Vector2), Member = "get_one")]
		[Calls(Type = typeof(Material), Member = "SetTextureScale")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_destroyTemporaryTextures")]
		[Calls(Type = typeof(Debug), Member = "LogException")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 112)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CalculateAtlasRectanglesStatic")]
	public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MB3_TextureCombinerPackerMeshBakerFast()
	{
	}
}
