using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
		[CallsUnknownMethods(Count = 2)]
		public _003CGetAllSceneObjects_003Ed__82(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 32)]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[DeduplicatedMethod]
		[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
		[CallsDeduplicatedMethods(Count = 10)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void _003C_003Em__Finally1()
		{
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
		[CallsUnknownMethods(Count = 10)]
		private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
		{
			return null;
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[DebuggerHidden]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallsUnknownMethods(Count = 10)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Texture3D whiteTexture3D
	{
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[CallsUnknownMethods(Count = 13)]
		get
		{
			return null;
		}
	}

	public static Texture2D blackTexture
	{
		[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallsUnknownMethods(Count = 10)]
		[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "set_name")]
		get
		{
			return null;
		}
	}

	public static Texture3D blackTexture3D
	{
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CallsUnknownMethods(Count = 13)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Texture2D transparentTexture
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallsUnknownMethods(Count = 10)]
		get
		{
			return null;
		}
	}

	public static Texture3D transparentTexture3D
	{
		[CallsUnknownMethods(Count = 13)]
		[Calls(Type = typeof(Texture3D), Member = "Apply")]
		[Calls(Type = typeof(Texture3D), Member = "SetPixels")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture3D), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Mesh fullscreenTriangle
	{
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CallsUnknownMethods(Count = 34)]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
		[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh")]
		[Calls(Type = typeof(Array), Member = "get_Length")]
		[Calls(Type = typeof(Mesh), Member = "SetVertices")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Mesh), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Array), Member = "get_Length")]
		get
		{
			return null;
		}
	}

	public static Material copyStdMaterial
	{
		[CallsUnknownMethods(Count = 11)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Material copyStdFromDoubleWideMaterial
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CallsUnknownMethods(Count = 11)]
		get
		{
			return null;
		}
	}

	public static Material copyMaterial
	{
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
		[CallsUnknownMethods(Count = 11)]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static Material copyFromTexArrayMaterial
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = ".ctor")]
		[Calls(Type = typeof(Object), Member = "set_name")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
		[CallsUnknownMethods(Count = 11)]
		get
		{
			return null;
		}
	}

	public static PropertySheet copySheet
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial")]
		get
		{
			return null;
		}
	}

	public static PropertySheet copyFromTexArraySheet
	{
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArrayMaterial")]
		[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		get
		{
			return null;
		}
	}

	public static bool scriptableRenderPipelineActive
	{
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDeferredShading")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_supportsDepthNormals")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender")]
		get
		{
			return default(bool);
		}
	}

	public static bool supportsDeferredShading
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public static bool supportsDepthNormals
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public static bool isSinglePassStereoEnabled
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
		[CalledBy(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
		[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
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
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported")]
		[CalledBy(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
		[CallsUnknownMethods(Count = 2)]
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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[CalledBy(Type = typeof(TextureParameter), Member = "Interp")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	public static Texture2D GetLutStrip(int size)
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static bool isValidResources()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(Glitch2Renderer), Member = "Render")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "CopyTexture")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(UnsharpMaskRenderer), Member = "Render")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CalledBy(Type = typeof(UnsharpMaskRenderer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyMaterial")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Rect? viewport = null)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Rect? viewport = null)
	{
	}

	[CallerCount(Count = 87)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallerCount(Count = 2)]
	public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CallsUnknownMethods(Count = 3)]
	public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "SetRenderTargetWithLoadStoreAction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "SetRenderTargetWithLoadStoreAction")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[CalledBy(Type = typeof(ScalableAO), Member = "CompositeAmbientOnly")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "CompositeAmbientOnly")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallerCount(Count = 2)]
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
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_fullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, MaterialPropertyBlock properties, int pass, bool clear = false)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[CallerCount(Count = 0)]
	public static bool isFloatingPointFormat(RenderTextureFormat format)
	{
		return default(bool);
	}

	[CallerCount(Count = 37)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "DestroyProfile")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPostProcessingActive(PostProcessLayer layer)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
	{
		return default(bool);
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
	{
		return null;
	}

	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CreateIfNull<T>(ref T obj) where T : class, new()
	{
	}

	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRBlendPipeline2D")]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[CalledBy(Type = typeof(HableCurve), Member = "Init")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderExternalPipeline3D")]
	public static float Exp2(float x)
	{
		return default(float);
	}

	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Matrix4x4), Member = "Ortho")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CallsUnknownMethods(Count = 7)]
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[Calls(Type = typeof(Matrix4x4), Member = "Frustum")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "DecomposeProjection")]
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
	{
		return default(Matrix4x4);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallsUnknownMethods(Count = 16)]
	public static IEnumerable<Type> GetAllAssemblyTypes()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 7)]
	public static T GetAttribute<T>(this Type type) where T : Attribute
	{
		return null;
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[DeduplicatedMethod]
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 28)]
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}
}
