using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

public class AccountFeatureRestrictedInfo : ISettable
{
	private string _003CVerificationURI_003Ek__BackingField;

	public string VerificationURI
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "get_VerificationURI")]
	[CallsUnknownMethods(Count = 1)]
	internal void Set(AccountFeatureRestrictedInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AccountFeatureRestrictedInfoInternal), Member = "get_VerificationURI")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AccountFeatureRestrictedInfo()
	{
	}
}
