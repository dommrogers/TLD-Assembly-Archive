using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class TransferDeviceIdAccountOptions
{
	private ProductUserId _003CPrimaryLocalUserId_003Ek__BackingField;

	private ProductUserId _003CLocalDeviceUserId_003Ek__BackingField;

	private ProductUserId _003CProductUserIdToPreserve_003Ek__BackingField;

	public ProductUserId PrimaryLocalUserId
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public ProductUserId LocalDeviceUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
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

	public ProductUserId ProductUserIdToPreserve
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TransferDeviceIdAccountOptions()
	{
	}
}
