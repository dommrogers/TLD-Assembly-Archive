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

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsUnknownMethods(Count = 18)]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type, float farClip)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsUnknownMethods(Count = 18)]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsUnknownMethods(Count = 18)]
	public void AddWriteRequest(string filename, byte[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsFallingBehind()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[Calls(Type = typeof(global::MiniEXR.MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(global::MiniEXR.MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 83)]
	private void ImageWriter(object obj)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ThreadedImageWriter()
	{
	}
}
