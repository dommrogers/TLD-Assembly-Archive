using System;
using System.Collections.Generic;
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
			return default(bool);
		}

		[CallsUnknownMethods(Count = 11)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		internal bool _003CUpdateBundleSortList_003Eb__2(SerializedBundleRef x)
		{
			return default(bool);
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CUpdateBundleSortList_003Eb__3(PostProcessBundle b)
		{
			return default(bool);
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

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal bool _003CUpdateBundleSortList_003Eb__4(SerializedBundleRef b)
		{
			return default(bool);
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CUpdateBundleSortList_003Eb__5(PostProcessBundle b)
		{
			return default(bool);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle> _003C_003E9__55_1;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 49)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private set
		{
		}
	}

	public DepthTextureMode cameraDepthFlags
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
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
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnEnable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[Calls(Type = typeof(PostProcessLayer), Member = "Init")]
	[Calls(Type = typeof(TargetPool), Member = ".ctor")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	private void InitLegacy()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnRenderImage")]
	[CallsUnknownMethods(Count = 4)]
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[ImageEffectUsesCommandBuffer]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget")]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	public void Init(PostProcessResources resources)
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessBundle), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	public void InitBundles()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[CallsUnknownMethods(Count = 72)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt)
	{
	}

	[Calls(Type = typeof(TextureLerper), Member = "Clear")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnDisable")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Release")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "Release")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	private void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Reset()
	{
	}

	[Calls(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	private void OnPreCull()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 2)]
	private void OnPreRender()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
	{
	}

	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Display), Member = "get_main")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[Calls(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(Fog), Member = "Render")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "Reset")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "set_camera")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "Get")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "Get")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	private void BuildCommandBuffers()
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "ResetStereoProjectionMatrices")]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "ResetProjectionMatrix")]
	private void OnPostRender()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[CallsUnknownMethods(Count = 15)]
	private void SetLegacyCameraFlags(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void ResetHistory()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "UpdateResources")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	private void SetupContext(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	public void RenderOpaqueOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	[CallsUnknownMethods(Count = 3)]
	public VolumeInfo GetPreviousVolumeInfo(PostProcessVolume volume)
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetPreviousVolumeInfo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HaveGlobalVolumesChanged(List<PostProcessVolume> volumes)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 3)]
	public bool AreAllVolumesGlobal(List<PostProcessVolume> volumes)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 14)]
	public void UpdateGlobalVolumeInfoList(List<PostProcessVolume> volumes)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "EndFrame")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "EndFrame")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdFromDoubleWideMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdFromDoubleWideMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	public void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ApplyDefaultFlip(MaterialPropertyBlock properties)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip")]
	[Calls(Type = typeof(Dithering), Member = "Render")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyDefaultFlip")]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_whiteTexture")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LogHistogram), Member = "Generate")]
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
	{
		return default(int);
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(Dithering), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
	{
	}

	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public PostProcessLayer()
	{
	}
}
