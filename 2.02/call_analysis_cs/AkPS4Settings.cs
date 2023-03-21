using System;
using Cpp2ILInjected.CallAnalysis;

public class AkPS4Settings : AkWwiseInitializationSettings.PlatformSettings
{
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings
	{
		public uint ACPBatchBufferSize;

		public bool UseHardwareCodecLowLatencyMode;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}

		[CallerCount(Count = 0)]
		public PlatformAdvancedSettings()
		{
		}
	}

	public AkCommonUserSettings UserSettings;

	public PlatformAdvancedSettings AdvancedSettings;

	public AkCommonCommSettings CommsSettings;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCommonUserSettings), Member = ".ctor")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "IgnorePropertyValue")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "SetUseGlobalPropertyValue")]
	[CallsUnknownMethods(Count = 15)]
	public AkPS4Settings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 15)]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	protected override AkCommonAdvancedSettings GetAdvancedSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override AkCommonCommSettings GetCommsSettings()
	{
		return null;
	}
}
