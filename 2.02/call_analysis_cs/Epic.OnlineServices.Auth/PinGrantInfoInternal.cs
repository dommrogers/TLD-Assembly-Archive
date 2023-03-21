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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(PinGrantInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public string VerificationURI
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(PinGrantInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
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
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string VerificationURIComplete
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PinGrantInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(PinGrantInfoInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_UserCode")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_VerificationURI")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "set_VerificationURIComplete")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
