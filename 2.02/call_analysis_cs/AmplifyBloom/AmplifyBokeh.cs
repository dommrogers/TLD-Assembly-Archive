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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 6)]
		get
		{
			return false;
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
			return false;
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
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
			return 0f;
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
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
			return 0f;
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
			return 0f;
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
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AmplifyBokeh()
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(AmplifyBokeh), Member = ".ctor")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "set_ApertureShape")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CalculateBokehSamples")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 73)]
	private void CreateBokehOffsets(ApertureShape shape)
	{
	}

	[CalledBy(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Vector4), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private Vector4[] CalculateBokehSamples(int sampleCount, float angle)
	{
		return null;
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 34)]
	public void ApplyBokehFilter(RenderTexture source, Material material)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmplifyBokeh), Member = "CreateBokehOffsets")]
	public void OnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void OnBeforeSerialize()
	{
	}
}
