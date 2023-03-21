using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace MiniEXR;

public static class MiniEXR
{
	private static byte[] kHeader;

	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 0)]
	public static void MiniEXRWrite_Depth(string _filePath, uint _width, uint _height, Color[] _colorArray, float _farClip)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallsUnknownMethods(Count = 2)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, Color[] _colorArray, float farClip)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public static byte[] BuildEXRHeader(uint _width, uint _height, out int bufI)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref bufI) = null;
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
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
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 2)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, float[] _rArray)
	{
		return null;
	}
}
