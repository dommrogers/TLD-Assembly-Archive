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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkCommonUserSettings), Member = ".ctor")]
	[Calls(Type = typeof(AkCommonCommSettings), Member = ".ctor")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "IgnorePropertyValue")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "SetUseGlobalPropertyValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	public AkXBoxOneSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 17)]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
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
