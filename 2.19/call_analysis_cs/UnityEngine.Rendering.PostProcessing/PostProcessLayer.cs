using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessLayer : MonoBehaviour
{
	public enum Antialiasing
	{
		None,
		FastApproximateAntialiasing,
		SubpixelMorphologicalAntialiasing,
		TemporalAntialiasing
	}

	[Serializable]
	public sealed class SerializedBundleRef
	{
		public string assemblyQualifiedName;

		public PostProcessBundle bundle;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SerializedBundleRef()
		{
		}
	}

	public class VolumeInfo
	{
		public PostProcessVolume m_Volume;

		public float m_Weight;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public VolumeInfo()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public PostProcessEvent evt;

		public List<PostProcessBundle> effects;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass55_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CUpdateBundleSortList_003Eb__0(KeyValuePair<Type, PostProcessBundle> kvp)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CUpdateBundleSortList_003Eb__2(SerializedBundleRef x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_1
	{
		public string searchStr;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass55_1()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CUpdateBundleSortList_003Eb__3(PostProcessBundle b)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_2
	{
		public string typeName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass55_2()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CUpdateBundleSortList_003Eb__4(SerializedBundleRef b)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_3
	{
		public string typeName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass55_3()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CUpdateBundleSortList_003Eb__5(PostProcessBundle b)
		{
			return false;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle> _003C_003E9__55_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		internal PostProcessBundle _003CUpdateBundleSortList_003Eb__55_1(KeyValuePair<Type, PostProcessBundle> kvp)
		{
			return null;
		}
	}

	public Transform volumeTrigger;

	public LayerMask volumeLayer;

	public bool stopNaNPropagation;

	public bool finalBlitToCameraTarget;

	public Antialiasing antialiasingMode;

	public TemporalAntialiasing temporalAntialiasing;

	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing;

	public FastApproximateAntialiasing fastApproximateAntialiasing;

	public Fog fog;

	private Dithering dithering;

	public PostProcessDebugLayer debugLayer;

	private PostProcessResources m_Resources;

	[NonSerialized]
	private PostProcessResources m_OldResources;

	private bool m_ShowToolkit;

	private bool m_ShowCustomSorter;

	public bool breakBeforeColorGrading;

	public bool enableBuiltins;

	private List<SerializedBundleRef> m_BeforeTransparentBundles;

	private List<SerializedBundleRef> m_BeforeStackBundles;

	private List<SerializedBundleRef> m_AfterStackBundles;

	private Dictionary<PostProcessEvent, List<SerializedBundleRef>> _003CsortedBundles_003Ek__BackingField;

	private DepthTextureMode _003CcameraDepthFlags_003Ek__BackingField;

	private bool _003ChaveBundlesBeenInited_003Ek__BackingField;

	private Dictionary<Type, PostProcessBundle> m_Bundles;

	private PropertySheetFactory m_PropertySheetFactory;

	private CommandBuffer m_LegacyCmdBufferBeforeReflections;

	private CommandBuffer m_LegacyCmdBufferBeforeLighting;

	private CommandBuffer m_LegacyCmdBufferOpaque;

	private CommandBuffer m_LegacyCmdBuffer;

	private Camera m_Camera;

	private PostProcessRenderContext m_CurrentContext;

	private LogHistogram m_LogHistogram;

	private bool m_SettingsUpdateNeeded;

	private bool m_IsRenderingInSceneView;

	private TargetPool m_TargetPool;

	private bool m_NaNKilled;

	private readonly List<PostProcessEffectRenderer> m_ActiveEffects;

	private readonly List<RenderTargetIdentifier> m_Targets;

	private List<VolumeInfo> m_PreviousGlobalVolumeInfoList;

	public Dictionary<PostProcessEvent, List<SerializedBundleRef>> sortedBundles
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 64)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		private set
		{
		}
	}

	public DepthTextureMode cameraDepthFlags
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(DepthTextureMode);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool haveBundlesBeenInited
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "Init")]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnEnable")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void InitLegacy()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget()
	{
		return false;
	}

	[ImageEffectUsesCommandBuffer]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CreateIfNull")]
	public void Init(PostProcessResources resources)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CreateIfNull")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	public void InitBundles()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Func<, >), Member = ".ctor")]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(List<>), Member = "RemoveAll")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 24)]
	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Release")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnDisable")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	private void OnPreCull()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPreRender()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "Reset")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "set_camera")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "Get")]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	[Calls(Type = typeof(Fog), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Display), Member = "get_main")]
	[Calls(Type = typeof(RenderTexture), Member = "get_colorBuffer")]
	[Calls(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 21)]
	private void BuildCommandBuffers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(Camera), Member = "ResetProjectionMatrix")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye")]
	[Calls(Type = typeof(Camera), Member = "ResetStereoProjectionMatrices")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPostRender()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BakeMSVOMap")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "ShouldGenerateLogHistogram")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsUnknownMethods(Count = 1)]
	public PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsUnknownMethods(Count = 1)]
	public PostProcessBundle GetBundle(Type settingsType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public T GetSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallsUnknownMethods(Count = 4)]
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void SetLegacyCameraFlags(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ResetHistory()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "UpdateResources")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetupContext(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CallsUnknownMethods(Count = 1)]
	public void RenderOpaqueOnly(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public VolumeInfo GetPreviousVolumeInfo(PostProcessVolume volume)
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetPreviousVolumeInfo")]
	[CallsUnknownMethods(Count = 3)]
	public bool HaveGlobalVolumesChanged(List<PostProcessVolume> volumes)
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public bool AreAllVolumesGlobal(List<PostProcessVolume> volumes)
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void UpdateGlobalVolumeInfoList(List<PostProcessVolume> volumes)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdFromDoubleWideMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix")]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors")]
	[Calls(Type = typeof(TextureLerper), Member = "EndFrame")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "EndFrame")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public void Render(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
	{
		return 0;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CallerCount(Count = 2)]
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ApplyDefaultFlip(MaterialPropertyBlock properties)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_whiteTexture")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[Calls(Type = typeof(LogHistogram), Member = "Generate")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyDefaultFlip")]
	[Calls(Type = typeof(Dithering), Member = "Render")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 11)]
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
	{
		return 0;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(Dithering), Member = "Render")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public PostProcessLayer()
	{
	}
}
