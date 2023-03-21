using System;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace MiniEXR;

public static class MiniEXR
{
	private static byte[] kHeader;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void MiniEXRWrite(string _filePath, uint _width, uint _height, Color[] _colorArray)
	{
	}

	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static byte[] MiniEXRWrite(uint _width, uint _height, Color[] _colorArray)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void MiniEXRWrite_Depth(string _filePath, uint _width, uint _height, Color[] _colorArray, float _farClip)
	{
	}

	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, Color[] _colorArray, float farClip)
	{
		return null;
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 51)]
	public static byte[] BuildEXRHeader(uint _width, uint _height, out int bufI)
	{
		bufI = default(int);
		return null;
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 39)]
	public static byte[] MiniEXRWrite(uint _width, uint _height, uint _channels, float[] _rgbaArray)
	{
		return null;
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, float[] _rArray)
	{
		return null;
	}
}
