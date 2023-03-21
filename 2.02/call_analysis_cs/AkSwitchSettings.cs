using System;
using Cpp2ILInjected.CallAnalysis;

public class AkSwitchSettings : AkWwiseInitializationSettings.PlatformSettings
{
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings
	{
		public int m_ThreadLEngine_idealCore;

		public uint m_ThreadLEngine_affinityMask;

		public int m_ThreadMonitor_idealCore;

		public uint m_ThreadMonitor_affinityMask;

		public int m_ThreadBankManager_idealCore;

		public uint m_ThreadBankManager_affinityMask;

		public int m_ThreadOpusDecoder_idealCore;

		public uint m_ThreadOpusDecoder_affinityMask;

		public int m_ThreadOutputManager_idealCore;

		public uint m_ThreadOutputManager_affinityMask;

		public int m_ThreadProperties_idealCore;

		public uint m_ThreadProperties_affinityMask;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkCommonAdvancedSettings), Member = "CopyTo")]
		public override void CopyTo(AkDeviceSettings settings)
		{
		}

		[CallerCount(Count = 0)]
		public PlatformAdvancedSettings()
		{
		}
	}

	public PlatformAdvancedSettings AdvancedSettings;

	public AkCommonUserSettings UserSettings;

	public AkCommonCommSettings CommsSettings;

	[DeduplicatedMethod]
	[CallerCount(Count = 15)]
	protected override AkCommonAdvancedSettings GetAdvancedSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override AkCommonCommSettings GetCommsSettings()
	{
		return null;
	}

	[Calls(Type = typeof(AkCommonCommSettings), Member = ".ctor")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "IgnorePropertyValue")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "SetUseGlobalPropertyValue")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "IgnorePropertyValue")]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = "SetUseGlobalPropertyValue")]
	public AkSwitchSettings()
	{
	}
}
