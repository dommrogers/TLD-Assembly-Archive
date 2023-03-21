using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

[Serializable]
public sealed class AmplifyBokeh : IAmplifyItem, ISerializationCallbackReceiver
{
	private const int PerPassSampleCount = 8;

	private bool m_isActive;

	private bool m_applyOnBloomSource;

	private float m_bokehSampleRadius;

	private Vector4 m_bokehCameraProperties;

	private float m_offsetRotation;

	private ApertureShape m_apertureShape;

	private List<AmplifyBokehData> m_bokehOffsets;

	public ApertureShape ApertureShape
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(ApertureShape);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
		set
		{
		}
	}

	public bool ApplyBokeh
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	public bool ApplyOnBloomSource
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	public float BokehSampleRadius
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public float OffsetRotation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector4 BokehCameraProperties
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float Aperture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public float FocalLength
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float FocalDistance
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float MaxCoCDiameter
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public AmplifyBokeh()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnDestroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	public void Destroy()
	{
	}

	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[CallsUnknownMethods(Count = 73)]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "set_ApertureShape")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = ".ctor")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	private void CreateBokehOffsets(ApertureShape shape)
	{
	}

	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[Calls(Type = typeof(Vector4), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	private Vector4[] CalculateBokehSamples(int sampleCount, float angle)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public void ApplyBokehFilter(RenderTexture source, Material material)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	public void OnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnBeforeSerialize()
	{
	}
}
