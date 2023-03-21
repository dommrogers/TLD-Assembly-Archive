using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AkCommonPlatformSettings : AkBasePlatformSettings
{
	public override AkInitializationSettings AkInitializationSettings
	{
		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_unityPlatformSpecificSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_platformSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_initSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_deviceSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_unityPlatformSpecificSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_musicSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_platformSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_streamMgrSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_deviceSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_memSettings")]
		[Calls(Type = typeof(AkBasePlatformSettings), Member = "get_AkInitializationSettings")]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_initSettings")]
		get
		{
			return null;
		}
	}

	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(AkBasePlatformSettings), Member = "get_AkSpatialAudioInitSettings")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public override AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings
	{
		[Calls(Type = typeof(AkCallbackManager.InitializationSettings), Member = ".ctor")]
		[CallsUnknownMethods(Count = 9)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public override string InitialLanguage
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public override bool RenderDuringFocusLoss
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public override string SoundbankPath
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public override AkCommunicationSettings AkCommunicationSettings
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(AkBasePlatformSettings), Member = "get_AkCommunicationSettings")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract AkCommonUserSettings GetUserSettings();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract AkCommonCommSettings GetCommsSettings();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected AkCommonPlatformSettings()
	{
	}
}
