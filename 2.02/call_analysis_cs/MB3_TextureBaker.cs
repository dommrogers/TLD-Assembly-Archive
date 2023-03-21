using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
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
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[DebuggerHidden]
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

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CCreateAtlasesCoroutine_003Ed__94(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(MB3_TextureCombiner), Member = "CombineTexturesIntoAtlasesCoroutine")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(MB_MultiMaterial), Member = ".ctor")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 135)]
		[Calls(Type = typeof(MB3_TextureBaker), Member = "unpackMat2RectMap")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAndConfigureTextureCombiner")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(MB3_TextureBaker), Member = "_ValidateResultMaterials")]
		[Calls(Type = typeof(MB3_MeshBakerRoot), Member = "DoCombinedValidate")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying")]
		[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(string), Member = "SplitInternal")]
		[Calls(Type = typeof(MBVersionConcrete), Member = "GetMajorVersion")]
		[Calls(Type = typeof(MBVersionConcrete), Member = "GetMajorVersion")]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
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
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public virtual int atlasPadding
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	public virtual int maxAtlasSize
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

	public virtual bool resizePowerOfTwoTextures
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

	public virtual bool fixOutOfBoundsUVs
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	public virtual int maxTilingBakeSize
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public virtual List<ShaderTextureProperty> customShaderProperties
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		set
		{
		}
	}

	public virtual List<string> customShaderPropNames
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool doMultiMaterialSplitAtlasesIfTooBig
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	public virtual bool doMultiMaterialSplitAtlasesIfOBUVs
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool doSuggestTreatment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[CalledBy(Type = typeof(BakeTexturesAtRuntime), Member = "OnGUI")]
	[CallerCount(Count = 2)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	public IEnumerator CreateAtlasesCoroutine(ProgressUpdateDelegate progressInfo, CreateAtlasesCoroutineResult coroutineResult, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = null, float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[CalledBy(Type = typeof(BakeTexturesAtRuntime), Member = "OnGUI")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = "RunCorutineWithoutPause")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlasesCoroutine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public MB_AtlasesAndRects[] CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, MB2_EditorMethodsInterface editorMethods = null)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(_003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void unpackMat2RectMap(MB2_TextureBakeResults tbr)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(MB3_TextureCombiner), Member = ".ctor")]
	[CalledBy(Type = typeof(_003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 8)]
	public MB3_TextureCombiner CreateAndConfigureTextureCombiner()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	public static void ConfigureNewMaterialToMatchOld(Material newMat, Material original)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "_ValidateResultMaterials")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(MB3_TextureBaker), Member = "_ValidateResultMaterials")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string PrintSet(HashSet<Material> s)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "PrintSet")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "PrintSet")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[CalledBy(Type = typeof(_003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 58)]
	private bool _ValidateResultMaterials()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public MB3_TextureBaker()
	{
	}
}
