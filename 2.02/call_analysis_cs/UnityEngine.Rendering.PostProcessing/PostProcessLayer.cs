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
		[CallerCount(Count = 2)]
		public SerializedBundleRef()
		{
		}
	}

	public class VolumeInfo
	{
		public PostProcessVolume m_Volume;

		public float m_Weight;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public VolumeInfo()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public PostProcessEvent evt;

		public List<PostProcessBundle> effects;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass55_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal bool _003CUpdateBundleSortList_003Eb__0(KeyValuePair<Type, PostProcessBundle> kvp)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 17)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal bool _003CUpdateBundleSortList_003Eb__2(SerializedBundleRef x)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_1
	{
		public string searchStr;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass55_1()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass55_2()
		{
		}

		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass55_3()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 7)]
		private set
		{
		}
	}

	public DepthTextureMode cameraDepthFlags
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnEnable")]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(TargetPool), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheetFactory), Member = ".ctor")]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "AddCommandBuffer")]
	private void InitLegacy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 4)]
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[ImageEffectUsesCommandBuffer]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void Init(PostProcessResources resources)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessBundle), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateBundleSortList")]
	[CallsUnknownMethods(Count = 31)]
	public void InitBundles()
	{
	}

	[CallsUnknownMethods(Count = 77)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Release")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "OnDisable")]
	[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
	[Calls(Type = typeof(TextureLerper), Member = "Clear")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Camera), Member = "RemoveCommandBuffer")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "Release")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Reset()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PostProcessLayer), Member = "InitLegacy")]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void OnPreCull()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
	{
	}

	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "DynamicResolutionAllowsFinalBlitToCameraTarget")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Display), Member = "get_main")]
	[Calls(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 51)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(Fog), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "Reset")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "set_camera")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "Get")]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RequiresInitialBlit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BuiltinBlit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "Get")]
	private void BuildCommandBuffers()
	{
	}

	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Camera), Member = "ResetStereoProjectionMatrices")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[Calls(Type = typeof(Camera), Member = "ResetProjectionMatrix")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnPostRender()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[CallsUnknownMethods(Count = 1)]
	public PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReplaceData")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	public PostProcessBundle GetBundle(Type settingsType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public T GetSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallsUnknownMethods(Count = 10)]
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[CallerCount(Count = 2)]
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(Fog), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[CallsUnknownMethods(Count = 14)]
	private void SetLegacyCameraFlags(PostProcessRenderContext context)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 9)]
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "UpdateResources")]
	private void SetupContext(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	public void RenderOpaqueOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	[CallsUnknownMethods(Count = 3)]
	public VolumeInfo GetPreviousVolumeInfo(PostProcessVolume volume)
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetPreviousVolumeInfo")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool HaveGlobalVolumesChanged(List<PostProcessVolume> volumes)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 3)]
	public bool AreAllVolumesGlobal(List<PostProcessVolume> volumes)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 13)]
	public void UpdateGlobalVolumeInfoList(List<PostProcessVolume> volumes)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(Camera), Member = "get_stereoActiveEye")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "EndFrame")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "EndFrame")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(PostProcessLayer), Member = "HasActiveEffects")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(PostProcessLayer), Member = "SetupContext")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "BeginFrame")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdFromDoubleWideMaterial")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copyStdFromDoubleWideMaterial")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleFromTexArray")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	public void Render(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 6)]
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderOpaqueOnly")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
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

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void ApplyDefaultFlip(MaterialPropertyBlock properties)
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip")]
	[Calls(Type = typeof(Dithering), Member = "Render")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(LogHistogram), Member = "Generate")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyDefaultFlip")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_whiteTexture")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToTexArray")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangleToDoubleWide")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PostProcessLayer), Member = "ApplyFlip")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "IsSupported")]
	[Calls(Type = typeof(Dithering), Member = "Render")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(SubpixelMorphologicalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[DeduplicatedMethod]
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
	{
		return default(int);
	}

	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 26)]
	public PostProcessLayer()
	{
	}
}
