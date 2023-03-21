using System.Collections.Generic;
using System.Globalization;
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
		[CalledBy(Type = typeof(SnowImprint), Member = "ToString")]
		[CalledBy(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
		[CalledBy(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
		[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
		[CalledBy(Type = typeof(SnowPatchManager), Member = "AddImprint")]
		[CallerCount(Count = 7)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
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
			return 0f;
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
			return 0f;
		}
		[CalledBy(Type = typeof(SnowImprint), Member = ".ctor")]
		[CalledBy(Type = typeof(FootstepGroup), Member = "AdjustSnowDepthRecords")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float Angle
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(SnowImprint), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mathf), Member = "Repeat")]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0;
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
			return false;
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
			return false;
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
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowImprint), Member = "FloatToBytes")]
	[Calls(Type = typeof(SnowImprint), Member = "set_Angle")]
	[Calls(Type = typeof(SnowImprint), Member = "set_InitialSnowDepth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public SnowImprint(SnowImprintType type, Vector3 pos, Vector3 normal, float yRotation, float depth, bool flip, int variant)
	{
	}

	[CalledBy(Type = typeof(FootstepTrail), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SnowImprint(List<uint> serializedList, ref int index)
	{
	}

	[CallerCount(Count = 0)]
	private float FloatFromBytes(byte b0, byte b1, byte b2)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(SnowImprint), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowImprint), Member = "set_Position")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void FloatToBytes(float f, out byte b0, out byte b1, out byte b2)
	{
		b0 = default(byte);
		b1 = default(byte);
		b2 = default(byte);
	}

	[CalledBy(Type = typeof(FootstepGroup), Member = "SerializeFootsteps")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	public void AddForSerialize(List<uint> list)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 33)]
	public override string ToString()
	{
		return null;
	}
}
