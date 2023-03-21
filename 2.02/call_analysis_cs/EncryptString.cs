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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static string GetKey()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EncryptString), Member = "Init")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String")]
	[CallsUnknownMethods(Count = 5)]
	public static string Encrypt(string toEncrypt)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptString), Member = "Init")]
	public static string Decrypt(string toDecrypt)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[CallsUnknownMethods(Count = 1)]
	public static int CompressStringToBytesNoAlloc(string toEncrypt, ref byte[] outputBytes)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(JumpManager), Member = "Rename")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "CompressAndWriteString")]
	[CalledBy(Type = typeof(JumpManager), Member = "WriteDataForJump")]
	[CalledBy(Type = typeof(JumpData), Member = "Rename")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	public static byte[] CompressStringToBytes(string toEncrypt)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LZF), Member = "DecompressNoAlloc")]
	public static int DecompressBytesNoAlloc(byte[] toDecrypt, ref byte[] outputBytes)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LZF), Member = "Decompress")]
	public static byte[] DecompressBytes(byte[] toDecrypt)
	{
		return null;
	}

	[CalledBy(Type = typeof(JumpManager), Member = "Rename")]
	[CalledBy(Type = typeof(JumpData), Member = "LoadFromFile")]
	[CalledBy(Type = typeof(JumpData), Member = "LoadFromFile")]
	[CalledBy(Type = typeof(JumpData), Member = "LoadFromFile")]
	[CalledBy(Type = typeof(JumpData), Member = "LoadFromFile")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	public static string DecompressBytesToString(byte[] toDecrypt)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(LZF), Member = "Decompress")]
	[Calls(Type = typeof(EncryptString), Member = "IsJsonString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[CallsUnknownMethods(Count = 2)]
	public static DecompressResult DecompressBytesToString(byte[] toDecrypt, out string result)
	{
		result = null;
		return default(DecompressResult);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "GetDateTimeFromSave")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "TryExtractTimeStampFromSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CallerCount(Count = 4)]
	public static string DecompressBytesToStringNoAlloc(byte[] toDecrypt, ref byte[] buffer)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlotUsingGuid")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(LZF), Member = "Decompress")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(LZF), Member = "DecompressNoAlloc")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EncryptString), Member = "IsJsonString")]
	public static DecompressResult DecompressBytesToStringNoAlloc(byte[] toDecrypt, ref byte[] buffer, out string result)
	{
		result = null;
		return default(DecompressResult);
	}

	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	private static bool IsJsonString(string json)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CalledBy(Type = typeof(EncryptString), Member = "Encrypt")]
	[CalledBy(Type = typeof(EncryptString), Member = "Decrypt")]
	private static void Init()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public EncryptString()
	{
	}
}
