using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

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
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
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
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 79)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 4)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public PostProcessResources resources
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		internal set
		{
		}
	}

	public PropertySheetFactory propertySheets
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		internal set
		{
		}
	}

	public Dictionary<string, object> userData
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
		[CallerCount(Count = 2)]
		private set
		{
		}
	}

	public PostProcessDebugLayer debugLayer
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
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

	public bool stereoActive
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public int xrActiveEye
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
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

	public StereoRenderingMode stereoRenderingMode
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(StereoRenderingMode);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public int screenWidth
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set
		{
		}
	}

	public TemporalAntialiasing temporalAntialiasing
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "IsSupported")]
	public bool IsTemporalAntialiasingActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallsUnknownMethods(Count = 2)]
	public RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
	{
		return default(RenderTextureDescriptor);
	}

	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(SuffocationScreenEffectRenderer), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[CalledBy(Type = typeof(BloomRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(ScalableAO), Member = "DoLazyInitialization")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "CheckHistory")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "CheckHistory")]
	[Calls(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "Render")]
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PostProcessRenderContext()
	{
	}
}
