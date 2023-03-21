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
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string VerificationURI
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
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
			return default(int);
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
		[CallerCount(Count = 20)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "get_UserCode")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "get_VerificationURI")]
	[Calls(Type = typeof(PinGrantInfoInternal), Member = "get_VerificationURIComplete")]
	[CalledBy(Type = typeof(PinGrantInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(PinGrantInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PinGrantInfo), Member = "Set")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PinGrantInfo()
	{
	}
}
