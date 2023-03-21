using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class PostProcessDebugLayer
{
	[Serializable]
	public class OverlaySettings
	{
		public bool linearDepth;

		public float motionColorIntensity;

		public int motionGridSize;

		public ColorBlindnessType colorBlindnessType;

		public float colorBlindnessStrength;

		[CallerCount(Count = 0)]
		public OverlaySettings()
		{
		}
	}

	public LightMeterMonitor lightMeter;

	public HistogramMonitor histogram;

	public WaveformMonitor waveform;

	public VectorscopeMonitor vectorscope;

	private Dictionary<MonitorType, Monitor> m_Monitors;

	private int frameWidth;

	private int frameHeight;

	private RenderTexture _003CdebugOverlayTarget_003Ek__BackingField;

	private bool _003CdebugOverlayActive_003Ek__BackingField;

	private DebugOverlay _003CdebugOverlay_003Ek__BackingField;

	public OverlaySettings overlaySettings;

	public RenderTexture debugOverlayTarget
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 46)]
		private set
		{
		}
	}

	public bool debugOverlayActive
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public DebugOverlay debugOverlay
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(DebugOverlay);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CreateIfNull")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	internal void OnEnable()
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "DestroyDebugOverlayTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void OnDisable()
	{
	}

	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "OnDisable")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "EndFrame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DestroyDebugOverlayTarget()
	{
	}

	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RequestMonitorPass(MonitorType monitor)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void RequestDebugOverlay(DebugOverlay mode)
	{
	}

	[CallerCount(Count = 0)]
	internal void SetFrameSize(int width, int height)
	{
	}

	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "PushDebugOverlay")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 18)]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	[CallerCount(Count = 0)]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	internal void RenderMonitors(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "ClearKeywords")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 36)]
	internal void RenderSpecialOverlays(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "DestroyDebugOverlayTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void EndFrame()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PostProcessDebugLayer()
	{
	}
}
