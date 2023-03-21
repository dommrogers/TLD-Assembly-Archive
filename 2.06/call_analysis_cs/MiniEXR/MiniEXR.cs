using System;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace MiniEXR;

public static class MiniEXR
{
	private static byte[] kHeader;

	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallsUnknownMethods(Count = 5)]
	public static void MiniEXRWrite(string _filePath, uint _width, uint _height, Color[] _colorArray)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallsUnknownMethods(Count = 5)]
	public static byte[] MiniEXRWrite(uint _width, uint _height, Color[] _colorArray)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	public static void MiniEXRWrite_Depth(string _filePath, uint _width, uint _height, Color[] _colorArray, float _farClip)
	{
	}

	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallsUnknownMethods(Count = 2)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, Color[] _colorArray, float farClip)
	{
		return null;
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 2)]
	public static byte[] BuildEXRHeader(uint _width, uint _height, out int bufI)
	{
		bufI = default(int);
		return null;
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 2)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, float[] _rArray)
	{
		return null;
	}
}
