using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_TextureCombiner
{
	private class TemporaryTexture
	{
		internal string property;

		internal Texture2D texture;

		[DeduplicatedMethod]
		[CallerCount(Count = 88)]
		public TemporaryTexture(string prop, Texture2D tex)
		{
		}
	}

	public class CombineTexturesIntoAtlasesCoroutineResult
	{
		public bool success;

		public bool isFinished;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public CombineTexturesIntoAtlasesCoroutineResult()
		{
		}
	}

	private sealed class _003CCombineTexturesIntoAtlasesCoroutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CombineTexturesIntoAtlasesCoroutineResult coroutineResult;

		public float maxTimePerFrame;

		public MB3_TextureCombiner _003C_003E4__this;

		public ProgressUpdateDelegate progressInfo;

		public MB_AtlasesAndRects resultAtlasesAndRects;

		public Material resultMaterial;

		public List<GameObject> objsToMesh;

		public List<Material> allowedMaterialsFilter;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public List<AtlasPackingResult> packingResults;

		public bool onlyPackRects;

		public bool splitAtlasWhenPackingIfTooBig;

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
		public _003CCombineTexturesIntoAtlasesCoroutine_003Ed__68(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_CombineTexturesIntoAtlases")]
		[Calls(Type = typeof(MBVersion), Member = "GetMajorVersion")]
		[Calls(Type = typeof(MBVersion), Member = "GetMinorVersion")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
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

	private sealed class _003C_CombineTexturesIntoAtlases_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MB3_TextureCombiner _003C_003E4__this;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public List<GameObject> objsToMesh;

		public CombineTexturesIntoAtlasesCoroutineResult result;

		public ProgressUpdateDelegate progressInfo;

		public Material resultMaterial;

		public List<Material> allowedMaterialsFilter;

		public bool onlyPackRects;

		public bool splitAtlasWhenPackingIfTooBig;

		public List<AtlasPackingResult> atlasPackingResult;

		public MB_AtlasesAndRects resultAtlasesAndRects;

		private Stopwatch _003Csw_003E5__2;

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
		public _003C_CombineTexturesIntoAtlases_003Ed__69(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "<>m__Finally1")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "<>m__Finally1")]
		[Calls(Type = typeof(Stopwatch), Member = "Start")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "LoadPipelineData")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_CollectPropertyNames")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "LoadTextureBlenders")]
		[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "FindBestTextureBlender")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "__CombineTexturesIntoAtlases")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "__RunTexturePackerOnly")]
		[Calls(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "System.IDisposable.Dispose")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 46)]
		private bool MoveNext()
		{
			return false;
		}

		[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "System.IDisposable.Dispose")]
		[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_destroyAllTemporaryTextures")]
		[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
		[Calls(Type = typeof(TimeSpan), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 23)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003C__CombineTexturesIntoAtlases_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MB3_TextureCombiner _003C_003E4__this;

		public MB3_TextureCombinerPipeline.TexturePipelineData data;

		public ProgressUpdateDelegate progressInfo;

		public CombineTexturesIntoAtlasesCoroutineResult result;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public bool splitAtlasWhenPackingIfTooBig;

		public MB_AtlasesAndRects resultAtlasesAndRects;

		private StringBuilder _003Creport_003E5__2;

		private MB_ITextureCombinerPacker _003CtexturePaker_003E5__3;

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
		public _003C__CombineTexturesIntoAtlases_003Ed__71(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "__Step3_BuildAndSaveAtlasesAndStoreResults")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = "OnlyOneTextureInAtlasReuseTextures")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CreatePacker")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateIdealSizesForTexturesInAtlasAndPadding")]
		[Calls(Type = typeof(bool), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "__Step1_CollectDistinctMatTexturesAndUsedObjects")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 45)]
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

	private sealed class _003C__RunTexturePackerOnly_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MB3_TextureCombiner _003C_003E4__this;

		public MB3_TextureCombinerPipeline.TexturePipelineData data;

		public CombineTexturesIntoAtlasesCoroutineResult result;

		public MB2_EditorMethodsInterface textureEditorMethods;

		public bool splitAtlasWhenPackingIfTooBig;

		public List<AtlasPackingResult> packingResult;

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
		public _003C__RunTexturePackerOnly_003Ed__72(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = "OnlyOneTextureInAtlasReuseTextures")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CreatePacker")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "RunTexturePackerOnly")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateIdealSizesForTexturesInAtlasAndPadding")]
		[Calls(Type = typeof(bool), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "__Step1_CollectDistinctMatTexturesAndUsedObjects")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 57)]
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

	public MB2_LogLevel LOG_LEVEL;

	protected MB2_TextureBakeResults _textureBakeResults;

	protected int _atlasPadding;

	protected int _maxAtlasSize;

	protected int _maxAtlasWidthOverride;

	protected int _maxAtlasHeightOverride;

	protected bool _useMaxAtlasWidthOverride;

	protected bool _useMaxAtlasHeightOverride;

	protected bool _resizePowerOfTwoTextures;

	protected bool _fixOutOfBoundsUVs;

	protected int _maxTilingBakeSize;

	protected bool _saveAtlasesAsAssets;

	protected MB2_PackingAlgorithmEnum _packingAlgorithm;

	protected bool _meshBakerTexturePackerForcePowerOfTwo;

	protected List<ShaderTextureProperty> _customShaderPropNames;

	protected bool _normalizeTexelDensity;

	protected bool _considerNonTextureProperties;

	private List<TemporaryTexture> _temporaryTextures;

	public static bool _RunCorutineWithoutPauseIsRunning;

	public MB2_TextureBakeResults textureBakeResults
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public int atlasPadding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int maxAtlasSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual int maxAtlasWidthOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual int maxAtlasHeightOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool useMaxAtlasWidthOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public virtual bool useMaxAtlasHeightOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool resizePowerOfTwoTextures
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool fixOutOfBoundsUVs
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int maxTilingBakeSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool saveAtlasesAsAssets
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public MB2_PackingAlgorithmEnum packingAlgorithm
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(MB2_PackingAlgorithmEnum);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool meshBakerTexturePackerForcePowerOfTwo
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public List<ShaderTextureProperty> customShaderPropNames
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	public bool considerNonTextureProperties
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "RunCorutineWithoutPause")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "CombineTexturesIntoAtlases")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "RunCorutineWithoutPause")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void RunCorutineWithoutPause(IEnumerator cor, int recursionDepth)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "_CombineTexturesIntoAtlases")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "RunCorutineWithoutPause")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bool CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods = null, List<AtlasPackingResult> packingResults = null, bool onlyPackRects = false, bool splitAtlasWhenPackingIfTooBig = false)
	{
		return false;
	}

	[CalledBy(TypeFullName = "MB3_TextureBaker.<CreateAtlasesCoroutine>d__94", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator CombineTexturesIntoAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods = null, CombineTexturesIntoAtlasesCoroutineResult coroutineResult = null, float maxTimePerFrame = 0.01f, List<AtlasPackingResult> packingResults = null, bool onlyPackRects = false, bool splitAtlasWhenPackingIfTooBig = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "CombineTexturesIntoAtlases")]
	[CalledBy(Type = typeof(_003CCombineTexturesIntoAtlasesCoroutine_003Ed__68), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator _CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> atlasPackingResult, bool onlyPackRects, bool splitAtlasWhenPackingIfTooBig)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = ".ctor")]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private MB3_TextureCombinerPipeline.TexturePipelineData LoadPipelineData(Material resultMaterial, List<ShaderTextureProperty> texPropertyNames, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, List<MB_TexSet> distinctMaterialTextures)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator __CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, MB3_TextureCombinerPipeline.TexturePipelineData data, bool splitAtlasWhenPackingIfTooBig, MB2_EditorMethodsInterface textureEditorMethods)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator __RunTexturePackerOnly(CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, bool splitAtlasWhenPackingIfTooBig, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> packingResult)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerUnity.<CreateAtlases>d__1", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int _getNumTemporaryTextures()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB_TexSet), Member = "CreateColoredTexToReplaceNull")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "GetAdjustedForScaleAndOffset2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(MB_Utility), Member = "setSolidColor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public Texture2D _createTemporaryTexture(string propertyName, int w, int h, TextureFormat texFormat, bool mipMaps)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CopyScaledAndTiledToAtlas>d__1", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerUnity.<CreateAtlases>d__1", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB_Utility), Member = "createTextureCopy")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	internal Texture2D _createTextureCopy(string propertyName, Texture2D t)
	{
		return null;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerUnity.<CreateAtlases>d__1", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB_Utility), Member = "resampleTexture")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	internal Texture2D _resizeTexture(string propertyName, Texture2D t, int w, int h)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "<>m__Finally1")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step3_BuildAndSaveAtlasesAndStoreResults>d__13", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void _destroyAllTemporaryTextures()
	{
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CreateAtlases>d__0", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBakerFast.<CreateAtlases>d__2", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerUnity.<CreateAtlases>d__1", Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 33)]
	internal void _destroyTemporaryTextures(string propertyName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void _restoreProceduralMaterials()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
	[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatDouble")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "LoadPipelineData")]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_CollectPropertyNames")]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetTextureConsideringStandardShaderKeywords")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "GetTextureScale")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "PrintList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 144)]
	public void SuggestTreatment(List<GameObject> objsToMesh, Material[] resultMaterials, List<ShaderTextureProperty> _customShaderPropNames)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private string PrintList(List<GameObject> gos)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAndConfigureTextureCombiner")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public MB3_TextureCombiner()
	{
	}
}
