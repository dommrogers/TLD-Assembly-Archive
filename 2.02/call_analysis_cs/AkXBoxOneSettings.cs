using System;
using Cpp2ILInjected.CallAnalysis;

public class AkXBoxOneSettings : AkWwiseInitializationSettings.PlatformSettings
{
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings
	{
		public uint ShapeDefaultPoolSize;

		public ushort MaximumNumberOfXMAVoices;

		public bool UseHardwareCodecLowLatencyMode;

		public uint APUHeapCachedSize;

		public uint APUHeapNonCachedSize;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public override void CopyTo(AkUnityPlatformSpecificSettings settings)
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

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "SetUseGlobalPropertyValue")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "SetUseGlobalPropertyValue")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "SetUseGlobalPropertyValue")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "IgnorePropertyValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkCommonCommSettings), Member = ".ctor")]
	[Calls(Type = typeof(AkCommonUserSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	public AkXBoxOneSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 15)]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
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
