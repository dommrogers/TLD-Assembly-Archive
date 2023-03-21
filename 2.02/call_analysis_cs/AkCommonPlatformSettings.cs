using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AkCommonPlatformSettings : AkBasePlatformSettings
{
	public override AkInitializationSettings AkInitializationSettings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkBasePlatformSettings), Member = "get_AkInitializationSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_memSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_deviceSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_streamMgrSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_initSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_platformSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_musicSettings")]
		[Calls(Type = typeof(AkInitializationSettings), Member = "get_unityPlatformSpecificSettings")]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 10)]
		get
		{
			return null;
		}
	}

	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkBasePlatformSettings), Member = "get_AkSpatialAudioInitSettings")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public override AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkCallbackManager.InitializationSettings), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
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
			return false;
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkBasePlatformSettings), Member = "get_AkCommunicationSettings")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected abstract AkCommonUserSettings GetUserSettings();

	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();

	protected abstract AkCommonCommSettings GetCommsSettings();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected AkCommonPlatformSettings()
	{
	}
}
