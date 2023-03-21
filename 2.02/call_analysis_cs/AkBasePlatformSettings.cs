using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkBasePlatformSettings : ScriptableObject
{
	public virtual AkInitializationSettings AkInitializationSettings
	{
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings
	{
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkSpatialAudioInitSettings")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	public virtual AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkCallbackManager.InitializationSettings), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public virtual string InitialLanguage
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public virtual bool RenderDuringFocusLoss
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public virtual string SoundbankPath
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public virtual AkCommunicationSettings AkCommunicationSettings
	{
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkCommunicationSettings")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public AkBasePlatformSettings()
	{
	}
}
