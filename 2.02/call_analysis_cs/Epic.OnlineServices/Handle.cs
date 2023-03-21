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
		[CallerCount(Count = 59)]
		get
		{
			return (IntPtr)0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Handle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Handle(IntPtr innerHandle)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Handle), Member = "op_Equality")]
	[CalledBy(Type = typeof(Handle), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CalledBy(Type = typeof(Helper), Member = "TryConvert")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Equals(Handle other)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Handle), Member = "Equals")]
	public static bool operator ==(Handle lhs, Handle rhs)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Handle), Member = "Equals")]
	public static bool operator !=(Handle lhs, Handle rhs)
	{
		return false;
	}
}
