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
	private sealed class _003CGetAllSceneObjects_003Ed__82<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : Component
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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
		[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
		[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
		[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 25)]
		private bool MoveNext()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static Texture3D whiteTexture3D
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public static Texture2D blackTexture
	{
		[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
		[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static Texture3D blackTexture3D
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public static Texture2D transparentTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static Texture3D transparentTexture3D
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public static Mesh fullscreenTriangle
	{
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Mesh), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Mesh), Member = "SetVertices")]
		[Calls(Type = typeof(Mesh), Member = "SetIndices")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	public static Material copyStdMaterial
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public static Material copyStdFromDoubleWideMaterial
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public static Material copyMaterial
	{
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public static Material copyFromTexArrayMaterial
	{
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public static PropertySheet copySheet
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial")]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static PropertySheet copyFromTexArraySheet
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArrayMaterial")]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static bool scriptableRenderPipelineActive
	{
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDeferredShading")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDepthNormals")]
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public static bool supportsDeferredShading
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public static bool supportsDepthNormals
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public static bool isSinglePassStereoEnabled
	{
		[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
		[CalledBy(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
		[CalledBy(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public static bool isVREnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return false;
		}
	}

	public static bool isAndroidOpenGL
	{
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return false;
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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Texture2D GetLutStrip(int size)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	internal static bool isValidResources()
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext")]
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
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[CalledBy(Type = typeof(UnsharpMaskRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "CopyTexture")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Rect? viewport = null)
	{
	}

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Rect? viewport = null)
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "SetRenderTargetWithLoadStoreAction")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "CompositeAmbientOnly")]
	[CalledBy(Type = typeof(ScalableAO), Member = "CompositeAmbientOnly")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0)
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, MaterialPropertyBlock properties, int pass, bool clear = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[CallerCount(Count = 0)]
	public static bool isFloatingPointFormat(RenderTextureFormat format)
	{
		return false;
	}

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	public static void Destroy(Object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsResolvedDepthAvailable(Camera camera)
	{
		return false;
	}

	[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "DestroyProfile")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsPostProcessingActive(PostProcessLayer layer)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CGetAllSceneObjects_003Ed__82<>))]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "OnEnable")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Init")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CreateIfNull<T>(ref T obj) where T : class, new()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Exp2(float x)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
	{
		return default(Matrix4x4);
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public static IEnumerable<Type> GetAllAssemblyTypes()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static T GetAttribute<T>(this Type type) where T : Attribute
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Linq.Buffer`1", Member = ".ctor")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}
}
