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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "set_VerificationURI")]
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
