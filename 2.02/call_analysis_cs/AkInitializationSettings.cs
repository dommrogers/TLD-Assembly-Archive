using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkInitializationSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkMemSettings memSettings
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public AkStreamMgrSettings streamMgrSettings
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(AkStreamMgrSettings), Member = "getCPtr")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public AkDeviceSettings deviceSettings
	{
		[CallsUnknownMethods(Count = 8)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkDeviceSettings), Member = "getCPtr")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public AkInitSettings initSettings
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(AkInitSettings), Member = "getCPtr")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public AkPlatformInitSettings platformSettings
	{
		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkPlatformInitSettings), Member = "getCPtr")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public AkMusicSettings musicSettings
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkMusicSettings), Member = "getCPtr")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public uint preparePoolSize
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public AkCommunicationSettings communicationSettings
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkCommunicationSettings), Member = "getCPtr")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings
	{
		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkInitializationSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkInitializationSettings obj)
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkInitializationSettings()
	{
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkInitializationSettings()
	{
	}
}
