using System;
using Cpp2ILInjected.CallAnalysis;

public static class LZF
{
	private static readonly uint HLOG;

	private static readonly uint HSIZE;

	private static readonly uint MAX_LIT;

	private static readonly uint MAX_OFF;

	private static readonly uint MAX_REF;

	private static readonly byte[] dataXORvalues;

	private static readonly byte[] dataADDvalues;

	private static readonly long[] HashTable;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public static void ObfuscateData(ref byte[] source, ref byte[] dest)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public static void DeObfuscateData(ref byte[] data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int CompressNoAlloc(byte[] inputBytes, ref byte[] destBytes)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static byte[] Compress(byte[] inputBytes)
	{
		return null;
	}

	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesNoAlloc")]
	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LZF), Member = "lzf_decompress")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int DecompressNoAlloc(byte[] inputBytes, ref byte[] destBytes)
	{
		return 0;
	}

	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytes")]
	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[CalledBy(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LZF), Member = "lzf_decompress")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static byte[] Decompress(byte[] inputBytes)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "CompressAndWriteString")]
	[CalledBy(Type = typeof(EncryptString), Member = "CompressStringToBytesNoAlloc")]
	[CalledBy(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[CalledBy(Type = typeof(LZF), Member = "CompressNoAlloc")]
	[CalledBy(Type = typeof(LZF), Member = "Compress")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 78)]
	public static int lzf_compress(byte[] input, ref byte[] output)
	{
		return 0;
	}

	[CalledBy(Type = typeof(LZF), Member = "DecompressNoAlloc")]
	[CalledBy(Type = typeof(LZF), Member = "Decompress")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	public static int lzf_decompress(byte[] input, ref byte[] output)
	{
		return 0;
	}
}
