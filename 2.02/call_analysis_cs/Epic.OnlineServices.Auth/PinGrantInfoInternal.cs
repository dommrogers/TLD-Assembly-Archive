using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct PinGrantInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserCode;

	private IntPtr m_VerificationURI;

	private int m_ExpiresIn;

	private IntPtr m_VerificationURIComplete;

	public string UserCode
	{
		[CalledBy(Type = typeof(PinGrantInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string VerificationURI
	{
		[CalledBy(Type = typeof(PinGrantInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int ExpiresIn
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string VerificationURIComplete
	{
		[CalledBy(Type = typeof(PinGrantInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_UserCode")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_VerificationURI")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_VerificationURIComplete")]
	public void Set(PinGrantInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_UserCode")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_VerificationURI")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_VerificationURIComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
