using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_TextureBaker : MB3_MeshBakerRoot
{
	public delegate void OnCombinedTexturesCoroutineSuccess();

	public delegate void OnCombinedTexturesCoroutineFail();

	public class CreateAtlasesCoroutineResult
	{
		public bool success;

		public bool isFinished;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public CreateAtlasesCoroutineResult()
		{
		}
	}

	private sealed class _003CCreateAtlasesCoroutine_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CreateAtlasesCoroutineResult coroutineResult;

		public MB3_TextureBaker _003C_003E4__this;

		public float maxTimePerFrame;

		public bool saveAtlasesAsAssets;

		public ProgressUpdateDelegate progressInfo;

		public MB2_EditorMethodsInterface editorMethods;

		private MB3_TextureCombiner _003Ccombiner_003E5__2;

		private int _003Ci_003E5__3;

		private MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult _003CcoroutineResult2_003E5__4;

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
		public _003CCreateAtlasesCoroutine_003Ed__94(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MBVersionConcrete), Member = "GetMajorVersion")]
		[Calls(Type = typeof(string), Member = "SplitInternal")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(TypeFullName = "System.Number", Member = "ParseInt32")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying")]
		[Calls(Type = typeof(MB3_MeshBakerRoot), Member = "DoCombinedValidate")]
		[Calls(Type = typeof(MB3_TextureBaker), Member = "_ValidateResultMaterials")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAndConfigureTextureCombiner")]
		[Calls(Type = typeof(MB3_TextureCombiner), Member = "CombineTexturesIntoAtlasesCoroutine")]
		[Calls(Type = typeof(MB3_TextureBaker), Member = "unpackMat2RectMap")]
		[Calls(Type = typeof(MB_MultiMaterial), Member = ".ctor")]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 135)]
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

	protected bool _useMaxAtlasWidthOverride;

	protected int _maxAtlasWidthOverride;

	protected bool _useMaxAtlasHeightOverride;

	protected int _maxAtlasHeightOverride;

	protected bool _resizePowerOfTwoTextures;

	protected bool _fixOutOfBoundsUVs;

	protected int _maxTilingBakeSize;

	protected MB2_PackingAlgorithmEnum _packingAlgorithm;

	protected bool _meshBakerTexturePackerForcePowerOfTwo;

	protected List<ShaderTextureProperty> _customShaderProperties;

	protected List<string> _customShaderPropNames_Depricated;

	protected bool _doMultiMaterial;

	protected bool _doMultiMaterialSplitAtlasesIfTooBig;

	protected bool _doMultiMaterialSplitAtlasesIfOBUVs;

	protected Material _resultMaterial;

	protected bool _considerNonTextureProperties;

	protected bool _doSuggestTreatment;

	private CreateAtlasesCoroutineResult _coroutineResult;

	public MB_MultiMaterial[] resultMaterials;

	public List<GameObject> objsToMesh;

	public OnCombinedTexturesCoroutineSuccess onBuiltAtlasesSuccess;

	public OnCombinedTexturesCoroutineFail onBuiltAtlasesFail;

	public MB_AtlasesAndRects[] OnCombinedTexturesCoroutineAtlasesAndRects;

	public override MB2_TextureBakeResults textureBakeResults
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		set
		{
		}
	}

	public virtual int atlasPadding
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

	public virtual int maxAtlasSize
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
			return 0;
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
			return false;
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

	public virtual bool resizePowerOfTwoTextures
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

	public virtual bool fixOutOfBoundsUVs
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

	public virtual int maxTilingBakeSize
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

	public virtual MB2_PackingAlgorithmEnum packingAlgorithm
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
		[CallerCount(Count = 1)]
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

	public virtual List<ShaderTextureProperty> customShaderProperties
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 37)]
		set
		{
		}
	}

	public virtual List<string> customShaderPropNames
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	public virtual bool doMultiMaterial
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

	public virtual bool doMultiMaterialSplitAtlasesIfTooBig
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

	public virtual bool doMultiMaterialSplitAtlasesIfOBUVs
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

	public virtual Material resultMaterial
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	public bool doSuggestTreatment
	{
		[DeduplicatedMethod]
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

	public CreateAtlasesCoroutineResult CoroutineResult
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	public MB_AtlasesAndRects[] CreateAtlases()
	{
		return null;
	}

	[CalledBy(Type = typeof(BakeTexturesAtRuntime), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator CreateAtlasesCoroutine(ProgressUpdateDelegate progressInfo, CreateAtlasesCoroutineResult coroutineResult, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = null, float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	[CalledBy(Type = typeof(BakeTexturesAtRuntime), Member = "OnGUI")]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlasesCoroutine")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "RunCorutineWithoutPause")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public MB_AtlasesAndRects[] CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 38)]
	private void unpackMat2RectMap(MB2_TextureBakeResults tbr)
	{
	}

	[CalledBy(Type = typeof(_003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public MB3_TextureCombiner CreateAndConfigureTextureCombiner()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 34)]
	public static void ConfigureNewMaterialToMatchOld(Material newMat, Material original)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "_ValidateResultMaterials")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private string PrintSet(HashSet<Material> s)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(HashSet<>), Member = "IsProperSubsetOf")]
	[Calls(Type = typeof(HashSet<>), Member = "ExceptWith")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "PrintSet")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 58)]
	private bool _ValidateResultMaterials()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public MB3_TextureBaker()
	{
	}
}
