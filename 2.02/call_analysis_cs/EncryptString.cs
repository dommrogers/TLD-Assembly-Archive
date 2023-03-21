using System;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EncryptString
{
	public enum DecompressResult
	{
		Success,
		Empty,
		NotJson,
		Exception
	}

	private static bool m_Initialized;

	private static byte[] keyArray;

	private static ICryptoTransform m_EncoderTransform;

	private static ICryptoTransform m_DecoderTransform;

	private static RijndaelManaged m_rDel;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string GetKey()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptString), Member = "Init")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static string Encrypt(string toEncrypt)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptString), Member = "Init")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static string Decrypt(string toDecrypt)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static int CompressStringToBytesNoAlloc(string toEncrypt, ref byte[] outputBytes)
	{
		return 0;
	}

	[CalledBy(Type = typeof(JumpData), Member = "Rename")]
	[CalledBy(Type = typeof(JumpManager), Member = "Rename")]
	[CalledBy(Type = typeof(JumpManager), Member = "WriteDataForJump")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "CompressAndWriteString")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static byte[] CompressStringToBytes(string toEncrypt)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZF), Member = "DecompressNoAlloc")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int DecompressBytesNoAlloc(byte[] toDecrypt, ref byte[] outputBytes)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZF), Member = "Decompress")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static byte[] DecompressBytes(byte[] toDecrypt)
	{
		return null;
	}

	[CalledBy(Type = typeof(JumpData), Member = "LoadFromFile")]
	[CalledBy(Type = typeof(JumpManager), Member = "Rename")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string DecompressBytesToString(byte[] toDecrypt)
	{
		return null;
	}

	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(LZF), Member = "Decompress")]
	[Calls(Type = typeof(EncryptString), Member = "IsJsonString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static DecompressResult DecompressBytesToString(byte[] toDecrypt, out string result)
	{
		result = null;
		return default(DecompressResult);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "GetDateTimeFromSave")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "TryExtractTimeStampFromSave")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string DecompressBytesToStringNoAlloc(byte[] toDecrypt, ref byte[] buffer)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlotUsingGuid")]
	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LZF), Member = "DecompressNoAlloc")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(LZF), Member = "Decompress")]
	[Calls(Type = typeof(EncryptString), Member = "IsJsonString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static DecompressResult DecompressBytesToStringNoAlloc(byte[] toDecrypt, ref byte[] buffer, out string result)
	{
		result = null;
		return default(DecompressResult);
	}

	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsJsonString(string json)
	{
		return false;
	}

	[CalledBy(Type = typeof(EncryptString), Member = "Encrypt")]
	[CalledBy(Type = typeof(EncryptString), Member = "Decrypt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	private static void Init()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public EncryptString()
	{
	}
}
