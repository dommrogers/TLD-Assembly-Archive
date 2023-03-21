using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

public abstract class Handle : IEquatable<Handle>
{
	private IntPtr _003CInnerHandle_003Ek__BackingField;

	public IntPtr InnerHandle
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return default(IntPtr);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Handle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Handle(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Handle), Member = "op_Inequality")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Handle), Member = "op_Equality")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CalledBy(Type = typeof(Helper), Member = "TryConvert")]
	public bool Equals(Handle other)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Handle), Member = "Equals")]
	public static bool operator ==(Handle lhs, Handle rhs)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Handle), Member = "Equals")]
	[CallerCount(Count = 0)]
	public static bool operator !=(Handle lhs, Handle rhs)
	{
		return default(bool);
	}
}
