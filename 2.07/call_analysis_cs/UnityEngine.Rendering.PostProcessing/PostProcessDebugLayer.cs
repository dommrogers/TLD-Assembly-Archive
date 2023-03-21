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
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		[CompilerGenerated]
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
			return default(bool);
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(DebugOverlay);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	internal void OnEnable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "DestroyDebugOverlayTarget")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 3)]
	internal void OnDisable()
	{
	}

	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "EndFrame")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	private void DestroyDebugOverlayTarget()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CallsUnknownMethods(Count = 1)]
	public void RequestMonitorPass(MonitorType monitor)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void RequestDebugOverlay(DebugOverlay mode)
	{
	}

	[CallerCount(Count = 0)]
	internal void SetFrameSize(int width, int height)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "PushDebugOverlay")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 7)]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	[CallerCount(Count = 0)]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	internal void RenderMonitors(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "ClearKeywords")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	internal void RenderSpecialOverlays(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "DestroyDebugOverlayTarget")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void EndFrame()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PostProcessDebugLayer()
	{
	}
}
