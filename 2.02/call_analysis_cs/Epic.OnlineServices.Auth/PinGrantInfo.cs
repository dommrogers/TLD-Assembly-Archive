using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

public class PinGrantInfo : ISettable
{
	private string _003CUserCode_003Ek__BackingField;

	private string _003CVerificationURI_003Ek__BackingField;

	private int _003CExpiresIn_003Ek__BackingField;

	private string _003CVerificationURIComplete_003Ek__BackingField;

	public string UserCode
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string VerificationURI
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public int ExpiresIn
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string VerificationURIComplete
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(PinGrantInfo), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "get_UserCode")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "get_VerificationURI")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "get_VerificationURIComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(PinGrantInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PinGrantInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PinGrantInfo()
	{
	}
}
