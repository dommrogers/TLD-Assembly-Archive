using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.SceneManagement;

namespace UnityEngine.Rendering.PostProcessing;

public static class RuntimeUtilities
{
	private sealed class _003CGetAllSceneObjects_003Ed__82<T> : IEnumerable<T>, IDisposable, IEnumerable, IEnumerator, IEnumerator<T> where T : Component
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Queue<Transform> _003Cqueue_003E5__2;

		private GameObject[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private IEnumerator _003C_003E7__wrap4;

		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CGetAllSceneObjects_003Ed__82(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
		[CallsUnknownMethods(Count = 33)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		private void _003C_003Em__Finally1()
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Assembly, IEnumerable<Type>> _003C_003E9__89_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal IEnumerable<Type> _003CGetAllAssemblyTypes_003Eb__89_0(Assembly t)
		{
			return null;
		}
	}

	private static Texture2D m_WhiteTexture;

	private static Texture3D m_WhiteTexture3D;

	private static Texture2D m_BlackTexture;

	private static Texture3D m_BlackTexture3D;

	private static Texture2D m_TransparentTexture;

	private static Texture3D m_TransparentTexture3D;

	private static Dictionary<int, Texture2D> m_LutStrips;

	private static PostProcessResources s_Resources;

	private static Mesh s_FullscreenTriangle;

	private static Material s_CopyStdMaterial;

	private static Material s_CopyStdFromDoubleWideMaterial;

	private static Material s_CopyMaterial;

	private static Material s_CopyFromTexArrayMaterial;

	private static PropertySheet s_CopySheet;

	private static PropertySheet s_CopyFromTexArraySheet;

	private static IEnumerable<Type> m_AssemblyTypes;

	public static Texture2D whiteTexture
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static Texture3D whiteTexture3D
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Texture2D blackTexture
	{
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "set_name")]
		get
		{
			return null;
		}
	}

	public static Texture3D blackTexture3D
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public static Texture2D transparentTexture
	{
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Texture3D transparentTexture3D
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Mesh fullscreenTriangle
	{
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CallsUnknownMethods(Count = 16)]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
		[Calls(Type = typeof(Mesh), Member = "SetVertices")]
		[Calls(Type = typeof(Mesh), Member = "SetIndices")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Mesh), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
	}

	public static Material copyStdMaterial
	{
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "set_name")]
		get
		{
			return null;
		}
	}

	public static Material copyStdFromDoubleWideMaterial
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Material copyMaterial
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public static Material copyFromTexArrayMaterial
	{
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static PropertySheet copySheet
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial")]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static PropertySheet copyFromTexArraySheet
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArrayMaterial")]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public static bool scriptableRenderPipelineActive
	{
		[CallerCount(Count = 15)]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDepthNormals")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDeferredShading")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
		[CalledBy(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
		get
		{
			return default(bool);
		}
	}

	public static bool supportsDeferredShading
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public static bool supportsDepthNormals
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public static bool isSinglePassStereoEnabled
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
		[CalledBy(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public static bool isVREnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public static bool isAndroidOpenGL
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
		[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
		get
		{
			return default(bool);
		}
	}

	public static RenderTextureFormat defaultHDRRenderTextureFormat
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(RenderTextureFormat);
		}
	}

	public static bool isLinearColorSpace
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	public static Texture2D GetLutStrip(int size)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	internal static bool isValidResources()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal static void UpdateResources(PostProcessResources resources)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
	{
	}

	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "CopyTexture")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UnsharpMaskRenderer), Member = "Render")]
	[CalledBy(Type = typeof(UnsharpMaskRenderer), Member = "Render")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Rect? viewport = null)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallerCount(Count = 90)]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Rect? viewport = null)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "SetRenderTargetWithLoadStoreAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "SetRenderTargetWithLoadStoreAction")]
	[CallerCount(Count = 0)]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ScalableAO), Member = "CompositeAmbientOnly")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "CompositeAmbientOnly")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CallsUnknownMethods(Count = 3)]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0)
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, MaterialPropertyBlock properties, int pass, bool clear = false)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[CallerCount(Count = 0)]
	public static bool isFloatingPointFormat(RenderTextureFormat format)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public static void Destroy(Object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsResolvedDepthAvailable(Camera camera)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume")]
	[CallsUnknownMethods(Count = 3)]
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "DestroyProfile")]
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPostProcessingActive(PostProcessLayer layer)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(_003CGetAllSceneObjects_003Ed__82<>))]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CreateIfNull<T>(ref T obj) where T : class, new()
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static float Exp2(float x)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CallsUnknownMethods(Count = 8)]
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "Ortho")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	[CallsUnknownMethods(Count = 3)]
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
	{
		return default(Matrix4x4);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallsUnknownMethods(Count = 13)]
	public static IEnumerable<Type> GetAllAssemblyTypes()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static T GetAttribute<T>(this Type type) where T : Attribute
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}
}
