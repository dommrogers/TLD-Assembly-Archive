using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
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
		[CallerCount(Count = 83)]
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
		public _003CCombineTexturesIntoAtlasesCoroutine_003Ed__68(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(MBVersion), Member = "GetMinorVersion")]
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(MBVersion), Member = "GetMajorVersion")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_CombineTexturesIntoAtlases")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MBVersion), Member = "GetMajorVersion")]
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
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003C_CombineTexturesIntoAtlases_003Ed__69(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "<>m__Finally1")]
		[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 46)]
		[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "LoadTextureBlenders")]
		[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = "FindBestTextureBlender")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "__CombineTexturesIntoAtlases")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "__RunTexturePackerOnly")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "<>m__Finally1")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "System.IDisposable.Dispose")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "LoadPipelineData")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_CollectPropertyNames")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Stopwatch), Member = "Start")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "<>m__Finally1")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "System.IDisposable.Dispose")]
		[CallsUnknownMethods(Count = 23)]
		[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
		[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TimeSpan), Member = "ToString")]
		[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "_destroyAllTemporaryTextures")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		private void _003C_003Em__Finally1()
		{
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003C__CombineTexturesIntoAtlases_003Ed__71 : IDisposable, IEnumerator<object>, IEnumerator
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
		public _003C__CombineTexturesIntoAtlases_003Ed__71(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 46)]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "__Step1_CollectDistinctMatTexturesAndUsedObjects")]
		[Calls(Type = typeof(ProgressUpdateDelegate), Member = "Invoke")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateIdealSizesForTexturesInAtlasAndPadding")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = "OnlyOneTextureInAtlasReuseTextures")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "GenerateReport")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "__Step3_BuildAndSaveAtlasesAndStoreResults")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CreatePacker")]
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

	private sealed class _003C__RunTexturePackerOnly_003Ed__72 : IDisposable, IEnumerator<object>, IEnumerator
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
		public _003C__RunTexturePackerOnly_003Ed__72(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 58)]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "__Step1_CollectDistinctMatTexturesAndUsedObjects")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CalculateIdealSizesForTexturesInAtlasAndPadding")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "CreatePacker")]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = "OnlyOneTextureInAtlasReuseTextures")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "RunTexturePackerOnly")]
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
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
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
			return default(int);
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
			return default(int);
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
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(int);
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
			return default(bool);
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool fixOutOfBoundsUVs
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
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
			return default(int);
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public MB2_PackingAlgorithmEnum packingAlgorithm
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(MB2_PackingAlgorithmEnum);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(bool);
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
		[CallerCount(Count = 17)]
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "RunCorutineWithoutPause")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "CombineTexturesIntoAtlases")]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "RunCorutineWithoutPause")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void RunCorutineWithoutPause(IEnumerator cor, int recursionDepth)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "_CombineTexturesIntoAtlases")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "RunCorutineWithoutPause")]
	[CallsUnknownMethods(Count = 7)]
	public bool CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods = null, List<AtlasPackingResult> packingResults = null, bool onlyPackRects = false, bool splitAtlasWhenPackingIfTooBig = false)
	{
		return default(bool);
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MB3_TextureBaker._003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator CombineTexturesIntoAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods = null, CombineTexturesIntoAtlasesCoroutineResult coroutineResult = null, float maxTimePerFrame = 0.01f, List<AtlasPackingResult> packingResults = null, bool onlyPackRects = false, bool splitAtlasWhenPackingIfTooBig = false)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(_003CCombineTexturesIntoAtlasesCoroutine_003Ed__68), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "CombineTexturesIntoAtlases")]
	[CallerCount(Count = 2)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator _CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> atlasPackingResult, bool onlyPackRects, bool splitAtlasWhenPackingIfTooBig)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline.TexturePipelineData), Member = ".ctor")]
	[Calls(Type = typeof(MB3_TextureCombinerNonTextureProperties), Member = ".ctor")]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[CallsUnknownMethods(Count = 15)]
	private MB3_TextureCombinerPipeline.TexturePipelineData LoadPipelineData(Material resultMaterial, List<ShaderTextureProperty> texPropertyNames, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, List<MB_TexSet> distinctMaterialTextures)
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator __CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, MB3_TextureCombinerPipeline.TexturePipelineData data, bool splitAtlasWhenPackingIfTooBig, MB2_EditorMethodsInterface textureEditorMethods)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "MoveNext")]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator __RunTexturePackerOnly(CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, bool splitAtlasWhenPackingIfTooBig, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> packingResult)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity._003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	internal int _getNumTemporaryTextures()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(MB_TexSet), Member = "CreateColoredTexToReplaceNull")]
	[Calls(Type = typeof(MB_Utility), Member = "setSolidColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity), Member = "GetAdjustedForScaleAndOffset2")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public Texture2D _createTemporaryTexture(string propertyName, int w, int h, TextureFormat texFormat, bool mipMaps)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity._003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCopyScaledAndTiledToAtlas_003Ed__1), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(MB_Utility), Member = "createTextureCopy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	internal Texture2D _createTextureCopy(string propertyName, Texture2D t)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity._003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(MB_Utility), Member = "resampleTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	internal Texture2D _resizeTexture(string propertyName, Texture2D t, int w, int h)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(_003C_CombineTexturesIntoAtlases_003Ed__69), Member = "<>m__Finally1")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__13), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 5)]
	internal void _destroyAllTemporaryTextures()
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBakerFast._003CCreateAtlases_003Ed__2), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerUnity._003CCreateAtlases_003Ed__1), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCreateAtlases_003Ed__0), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	internal void _destroyTemporaryTextures(string propertyName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void _restoreProceduralMaterials()
	{
	}

	[Calls(Type = typeof(MB3_TextureCombiner), Member = "PrintList")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "GetTextureScale")]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "GetTextureConsideringStandardShaderKeywords")]
	[Calls(Type = typeof(MB3_TextureCombinerPipeline), Member = "_CollectPropertyNames")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 144)]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "LoadPipelineData")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	public void SuggestTreatment(List<GameObject> objsToMesh, Material[] resultMaterials, List<ShaderTextureProperty> _customShaderPropNames)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MB3_TextureCombiner), Member = "SuggestTreatment")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string PrintList(List<GameObject> gos)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAndConfigureTextureCombiner")]
	[CallsUnknownMethods(Count = 14)]
	public MB3_TextureCombiner()
	{
	}
}
