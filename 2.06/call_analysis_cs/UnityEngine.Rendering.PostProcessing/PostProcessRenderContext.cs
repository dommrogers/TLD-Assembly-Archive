using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessRenderContext
{
	public enum StereoRenderingMode
	{
		MultiPass,
		SinglePass,
		SinglePassInstanced,
		SinglePassMultiview
	}

	private Camera m_Camera;

	private CommandBuffer _003Ccommand_003Ek__BackingField;

	private RenderTargetIdentifier _003Csource_003Ek__BackingField;

	private RenderTargetIdentifier _003Cdestination_003Ek__BackingField;

	private RenderTextureFormat _003CsourceFormat_003Ek__BackingField;

	private bool _003Cflip_003Ek__BackingField;

	private PostProcessResources _003Cresources_003Ek__BackingField;

	private PropertySheetFactory _003CpropertySheets_003Ek__BackingField;

	private Dictionary<string, object> _003CuserData_003Ek__BackingField;

	private PostProcessDebugLayer _003CdebugLayer_003Ek__BackingField;

	private int _003Cwidth_003Ek__BackingField;

	private int _003Cheight_003Ek__BackingField;

	private bool _003CstereoActive_003Ek__BackingField;

	private int _003CxrActiveEye_003Ek__BackingField;

	private int _003CnumberOfEyes_003Ek__BackingField;

	private StereoRenderingMode _003CstereoRenderingMode_003Ek__BackingField;

	private int _003CscreenWidth_003Ek__BackingField;

	private int _003CscreenHeight_003Ek__BackingField;

	private bool _003CisSceneView_003Ek__BackingField;

	private PostProcessLayer.Antialiasing _003Cantialiasing_003Ek__BackingField;

	private TemporalAntialiasing _003CtemporalAntialiasing_003Ek__BackingField;

	internal PropertySheet uberSheet;

	internal Texture autoExposureTexture;

	internal LogHistogram logHistogram;

	internal Texture logLut;

	internal AutoExposure autoExposure;

	internal int bloomBufferNameID;

	internal bool physicalCamera;

	private RenderTextureDescriptor m_sourceDescriptor;

	public Camera camera
	{
		[CallerCount(Count = 98)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 7)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CallsUnknownMethods(Count = 8)]
		set
		{
		}
	}

	public CommandBuffer command
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		[CompilerGenerated]
		set
		{
		}
	}

	public RenderTargetIdentifier source
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(RenderTargetIdentifier);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public RenderTargetIdentifier destination
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(RenderTargetIdentifier);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public RenderTextureFormat sourceFormat
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(RenderTextureFormat);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool flip
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public PostProcessResources resources
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal set
		{
		}
	}

	public PropertySheetFactory propertySheets
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		internal set
		{
		}
	}

	public Dictionary<string, object> userData
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private set
		{
		}
	}

	public PostProcessDebugLayer debugLayer
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 49)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		internal set
		{
		}
	}

	public int width
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public int height
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool stereoActive
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

	public int xrActiveEye
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public int numberOfEyes
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public StereoRenderingMode stereoRenderingMode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(StereoRenderingMode);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public int screenWidth
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public int screenHeight
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool isSceneView
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		internal set
		{
		}
	}

	public PostProcessLayer.Antialiasing antialiasing
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(PostProcessLayer.Antialiasing);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal set
		{
		}
	}

	public TemporalAntialiasing temporalAntialiasing
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 6)]
	public void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTemporalAntialiasingActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsDebugOverlayEnabled(DebugOverlay overlay)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[CallsUnknownMethods(Count = 1)]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	public RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
	{
		return default(RenderTextureDescriptor);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
	[CalledBy(Type = typeof(SuffocationScreenEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(ScalableAO), Member = "DoLazyInitialization")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "CheckHistory")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "CheckHistory")]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PostProcessRenderContext()
	{
	}
}
