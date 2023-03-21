using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public struct SnowImprint
{
	private byte m_P0;

	private byte m_P1;

	private byte m_P2;

	private byte m_P3;

	private byte m_P4;

	private byte m_P5;

	private byte m_P6;

	private byte m_P7;

	private byte m_P8;

	private sbyte m_N0D;

	private sbyte m_N1D;

	private sbyte m_N2D;

	private uint m_MiscInfo;

	public const int SERIALIZED_NUM_UINTS = 4;

	public Vector3 Position
	{
		[CalledBy(Type = typeof(SnowPatchManager), Member = "AddImprint")]
		[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
		[CalledBy(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
		[CalledBy(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
		[CalledBy(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
		[CalledBy(Type = typeof(SnowImprint), Member = "ToString")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SnowImprint), Member = "FloatToBytes")]
		[Calls(Type = typeof(SnowImprint), Member = "FloatToBytes")]
		[Calls(Type = typeof(SnowImprint), Member = "FloatToBytes")]
		set
		{
		}
	}

	public Vector3 Normal
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float Depth
	{
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

	public float InitialSnowDepth
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public float Angle
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(SnowImprint), Member = ".ctor")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public SnowImprintType Type
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(SnowImprintType);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int VariantIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool Flip
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool HasHeightMap
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool HasBumpDecal
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(SnowImprint), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SnowImprint), Member = "FloatToBytes")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(SnowImprint), Member = "FloatToBytes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowImprint), Member = "FloatToBytes")]
	public SnowImprint(SnowImprintType type, Vector3 pos, Vector3 normal, float yRotation, float depth, bool flip, int variant)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public SnowImprint(List<uint> serializedList, ref int index)
	{
	}

	[CallerCount(Count = 0)]
	private float FloatFromBytes(byte b0, byte b1, byte b2)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowImprint), Member = "set_Position")]
	[CalledBy(Type = typeof(SnowImprint), Member = "set_Position")]
	[CalledBy(Type = typeof(SnowImprint), Member = "set_Position")]
	[CalledBy(Type = typeof(SnowImprint), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowImprint), Member = ".ctor")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SnowImprint), Member = ".ctor")]
	private void FloatToBytes(float f, out byte b0, out byte b1, out byte b2)
	{
		System.Runtime.CompilerServices.Unsafe.As<byte, @null>(ref b0) = null;
		System.Runtime.CompilerServices.Unsafe.As<byte, @null>(ref b1) = null;
		System.Runtime.CompilerServices.Unsafe.As<byte, @null>(ref b2) = null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void AddForSerialize(List<uint> list)
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 33)]
	public override string ToString()
	{
		return null;
	}
}
