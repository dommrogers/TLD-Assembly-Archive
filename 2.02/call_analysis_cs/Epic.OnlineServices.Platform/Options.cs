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
		[CallerCount(Count = 52)]
		get
		{
			return default(IntPtr);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string ProductId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
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

	public string SandboxId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public ClientCredentials ClientCredentials
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string EncryptionKey
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string OverrideCountryCode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
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
		[CallerCount(Count = 17)]
		set
		{
		}
	}

	public string DeploymentId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public PlatformFlags Flags
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
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
		[CallerCount(Count = 20)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		set
		{
		}
	}

	public uint TickBudgetInMilliseconds
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Options()
	{
	}
}
