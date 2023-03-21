using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

public sealed class P2PInterface : Handle
{
	public const int AcceptconnectionApiLatest = 1;

	public const int AddnotifypeerconnectionclosedApiLatest = 1;

	public const int AddnotifypeerconnectionrequestApiLatest = 1;

	public const int CloseconnectionApiLatest = 1;

	public const int CloseconnectionsApiLatest = 1;

	public const int GetnattypeApiLatest = 1;

	public const int GetnextreceivedpacketsizeApiLatest = 2;

	public const int GetportrangeApiLatest = 1;

	public const int GetrelaycontrolApiLatest = 1;

	public const int MaxConnections = 32;

	public const int MaxPacketSize = 1170;

	public const int QuerynattypeApiLatest = 1;

	public const int ReceivepacketApiLatest = 2;

	public const int SendpacketApiLatest = 2;

	public const int SetportrangeApiLatest = 1;

	public const int SetrelaycontrolApiLatest = 1;

	public const int SocketidApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public P2PInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public P2PInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AcceptConnectionOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result AcceptConnection(AcceptConnectionOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifyPeerConnectionClosedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyPeerConnectionClosed(AddNotifyPeerConnectionClosedOptions options, object clientData, OnRemoteConnectionClosedCallback connectionClosedHandler)
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifyPeerConnectionRequestOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyPeerConnectionRequest(AddNotifyPeerConnectionRequestOptions options, object clientData, OnIncomingConnectionRequestCallback connectionRequestHandler)
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CloseConnectionOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CloseConnection(CloseConnectionOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CloseConnectionsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CloseConnections(CloseConnectionsOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetNATTypeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result GetNATType(GetNATTypeOptions options, out NATType outNATType)
	{
		outNATType = default(NATType);
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetNextReceivedPacketSizeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result GetNextReceivedPacketSize(GetNextReceivedPacketSizeOptions options, out uint outPacketSizeBytes)
	{
		outPacketSizeBytes = default(uint);
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetPortRangeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result GetPortRange(GetPortRangeOptions options, out ushort outPort, out ushort outNumAdditionalPortsToTry)
	{
		outPort = default(ushort);
		outNumAdditionalPortsToTry = default(ushort);
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetRelayControlOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result GetRelayControl(GetRelayControlOptions options, out RelayControl outRelayControl)
	{
		outRelayControl = default(RelayControl);
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryNATTypeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryNATType(QueryNATTypeOptions options, object clientData, OnQueryNATTypeCompleteCallback nATTypeQueriedHandler)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReceivePacketOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(P2PInterface), Member = "EOS_P2P_ReceivePacket")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	public Result ReceivePacket(ReceivePacketOptions options, out ProductUserId outPeerId, out SocketId outSocketId, out byte outChannel, out byte[] outData)
	{
		outPeerId = null;
		outSocketId = null;
		outChannel = default(byte);
		outData = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyPeerConnectionClosed(ulong notificationId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyPeerConnectionRequest(ulong notificationId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SendPacketOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SendPacket(SendPacketOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPortRangeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetPortRange(SetPortRangeOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetRelayControlOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result SetRelayControl(SetRelayControlOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnIncomingConnectionRequestCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryNATTypeCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnRemoteConnectionClosedCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_AcceptConnection(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_P2P_AddNotifyPeerConnectionClosed(IntPtr handle, IntPtr options, IntPtr clientData, OnRemoteConnectionClosedCallbackInternal connectionClosedHandler);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_P2P_AddNotifyPeerConnectionRequest(IntPtr handle, IntPtr options, IntPtr clientData, OnIncomingConnectionRequestCallbackInternal connectionRequestHandler);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_CloseConnection(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_CloseConnections(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_GetNATType(IntPtr handle, IntPtr options, ref NATType outNATType);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_GetNextReceivedPacketSize(IntPtr handle, IntPtr options, ref uint outPacketSizeBytes);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_GetPortRange(IntPtr handle, IntPtr options, ref ushort outPort, ref ushort outNumAdditionalPortsToTry);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_GetRelayControl(IntPtr handle, IntPtr options, ref RelayControl outRelayControl);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_P2P_QueryNATType(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryNATTypeCompleteCallbackInternal nATTypeQueriedHandler);

	[PreserveSig]
	[CalledBy(Type = typeof(P2PInterface), Member = "ReceivePacket")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static extern Result EOS_P2P_ReceivePacket(IntPtr handle, IntPtr options, ref IntPtr outPeerId, ref SocketIdInternal outSocketId, ref byte outChannel, IntPtr outData, ref uint outBytesWritten);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_P2P_RemoveNotifyPeerConnectionClosed(IntPtr handle, ulong notificationId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_P2P_RemoveNotifyPeerConnectionRequest(IntPtr handle, ulong notificationId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_SendPacket(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_SetPortRange(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_P2P_SetRelayControl(IntPtr handle, IntPtr options);
}
