using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

		[CallsUnknownMethods(Count = 28)]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
		[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
		[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private void _003C_003Em__Finally1()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "set_name")]
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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
		[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		get
		{
			return null;
		}
	}

	public static Texture3D blackTexture3D
	{
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "set_name")]
		get
		{
			return null;
		}
	}

	public static Texture2D transparentTexture
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
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
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
		[Calls(Type = typeof(Mesh), Member = "SetVertices")]
		[Calls(Type = typeof(Mesh), Member = "SetIndices")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Mesh), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		get
		{
			return null;
		}
	}

	public static Material copyStdMaterial
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static Material copyStdFromDoubleWideMaterial
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		get
		{
			return null;
		}
	}

	public static Material copyMaterial
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "set_name")]
		get
		{
			return null;
		}
	}

	public static Material copyFromTexArrayMaterial
	{
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static PropertySheet copyFromTexArraySheet
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArrayMaterial")]
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
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
		[CalledBy(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		get
		{
			return default(bool);
		}
	}

	public static bool supportsDeferredShading
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

	public static bool supportsDepthNormals
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

	public static bool isSinglePassStereoEnabled
	{
		[CalledBy(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
		[CalledBy(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
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
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public static bool isAndroidOpenGL
	{
		[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public static RenderTextureFormat defaultHDRRenderTextureFormat
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static Texture2D GetLutStrip(int size)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	internal static bool isValidResources()
	{
		return default(bool);
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	internal static void UpdateResources(PostProcessResources resources)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallerCount(Count = 0)]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 8)]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "CopyTexture")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(UnsharpMaskRenderer), Member = "Render")]
	[CalledBy(Type = typeof(UnsharpMaskRenderer), Member = "Render")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Rect? viewport = null)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[CallerCount(Count = 85)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Rect? viewport = null)
	{
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CallsUnknownMethods(Count = 2)]
	public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "SetRenderTargetWithLoadStoreAction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "SetRenderTargetWithLoadStoreAction")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "CompositeAmbientOnly")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[CalledBy(Type = typeof(ScalableAO), Member = "CompositeAmbientOnly")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CallsUnknownMethods(Count = 3)]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
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
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	public static void Destroy(Object obj)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static bool IsResolvedDepthAvailable(Camera camera)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume")]
	[CallsUnknownMethods(Count = 3)]
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "DestroyProfile")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsPostProcessingActive(PostProcessLayer layer)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003CGetAllSceneObjects_003Ed__82<>))]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Exp2(float x)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 7)]
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

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	public static IEnumerable<Type> GetAllAssemblyTypes()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 5)]
	public static T GetAttribute<T>(this Type type) where T : Attribute
	{
		return null;
	}

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}
}
