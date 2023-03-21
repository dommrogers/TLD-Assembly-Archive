using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct SessionSearchSetParameterOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Parameter;

	private ComparisonOp m_ComparisonOp;

	public AttributeData Parameter
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionSearchSetParameterOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionSearchSetParameterOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ComparisonOp ComparisonOp
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(SessionSearchSetParameterOptionsInternal), Member = "set_Parameter")]
	[CallerCount(Count = 0)]
	public void Set(SessionSearchSetParameterOptions other)
	{
	}

	[Calls(Type = typeof(SessionSearchSetParameterOptionsInternal), Member = "set_Parameter")]
	[CalledBy(Type = typeof(SessionSearch), Member = "SetParameter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
