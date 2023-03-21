using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB3_TextureCombinerPipeline
{
	public struct CreateAtlasForProperty
	{
		public bool allTexturesAreNull;

		public bool allTexturesAreSame;

		public bool allNonTexturePropsAreSame;

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		public override string ToString()
		{
			return null;
		}
	}

	internal class TexturePipelineData
	{
		internal MB2_TextureBakeResults _textureBakeResults;

		internal int _atlasPadding;

		internal int _maxAtlasWidth;

		internal int _maxAtlasHeight;

		internal bool _useMaxAtlasHeightOverride;

		internal bool _useMaxAtlasWidthOverride;

		internal bool _resizePowerOfTwoTextures;

		internal bool _fixOutOfBoundsUVs;

		internal int _maxTilingBakeSize;

		internal bool _saveAtlasesAsAssets;

		internal MB2_PackingAlgorithmEnum _packingAlgorithm;

		internal bool _meshBakerTexturePackerForcePowerOfTwo;

		internal List<ShaderTextureProperty> _customShaderPropNames;

		internal bool _normalizeTexelDensity;

		internal bool _considerNonTextureProperties;

		internal MB3_TextureCombinerNonTextureProperties nonTexturePropertyBlender;

		internal List<MB_TexSet> distinctMaterialTextures;

		internal List<GameObject> allObjsToMesh;

		internal List<Material> allowedMaterialsFilter;

		internal List<ShaderTextureProperty> texPropertyNames;

		internal CreateAtlasForProperty[] allTexturesAreNullAndSameColor;

		internal Material resultMaterial;

		internal int numAtlases
		{
			[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CreateAtlases>d__0", Member = "MoveNext")]
			[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBakerFast.<CreateAtlases>d__2", Member = "MoveNext")]
			[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerOneTextureInAtlas.<CreateAtlases>d__2", Member = "MoveNext")]
			[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerUnity.<CreateAtlases>d__1", Member = "MoveNext")]
			[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
			[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step3_BuildAndSaveAtlasesAndStoreResults>d__13", Member = "MoveNext")]
			[CallerCount(Count = 7)]
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return 0;
			}
		}

		[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__CombineTexturesIntoAtlases>d__71", Member = "MoveNext")]
		[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__RunTexturePackerOnly>d__72", Member = "MoveNext")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool OnlyOneTextureInAtlasReuseTextures()
		{
			return false;
		}

		[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "LoadPipelineData")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public TexturePipelineData()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public TexturePipelineData data;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass5_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_1
	{
		public int i;

		public _003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass5_1()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal bool _003C_CollectPropertyNames_003Eb__0(ShaderTextureProperty x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public TexturePipelineData data;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public MB_TexSet setOfTexs;

		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass8_1()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MB_TexSet), Member = "IsEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Eb__0(MB_TexSet x)
		{
			return false;
		}
	}

	private sealed class _003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TexturePipelineData data;

		public ProgressUpdateDelegate progressInfo;

		public MB2_LogLevel LOG_LEVEL;

		public MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public List<GameObject> usedObjsToMesh;

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
		public _003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stopwatch), Member = "Start")]
		[Calls(Type = typeof(List<>), Member = "get_Item")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
		[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
		[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetSubmeshArea")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(Dictionary<, >), Member = "Add")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(MB_Utility), Member = "AreAllSharedMaterialsDistinct")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Vector2), Member = "get_one")]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[Calls(Type = typeof(Shader), Member = "PropertyToID")]
		[Calls(Type = typeof(Material), Member = "HasProperty")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetTextureConsideringStandardShaderKeywords")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Texture2D), Member = "get_format")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying")]
		[Calls(Type = typeof(Material), Member = "GetTextureScale")]
		[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = ".ctor")]
		[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "CollectAverageValuesOfNonTextureProperties")]
		[Calls(Type = typeof(MB_TexSet), Member = ".ctor")]
		[Calls(Type = typeof(DRect), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(MB3_TextureCombinerMerging), Member = ".ctor")]
		[Calls(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
		[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
		[Calls(Type = typeof(long), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 208)]
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

	private sealed class _003CCalculateIdealSizesForTexturesInAtlasAndPadding_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TexturePipelineData data;

		public MB2_LogLevel LOG_LEVEL;

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
		public _003CCalculateIdealSizesForTexturesInAtlasAndPadding_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stopwatch), Member = "Start")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(MB_TexSet), Member = "SetTilingTreatmentAndAdjustEncapsulatingSamplingRect")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_ShouldWeCreateAtlasForThisProperty")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Vector2), Member = "get_one")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexName")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
		[Calls(Type = typeof(MB_TexSet), Member = "SetEncapsulatingRect")]
		[Calls(Type = typeof(MatAndTransformToMerged), Member = "GetMaterialName")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetAdjustedForScaleAndOffset2Dimensions")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
		[Calls(Type = typeof(TimeSpan), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 113)]
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

	private sealed class _003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TexturePipelineData data;

		public MB2_LogLevel LOG_LEVEL;

		public MB_ITextureCombinerPacker packer;

		public ProgressUpdateDelegate progressInfo;

		public MB3_TextureCombiner combiner;

		public AtlasPackingResult atlasPackingResult;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public StringBuilder report;

		public MB_AtlasesAndRects resultAtlasesAndRects;

		private Stopwatch _003Csw_003E5__2;

		private Texture2D[] _003Catlases_003E5__3;

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
		public _003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stopwatch), Member = "Start")]
		[Calls(Type = typeof(GC), Member = "Collect")]
		[Calls(Type = typeof(TexturePipelineData), Member = "get_numAtlases")]
		[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
		[Calls(Type = typeof(TimeSpan), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(Environment), Member = "get_NewLine")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_ShouldWeCreateAtlasForThisProperty")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(MB_TexSet), Member = "GetMaterialTilingRectForTextureBakerResults")]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[Calls(Type = typeof(ShaderTextureProperty), Member = "GetNames")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_destroyAllTemporaryTextures")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 102)]
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

	public static bool USE_EXPERIMENTAL_HOIZONTALVERTICAL;

	public static ShaderTextureProperty[] shaderTexPropertyNames;

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CreateAtlases>d__0", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBakerFast.<CreateAtlases>d__2", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerUnity.<CreateAtlases>d__1", Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateAllTexturesAreNullAndSameColor")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
	[CalledBy(Type = typeof(_003CCalculateIdealSizesForTexturesInAtlasAndPadding_003Ed__10), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__13), Member = "MoveNext")]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool _ShouldWeCreateAtlasForThisProperty(int propertyIndex, bool considerNonTextureProperties, CreateAtlasForProperty[] allTexturesAreNullAndSameColor)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<_CombineTexturesIntoAtlases>d__69", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Material), Member = "GetTextureScale")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 81)]
	internal static bool _CollectPropertyNames(TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool _ShouldWeCreateAtlasForThisProperty(int propertyIndex, CreateAtlasForProperty[] allTexturesAreNullAndSameColor, TexturePipelineData data)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(Type = typeof(_003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Material), Member = "GetTexture")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static Texture GetTextureConsideringStandardShaderKeywords(string shaderName, Material mat, string propertyName)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__CombineTexturesIntoAtlases>d__71", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__RunTexturePackerOnly>d__72", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static IEnumerator __Step1_CollectDistinctMatTexturesAndUsedObjects(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, List<GameObject> usedObjsToMesh, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CCalculateIdealSizesForTexturesInAtlasAndPadding_003Ed__10), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "GetColorAsItWouldAppearInAtlasIfNoTexture")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "AreTexturesEqual")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_ShouldWeCreateAtlasForThisProperty")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 48)]
	private static CreateAtlasForProperty[] CalculateAllTexturesAreNullAndSameColor(TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__CombineTexturesIntoAtlases>d__71", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__RunTexturePackerOnly>d__72", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static IEnumerator CalculateIdealSizesForTexturesInAtlasAndPadding(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__RunTexturePackerOnly>d__72", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	internal static AtlasPackingResult[] RunTexturePackerOnly(TexturePipelineData data, bool doSplitIntoMultiAtlasIfTooBig, MB_ITextureCombinerPacker texturePacker, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__CombineTexturesIntoAtlases>d__71", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__RunTexturePackerOnly>d__72", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	internal static MB_ITextureCombinerPacker CreatePacker(bool onlyOneTextureInAtlasReuseTextures, MB2_PackingAlgorithmEnum packingAlgorithm)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__CombineTexturesIntoAtlases>d__71", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal static IEnumerator __Step3_BuildAndSaveAtlasesAndStoreResults(MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, ProgressUpdateDelegate progressInfo, TexturePipelineData data, MB3_TextureCombiner combiner, MB_ITextureCombinerPacker packer, AtlasPackingResult atlasPackingResult, MB2_EditorMethodsInterface textureEditorMethods, MB_AtlasesAndRects resultAtlasesAndRects, StringBuilder report, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<__CombineTexturesIntoAtlases>d__71", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(TexturePipelineData), Member = "get_numAtlases")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_isNull")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_ShouldWeCreateAtlasForThisProperty")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexName")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_width")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_height")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "ToString")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 101)]
	internal static StringBuilder GenerateReport(TexturePipelineData data)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerRoot), Member = "CalculateAtlasRectanglesStatic")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerHorizontalVertical), Member = "CalculateAtlasRectangles")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	internal static MB2_TexturePacker CreateTexturePacker(MB2_PackingAlgorithmEnum _packingAlgorithm)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "GetAdjustedForScaleAndOffset2")]
	[CalledBy(Type = typeof(_003CCalculateIdealSizesForTexturesInAtlasAndPadding_003Ed__10), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_width")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "get_height")]
	[Calls(Type = typeof(MeshBakerMaterialTexture), Member = "GetTexName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	internal static Vector2 GetAdjustedForScaleAndOffset2Dimensions(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
	{
		return default(Color32);
	}

	[CalledBy(Type = typeof(_003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "GetIndices")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	internal static float GetSubmeshArea(Mesh m, int submeshIdx)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	internal static bool IsPowerOfTwo(int x)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MB3_TextureCombinerPipeline()
	{
	}
}
