using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Platform;

public class Options
{
	private IntPtr _003CReserved_003Ek__BackingField;

	private string _003CProductId_003Ek__BackingField;

	private string _003CSandboxId_003Ek__BackingField;

	private ClientCredentials _003CClientCredentials_003Ek__BackingField;

	private bool _003CIsServer_003Ek__BackingField;

	private string _003CEncryptionKey_003Ek__BackingField;

	private string _003COverrideCountryCode_003Ek__BackingField;

	private string _003COverrideLocaleCode_003Ek__BackingField;

	private string _003CDeploymentId_003Ek__BackingField;

	private PlatformFlags _003CFlags_003Ek__BackingField;

	private string _003CCacheDirectory_003Ek__BackingField;

	private uint _003CTickBudgetInMilliseconds_003Ek__BackingField;

	public IntPtr Reserved
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
		set
		{
		}
	}

	public string ProductId
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

	public string SandboxId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	public ClientCredentials ClientCredentials
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

	public bool IsServer
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string EncryptionKey
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public string OverrideCountryCode
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public string OverrideLocaleCode
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	public string DeploymentId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public PlatformFlags Flags
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return default(PlatformFlags);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string CacheDirectory
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 37)]
		set
		{
		}
	}

	public uint TickBudgetInMilliseconds
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Options()
	{
	}
}
