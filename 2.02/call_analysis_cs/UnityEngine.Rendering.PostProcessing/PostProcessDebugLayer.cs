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
		[CallerCount(Count = 41)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 11)]
	internal void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "DestroyDebugOverlayTarget")]
	internal void OnDisable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "OnDisable")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "EndFrame")]
	private void DestroyDebugOverlayTarget()
	{
	}

	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PostProcessDebug), Member = "UpdateStates")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "PushDebugOverlay")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 7)]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	[CallerCount(Count = 0)]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(CommandBuffer), Member = "Blit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(Monitor), Member = "IsRequestedAndSupported")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	internal void RenderMonitors(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PropertySheet), Member = "ClearKeywords")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	internal void RenderSpecialOverlays(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "DestroyDebugOverlayTarget")]
	internal void EndFrame()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PostProcessDebugLayer()
	{
	}
}
