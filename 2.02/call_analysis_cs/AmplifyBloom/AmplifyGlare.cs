using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

[Serializable]
public sealed class AmplifyGlare : IAmplifyItem
{
	public const int MaxLineSamples = 8;

	public const int MaxTotalSamples = 16;

	public const int MaxStarLines = 4;

	public const int MaxPasses = 4;

	public const int MaxCustomGlare = 32;

	private GlareDefData[] m_customGlareDef;

	private int m_customGlareDefIdx;

	private int m_customGlareDefAmount;

	private bool m_applyGlare;

	private Color _overallTint;

	private Gradient m_cromaticAberrationGrad;

	private int m_glareMaxPassCount;

	private StarDefData[] m_starDefArr;

	private GlareDefData[] m_glareDefArr;

	private Matrix4x4[] m_weigthsMat;

	private Matrix4x4[] m_offsetsMat;

	private Color m_whiteReference;

	private float m_aTanFoV;

	private AmplifyGlareCache m_amplifyGlareCache;

	private int m_currentWidth;

	private int m_currentHeight;

	private GlareLibType m_currentGlareType;

	private int m_currentGlareIdx;

	private float m_perPassDisplacement;

	private float m_intensity;

	private float m_overallStreakScale;

	private bool m_isDirty;

	private RenderTexture[] _rtBuffer;

	public GlareLibType CurrentGlare
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(GlareLibType);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int GlareMaxPassCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float PerPassDisplacement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float Intensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Color OverallTint
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool ApplyLensGlare
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Gradient CromaticColorGradient
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float OverallStreakScale
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public GlareDefData[] CustomGlareDef
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public int CustomGlareDefIdx
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int CustomGlareDefAmount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(GlareDefData), Member = ".ctor")]
		[CallsUnknownMethods(Count = 16)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Gradient), Member = "SetKeys")]
	[Calls(Type = typeof(AmplifyGlareCache), Member = ".ctor")]
	[Calls(Type = typeof(StarDefData), Member = ".ctor")]
	[Calls(Type = typeof(StarDefData), Member = ".ctor")]
	[Calls(Type = typeof(StarDefData), Member = ".ctor")]
	[Calls(Type = typeof(StarDefData), Member = ".ctor")]
	[Calls(Type = typeof(StarDefData), Member = ".ctor")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = ".ctor")]
	[CallsUnknownMethods(Count = 195)]
	public AmplifyGlare()
	{
	}

	[Calls(Type = typeof(AmplifyGlareCache), Member = "Destroy")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnDestroy")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void Destroy()
	{
	}

	[CallerCount(Count = 0)]
	public void SetDirty()
	{
	}

	[CallsUnknownMethods(Count = 58)]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderImage")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyGlare), Member = "UpdateMatrixesForPass")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	public void OnRenderFromCache(RenderTexture source, RenderTexture dest, Material material, float glareIntensity, float cameraRotation)
	{
	}

	[Calls(Type = typeof(Material), Member = "SetMatrix")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderImage")]
	[CallsUnknownMethods(Count = 42)]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderFromCache")]
	[Calls(Type = typeof(Material), Member = "SetMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	public void UpdateMatrixesForPass(Material material, Vector4[] offsets, Vector4[] weights, float glareIntensity, float rotation)
	{
	}

	[Calls(Type = typeof(Vector4), Member = "get_one")]
	[CallsUnknownMethods(Count = 220)]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Gradient), Member = "Evaluate")]
	[Calls(Type = typeof(AmplifyGlare), Member = "OnRenderFromCache")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(AmplifyGlare), Member = "UpdateMatrixesForPass")]
	public void OnRenderImage(Material material, RenderTexture source, RenderTexture dest, float cameraRot)
	{
	}
}
