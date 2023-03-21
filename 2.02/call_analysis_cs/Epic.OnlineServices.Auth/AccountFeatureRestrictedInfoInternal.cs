using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct AccountFeatureRestrictedInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_VerificationURI;

	public string VerificationURI
	{
		[CalledBy(Type = typeof(AccountFeatureRestrictedInfo), Member = "Set")]
		[CalledBy(Type = typeof(AccountFeatureRestrictedInfo), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "set_VerificationURI")]
	public void Set(AccountFeatureRestrictedInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "set_VerificationURI")]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
