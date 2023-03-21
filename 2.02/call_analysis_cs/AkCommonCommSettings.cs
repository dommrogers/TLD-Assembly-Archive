using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class AkCommonCommSettings : AkSettingsValidationHandler
{
	public uint m_PoolSize;

	public static ushort DefaultDiscoveryBroadcastPort;

	public ushort m_DiscoveryBroadcastPort;

	public ushort m_CommandPort;

	public ushort m_NotificationPort;

	public bool m_InitializeSystemComms;

	public string m_NetworkName;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkCommunicationSettings), Member = "set_szAppNetworkName")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 7)]
	public virtual void CopyTo(AkCommunicationSettings settings)
	{
	}

	[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkCommonCommSettings()
	{
	}
}
