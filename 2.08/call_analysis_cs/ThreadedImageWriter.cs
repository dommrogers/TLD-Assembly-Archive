using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using MiniEXR;
using UnityEngine;

public class ThreadedImageWriter : MonoBehaviour
{
	private Thread[] writerThreads;

	private Queue<ImageWriteRequest>[] writerQueues;

	private int nextWriterQueue;

	private const int NUM_WRITER_THREADS = 4;

	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CallsUnknownMethods(Count = 19)]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type, float farClip)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsUnknownMethods(Count = 19)]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 2)]
	public void AddWriteRequest(string filename, byte[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsFallingBehind()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 84)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(global::MiniEXR.MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(global::MiniEXR.MiniEXR), Member = "MiniEXRWrite_Depth")]
	private void ImageWriter(object obj)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ThreadedImageWriter()
	{
	}
}
