using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class TemporalAntialiasing
{
	private enum Pass
	{
		SolverDilate,
		SolverNoDilate
	}

	public float jitterSpread;

	public float sharpness;

	public float stationaryBlending;

	public float motionBlending;

	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc;

	private Vector2 _003Cjitter_003Ek__BackingField;

	private readonly RenderTargetIdentifier[] m_Mrt;

	private bool m_ResetHistory;

	private const int k_SampleCount = 8;

	private int _003CsampleIndex_003Ek__BackingField;

	private const int k_NumEyes = 2;

	private const int k_NumHistoryTextures = 2;

	private readonly RenderTexture[][] m_HistoryTextures;

	private readonly int[] m_HistoryPingPong;

	public Vector2 jitter
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public int sampleIndex
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "IsTemporalAntialiasingActive")]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	public bool IsSupported()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal void ResetHistory()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	private Vector2 GenerateRandomOffset()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetJitteredOrthographicProjectionMatrix")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetJitteredPerspectiveProjectionMatrix")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateRandomOffset")]
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera)
	{
		return default(Matrix4x4);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 5)]
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GenerateJitteredProjectionMatrixFromOriginal")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateRandomOffset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateHistoryName")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateHistoryName")]
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void Release()
	{
	}

	[CallerCount(Count = 0)]
	public TemporalAntialiasing()
	{
	}
}
