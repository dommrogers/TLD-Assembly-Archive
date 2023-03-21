using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkBasePlatformSettings : ScriptableObject
{
	public virtual AkInitializationSettings AkInitializationSettings
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkInitializationSettings")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkSpatialAudioInitSettings")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	public virtual AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkCallbackManager.InitializationSettings), Member = ".ctor")]
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
			return default(bool);
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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_AkCommunicationSettings")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AkBasePlatformSettings()
	{
	}
}
