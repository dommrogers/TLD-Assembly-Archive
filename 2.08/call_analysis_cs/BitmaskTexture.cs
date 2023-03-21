using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BitmaskTexture
{
	private const int BITS_PER_BYTE = 8;

	private const int BITS_PER_PIXEL = 32;

	private const int BYTES_PER_PIXEL = 4;

	private Texture2D m_Texture;

	private byte[] m_RawData;

	private int m_BytesPerEntry;

	private int m_ArrayStride;

	private bool m_Dirty;

	public Texture2D Texture
	{
		[CallerCount(Count = 80)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BreakableIce), Member = "InitializeBrokenIceTexture")]
	[CallAnalysisFailed]
	public BitmaskTexture(int width, int height, int bitCount)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[Calls(Type = typeof(UnityException), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	public void ApplyChanges()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void ClearBit(int x, int y, int bit)
	{
	}

	[CallerCount(Count = 0)]
	public int IndexOf(int x, int y)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsBitSet(int x, int y, int bit)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetBit(int x, int y, int bit)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static int RoundUpAndDivide(int x, int d)
	{
		return default(int);
	}
}
