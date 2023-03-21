using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SimpleLightProbePlacer;

[Serializable]
public struct Volume
{
	private Vector3 m_origin;

	private Vector3 m_size;

	public Vector3 Origin
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 Size
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Volume(Vector3 origin, Vector3 size)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Volume), Member = "Equals")]
	public static bool operator ==(Volume left, Volume right)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Volume), Member = "Equals")]
	public static bool operator !=(Volume left, Volume right)
	{
		return false;
	}

	[CalledBy(Type = typeof(Volume), Member = "op_Equality")]
	[CalledBy(Type = typeof(Volume), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Volume), Member = "Equals")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Equals(Volume other)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Volume), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}
}
