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
			return default(bool);
		}

		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 59)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(DepthTextureMode);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool haveBundlesBeenInited
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnEnable")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessLayer), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
	[CallsUnknownMethods(Count = 9)]
	private void InitLegacy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnRenderImage")]
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget()
	{
		return default(bool);
	}

	[ImageEffectUsesCommandBuffer]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	public void Init(PostProcessResources resources)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	public void InitBundles()
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(TextureLerper), Member = "Clear")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnDisable")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Release")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Reset()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
	{
	}

	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Display), Member = "get_main")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[Calls(Type = typeof(RenderTexture), Member = "get_colorBuffer")]
	[Calls(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "Reset")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "set_camera")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
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
	[Calls(Type = typeof(Fog), Member = "Render")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "Get")]
	private void BuildCommandBuffers()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "ResetStereoProjectionMatrices")]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallsUnknownMethods(Count = 4)]
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[CallsDeduplicatedMethods(Count = 4)]
	private void SetLegacyCameraFlags(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void ResetHistory()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 9)]
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "UpdateResources")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
	private void SetupContext(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[Calls(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CallsUnknownMethods(Count = 1)]
	public void RenderOpaqueOnly(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	public VolumeInfo GetPreviousVolumeInfo(PostProcessVolume volume)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetPreviousVolumeInfo")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 4)]
	public bool HaveGlobalVolumesChanged(List<PostProcessVolume> volumes)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 4)]
	public bool AreAllVolumesGlobal(List<PostProcessVolume> volumes)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void UpdateGlobalVolumeInfoList(List<PostProcessVolume> volumes)
	{
	}

	[Calls(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "EndFrame")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "EndFrame")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdFromDoubleWideMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdFromDoubleWideMaterial")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	public void Render(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void ApplyDefaultFlip(MaterialPropertyBlock properties)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip")]
	[Calls(Type = typeof(Dithering), Member = "Render")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyDefaultFlip")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_whiteTexture")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LogHistogram), Member = "Generate")]
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
	{
		return default(int);
	}

	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(Dithering), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public PostProcessLayer()
	{
	}
}
