using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AkCommonAdvancedSettings : AkSettingsValidationHandler
{
	[Serializable]
	public class SpatialAudioSettings
	{
		public float m_DiffractionShadowAttenuationFactor;

		public float m_DiffractionShadowDegrees;

		[CallerCount(Count = 0)]
		public SpatialAudioSettings()
		{
		}
	}

	public uint m_IOMemorySize;

	public float m_TargetAutoStreamBufferLengthMs;

	public bool m_UseStreamCache;

	public uint m_MaximumPinnedBytesInCache;

	public int m_PrepareEventMemoryPoolID;

	public bool m_EnableGameSyncPreparation;

	public uint m_ContinuousPlaybackLookAhead;

	public uint m_MonitorPoolSize;

	public uint m_MonitorQueuePoolSize;

	public uint m_MaximumHardwareTimeoutMs;

	public SpatialAudioSettings m_SpatialAudioSettings;

	public bool m_RenderDuringFocusLoss;

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AkSwitchSettings.PlatformAdvancedSettings), Member = "CopyTo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	public virtual void CopyTo(AkDeviceSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 7)]
	public virtual void CopyTo(AkInitSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void CopyTo(AkPlatformInitSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public virtual void CopyTo(AkSpatialAudioInitSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void Validate()
	{
	}

	[CallerCount(Count = 0)]
	public AkCommonAdvancedSettings()
	{
	}
}
