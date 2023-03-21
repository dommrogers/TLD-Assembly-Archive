using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Networking;

public class WebUtils
{
	public class SteamCloudManager
	{
		public enum BatchType
		{
			Parallel,
			Sequence
		}

		private class BatchOperation : CommonCloudOperation
		{
			private sealed class _003CBatch_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public BatchOperation _003C_003E4__this;

				private List<CommonCloudOperation>.Enumerator _003C_003E7__wrap1;

				private CommonCloudOperation _003Coperation_003E5__3;

				private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
				{
					[CallerCount(Count = 29)]
					[DeduplicatedMethod]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[CallerCount(Count = 29)]
					[DebuggerHidden]
					[DeduplicatedMethod]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 0)]
				public _003CBatch_003Ed__10(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				[CallerCount(Count = 1)]
				[Calls(Type = typeof(_003CBatch_003Ed__10), Member = "<>m__Finally1")]
				[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Calls(Type = typeof(_003CBatch_003Ed__10), Member = "System.IDisposable.Dispose")]
				[Calls(Type = typeof(_003CBatch_003Ed__10), Member = "<>m__Finally1")]
				[Calls(Type = typeof(BatchOperation), Member = "IsBatchSuccess")]
				[CallsUnknownMethods(Count = 27)]
				[CallsDeduplicatedMethods(Count = 5)]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(BatchOperation), Member = "IsBatchCompleted")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[CallerCount(Count = 2)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "System.IDisposable.Dispose")]
				[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
				private void _003C_003Em__Finally1()
				{
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 3)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private Action<ICloudOperation> m_OnOperationComplete;

			private List<CommonCloudOperation> m_OperationList;

			private bool m_IsExecuting;

			private BatchType m_Type;

			[CallsUnknownMethods(Count = 7)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 9)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			public BatchOperation(Action<ICloudOperation> onOperationComplete, BatchType type)
			{
			}

			[CallsUnknownMethods(Count = 1)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 15)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			public void AddOperation(CommonCloudOperation operation)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 4)]
			[Calls(Type = typeof(BatchOperation), Member = "Batch")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
			[CallsUnknownMethods(Count = 6)]
			public override void Execute()
			{
			}

			[CallsUnknownMethods(Count = 4)]
			[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			private void RemoveSuccessfullOperations()
			{
			}

			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
			[CallsUnknownMethods(Count = 3)]
			private bool IsBatchCompleted()
			{
				return default(bool);
			}

			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CalledBy(Type = typeof(BatchOperation), Member = "BatchDone")]
			[CalledBy(Type = typeof(_003CBatch_003Ed__10), Member = "MoveNext")]
			[CallsUnknownMethods(Count = 3)]
			private bool IsBatchSuccess()
			{
				return default(bool);
			}

			[CalledBy(Type = typeof(BatchOperation), Member = "Execute")]
			[CallsUnknownMethods(Count = 7)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 1)]
			[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
			private IEnumerator Batch()
			{
				return null;
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(BatchOperation), Member = "IsBatchSuccess")]
			private void BatchDone()
			{
			}
		}

		public struct DeleteRequestResult
		{
			public string m_Filename;

			public bool m_Success;

			public string m_Error;
		}

		private class LocalFileDeleteOperation : CommonCloudOperation
		{
			private string m_FileName;

			[DeduplicatedMethod]
			[CallerCount(Count = 20)]
			public LocalFileDeleteOperation(string filename)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			public override void Execute()
			{
			}
		}

		private class DeleteOperation : CommonCloudOperation
		{
			private sealed class _003C_003Ec__DisplayClass7_0
			{
				public DeleteRequestResult result;

				public string filename;

				public DeleteOperation _003C_003E4__this;

				[CallerCount(Count = 2)]
				[DeduplicatedMethod]
				public _003C_003Ec__DisplayClass7_0()
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(DeleteOperation), Member = "RequestDeleteDataCompleted")]
				[CallsUnknownMethods(Count = 3)]
				internal void _003CWebRequestDeleteData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(Type = typeof(DeleteOperation), Member = "RequestDeleteDataCompleted")]
				[CallsUnknownMethods(Count = 1)]
				internal void _003CWebRequestDeleteData_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private string m_Token;

			private string m_FileName;

			private Action<bool> m_OnOperationComplete;

			[CallerCount(Count = 3)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "EnumerateForDeleteAllDone")]
			public DeleteOperation(string token, string filename, Action<bool> onOperationComplete)
			{
			}

			[CallsUnknownMethods(Count = 2)]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[Calls(Type = typeof(DeleteOperation), Member = "WebRequestDeleteData")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 0)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(DeleteOperation), Member = "WebRequestDeleteData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 2)]
			public void RequestDeleteData(string token, string filename)
			{
			}

			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass7_0), Member = "<WebRequestDeleteData>b__0")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass7_0), Member = "<WebRequestDeleteData>b__1")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			private void RequestDeleteDataCompleted(DeleteRequestResult result)
			{
			}

			[CalledBy(Type = typeof(DeleteOperation), Member = "RequestDeleteData")]
			[CalledBy(Type = typeof(DeleteOperation), Member = "Execute")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 30)]
			[Calls(Type = typeof(string), Member = "Concat")]
			private IEnumerator WebRequestDeleteData(string token, string filename)
			{
				return null;
			}
		}

		private class DownloadSaveOperation : CommonCloudOperation
		{
			private string m_FileName;

			private DateTime m_DateTime;

			private DownloadOperation m_DownloadOperation;

			private Action<bool> m_OnOperationComplete;

			[CallsUnknownMethods(Count = 14)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			public DownloadSaveOperation(string filename, DateTime dateTime, string url, string sha1, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(DownloadSaveOperation), Member = "OperationFailed")]
			[Calls(Type = typeof(DownloadSaveOperation), Member = "OperationFailed")]
			private void DownloadDone(DownloadDataResult result)
			{
			}

			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CalledBy(Type = typeof(DownloadSaveOperation), Member = "DownloadDone")]
			[CalledBy(Type = typeof(DownloadSaveOperation), Member = "DownloadDone")]
			private void OperationFailed()
			{
			}
		}

		private class DownloadOperation : CommonCloudOperation
		{
			private string m_Url;

			private string m_FileName;

			private string m_Sha1;

			private Action<DownloadDataResult> m_OnOperationComplete;

			[CallerCount(Count = 0)]
			public DownloadOperation(string filename, string url, string sha1, Action<DownloadDataResult> onOperationComplete)
			{
			}

			[CallsUnknownMethods(Count = 7)]
			[Calls(Type = typeof(WebUtils), Member = "DownloadData")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "ComputeSha1Hex")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			private void DownloadDone(DownloadDataResult result)
			{
			}
		}

		public struct EnumerateFilesResult
		{
			public enum ResultType
			{
				Success,
				Error,
				Empty
			}

			public struct FileInfo
			{
				public readonly string m_Filename;

				public readonly DateTime m_DateTime;

				public readonly string m_Sha;

				public readonly uint m_Filesize;

				public readonly string m_Url;

				[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
				[CalledBy(Type = typeof(EnumerateFilesOperation._003C_003Ec__DisplayClass5_0), Member = "<WebRequestEnumerateFiles>b__0")]
				[CallerCount(Count = 3)]
				[CalledBy(Type = typeof(EnumerateFilesResult), Member = ".cctor")]
				public FileInfo(string fileName, DateTime dateTime, string sha, uint size, string url)
				{
				}

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				public bool IsContentIdentical(FileInfo other)
				{
					return default(bool);
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(FileInfo), Member = "op_Equality")]
				[CallsUnknownMethods(Count = 1)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[CallsUnknownMethods(Count = 1)]
				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(ValueType), Member = "GetHashCode")]
				public override int GetHashCode()
				{
					return default(int);
				}

				[CalledBy(Type = typeof(SteamCloudManager), Member = "GetCloudFileSyncStatus")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
				[CalledBy(Type = typeof(FileInfo), Member = "Equals")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "GetLocalFileSyncStatus")]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				[CallerCount(Count = 6)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				public static bool operator ==(FileInfo a, FileInfo b)
				{
					return default(bool);
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				[Calls(Type = typeof(string), Member = "EqualsHelper")]
				[Calls(Type = typeof(string), Member = "op_Inequality")]
				public static bool operator !=(FileInfo a, FileInfo b)
				{
					return default(bool);
				}
			}

			public static FileInfo INVALID_FILEINFO;

			public ResultType m_ResultType;

			public string m_Error;

			public List<FileInfo> m_Files;

			public ICloudOperation m_CloudOperation;
		}

		private class EnumerateFilesOperation : CommonCloudOperation
		{
			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public EnumerateFilesResult result;

				public EnumerateFilesOperation _003C_003E4__this;

				[DeduplicatedMethod]
				[CallerCount(Count = 2)]
				public _003C_003Ec__DisplayClass5_0()
				{
				}

				[CallsUnknownMethods(Count = 20)]
				[Calls(Type = typeof(EnumerateFilesOperation), Member = "RequestEnumerateFilesDone")]
				[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
				[Calls(Type = typeof(string), Member = "FormatHelper")]
				[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
				[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = ".ctor")]
				[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
				[Calls(Type = typeof(string), Member = "Concat")]
				[Calls(Type = typeof(WebUtils), Member = "FromUnixTime")]
				[CallsDeduplicatedMethods(Count = 5)]
				[CallerCount(Count = 0)]
				internal void _003CWebRequestEnumerateFiles_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(Type = typeof(EnumerateFilesOperation), Member = "RequestEnumerateFilesDone")]
				[CallsUnknownMethods(Count = 1)]
				internal void _003CWebRequestEnumerateFiles_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private string m_Token;

			private Action<EnumerateFilesResult> m_OnOperationComplete;

			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
			[CallsUnknownMethods(Count = 2)]
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Update")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			public EnumerateFilesOperation(string token, Action<EnumerateFilesResult> onOperationComplete1, Action<EnumerateFilesResult> onOperationComplete2)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 2)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 2)]
			private void RequestEnumerateFiles(string token, bool extendedDetails)
			{
			}

			[CallsUnknownMethods(Count = 39)]
			[CalledBy(Type = typeof(EnumerateFilesOperation), Member = "RequestEnumerateFiles")]
			[CalledBy(Type = typeof(EnumerateFilesOperation), Member = "Execute")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(string), Member = "Format")]
			private IEnumerator WebRequestEnumerateFiles(string token, bool extendedDetails)
			{
				return null;
			}

			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass5_0), Member = "<WebRequestEnumerateFiles>b__0")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass5_0), Member = "<WebRequestEnumerateFiles>b__1")]
			private void RequestEnumerateFilesDone(EnumerateFilesResult result)
			{
			}
		}

		public class Enumerate
		{
			public class EnumerateUserFiles_v1
			{
				public class ResponseData
				{
					public class FileInfo
					{
						public uint file_size;

						public ulong timestamp;

						public string filename;

						public string file_sha;

						public string url;

						[DeduplicatedMethod]
						[CallerCount(Count = 2)]
						public FileInfo()
						{
						}
					}

					public List<FileInfo> files;

					public uint total_files;

					[DeduplicatedMethod]
					[CallerCount(Count = 2)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[CallerCount(Count = 2)]
				[DeduplicatedMethod]
				public EnumerateUserFiles_v1()
				{
				}
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			public static EnumerateUserFiles_v1 ParseJson(string txt)
			{
				return null;
			}

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public Enumerate()
			{
			}
		}

		private enum CloudSyncStatus
		{
			CloudOnly,
			LocalOnly,
			CloudNewer,
			LocalNewer,
			CloudOlder,
			LocalOlder,
			ContentIdentical
		}

		private enum SyncConflictResult
		{
			AcceptCloud,
			AcceptLocal
		}

		public struct BeginUploadRequestResult
		{
			public bool m_Success;

			public Upload.BeginHTTPUpload_v1 m_Result;

			public string m_Response;

			public string m_Filename;

			public string m_Error;
		}

		public struct UploadPutRequestResult
		{
			public bool m_Success;

			public long m_ResponseCode;

			public string m_Error;
		}

		public struct UploadCommitRequestResult
		{
			public bool m_Success;

			public string m_Error;

			public bool m_TransferSuccess;
		}

		private class UploadOperation : CommonCloudOperation
		{
			private sealed class _003C_003Ec__DisplayClass14_0
			{
				public BeginUploadRequestResult result;

				public string filename;

				public UploadOperation _003C_003E4__this;

				[CallerCount(Count = 2)]
				[DeduplicatedMethod]
				public _003C_003Ec__DisplayClass14_0()
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 5)]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
				[CallsUnknownMethods(Count = 4)]
				internal void _003CWebRequestBeginUploadData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
				[CallsUnknownMethods(Count = 1)]
				internal void _003CWebRequestBeginUploadData_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass15_0
			{
				public UploadCommitRequestResult result;

				public bool transfer_succeeded;

				public UploadOperation _003C_003E4__this;

				[DeduplicatedMethod]
				[CallerCount(Count = 2)]
				public _003C_003Ec__DisplayClass15_0()
				{
				}

				[CallsUnknownMethods(Count = 5)]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_CommitDone")]
				[CallsDeduplicatedMethods(Count = 4)]
				[CallerCount(Count = 0)]
				internal void _003CWebRequestCommitUpload_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_CommitDone")]
				[CallsUnknownMethods(Count = 1)]
				internal void _003CWebRequestCommitUpload_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass16_0
			{
				public UploadPutRequestResult result;

				public UploadOperation _003C_003E4__this;

				public string filename;

				[DeduplicatedMethod]
				[CallerCount(Count = 2)]
				public _003C_003Ec__DisplayClass16_0()
				{
				}

				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_PutDone")]
				[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
				[CallsUnknownMethods(Count = 10)]
				[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
				[CallsDeduplicatedMethods(Count = 8)]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(string), Member = "FormatHelper")]
				internal void _003CWebRequestUploadData_003Eb__0(UnityWebRequest response)
				{
				}

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 2)]
				[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
				[Calls(Type = typeof(UploadOperation), Member = "RequestUploadData_PutDone")]
				[CallsUnknownMethods(Count = 4)]
				internal void _003CWebRequestUploadData_003Eb__1(UnityWebRequest response)
				{
				}
			}

			private string m_Token;

			private string m_FileName;

			private byte[] m_Bytes;

			private string m_FileSha;

			private Action<bool> m_OnOperationComplete;

			[Calls(Type = typeof(WebUtils), Member = "ComputeSha1Hex")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			public UploadOperation(string token, string filename, byte[] data, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestBeginUploadData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 3)]
			public override void Execute()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestBeginUploadData")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallsUnknownMethods(Count = 2)]
			public void RequestBeginUploadData(string token, int filesize, string filename, string filesha)
			{
			}

			[CallsUnknownMethods(Count = 2)]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestUploadData")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			public void RequestUploadData(string url_host, string url_path, string filename, Dictionary<string, string> httpHeaders, byte[] data)
			{
			}

			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestCommitUpload")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_PutDone")]
			[CallsUnknownMethods(Count = 2)]
			public void RequestCommitUpload(string token, bool transfer_succeeded, string filename, string filesha)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			private void OperationFailed()
			{
			}

			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass14_0), Member = "<WebRequestBeginUploadData>b__1")]
			[CallsUnknownMethods(Count = 22)]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass14_0), Member = "<WebRequestBeginUploadData>b__0")]
			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 7)]
			[Calls(Type = typeof(UploadOperation), Member = "WebRequestUploadData")]
			private void RequestUploadData_BeginDone(BeginUploadRequestResult result)
			{
			}

			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass16_0), Member = "<WebRequestUploadData>b__1")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass16_0), Member = "<WebRequestUploadData>b__0")]
			[Calls(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 2)]
			private void RequestUploadData_PutDone(UploadPutRequestResult result)
			{
			}

			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass15_0), Member = "<WebRequestCommitUpload>b__1")]
			[CalledBy(Type = typeof(_003C_003Ec__DisplayClass15_0), Member = "<WebRequestCommitUpload>b__0")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(string), Member = "FormatHelper")]
			[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
			[Calls(Type = typeof(Debug), Member = "LogError")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
			private void RequestUploadData_CommitDone(UploadCommitRequestResult result)
			{
			}

			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[CallsUnknownMethods(Count = 30)]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestBeginUploadData")]
			[CalledBy(Type = typeof(UploadOperation), Member = "Execute")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
			[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "FormatHelper")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			private IEnumerator WebRequestBeginUploadData(string token, int filesize, string filename, string filesha)
			{
				return null;
			}

			[CalledBy(Type = typeof(UploadOperation), Member = "RequestCommitUpload")]
			[Calls(Type = typeof(Utils), Member = "WebRequest")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[CallsUnknownMethods(Count = 31)]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = "AddField")]
			[Calls(Type = typeof(WWWForm), Member = ".ctor")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "FormatHelper")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			private IEnumerator WebRequestCommitUpload(string token, bool transfer_succeeded, string filename, string filesha)
			{
				return null;
			}

			[CallsUnknownMethods(Count = 23)]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData_BeginDone")]
			[CalledBy(Type = typeof(UploadOperation), Member = "RequestUploadData")]
			[Calls(Type = typeof(Utils), Member = "WebRequestPut")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(string), Member = "StartsWith")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[CallsDeduplicatedMethods(Count = 1)]
			private IEnumerator WebRequestUploadData(string url_host, string url_path, string filename, Dictionary<string, string> httpHeaders, byte[] data)
			{
				return null;
			}
		}

		public class Upload
		{
			public class BeginHTTPUpload_v1
			{
				public class ResponseData
				{
					public class HttpHeader
					{
						public string name;

						public string value;

						[DeduplicatedMethod]
						[CallerCount(Count = 2)]
						public HttpHeader()
						{
						}
					}

					public ulong ugcid;

					public uint timestamp;

					public string url_host;

					public string url_path;

					public bool use_https;

					public List<HttpHeader> request_headers;

					[DeduplicatedMethod]
					[CallerCount(Count = 2)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[DeduplicatedMethod]
				[CallerCount(Count = 2)]
				public BeginHTTPUpload_v1()
				{
				}
			}

			public class CommitHTTPUpload_v1
			{
				public class ResponseData
				{
					public bool file_committed;

					[DeduplicatedMethod]
					[CallerCount(Count = 2)]
					public ResponseData()
					{
					}
				}

				public ResponseData response;

				[DeduplicatedMethod]
				[CallerCount(Count = 2)]
				public CommitHTTPUpload_v1()
				{
				}
			}

			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 0)]
			public static BeginHTTPUpload_v1 ParseJson(string txt)
			{
				return null;
			}

			[CallsUnknownMethods(Count = 2)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 0)]
			public static bool IsCommitHTTPUploadSuccess(string response)
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public Upload()
			{
			}
		}

		private class UploadSaveOperation : CommonCloudOperation
		{
			private string m_FileName;

			private string m_Token;

			private UploadOperation m_UploadOperation;

			private Action<bool> m_OnOperationComplete;

			[CallerCount(Count = 2)]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
			[CalledBy(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
			public UploadSaveOperation(string token, string fileName, Action<bool> onOperationComplete)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(UploadSaveOperation), Member = "OperationFailed")]
			[Calls(Type = typeof(UploadSaveOperation), Member = "OperationFailed")]
			public override void Execute()
			{
			}

			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 0)]
			private void DownloadDone(bool result)
			{
			}

			[CalledBy(Type = typeof(UploadSaveOperation), Member = "Execute")]
			[CalledBy(Type = typeof(UploadSaveOperation), Member = "Execute")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 2)]
			private void OperationFailed()
			{
			}
		}

		private class WaitSaveOperation : CommonCloudOperation
		{
			private sealed class _003CWaitSaveOperationComplete_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public WaitSaveOperation _003C_003E4__this;

				private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
				{
					[DeduplicatedMethod]
					[CallerCount(Count = 29)]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 29)]
					get
					{
						return null;
					}
				}

				[CallerCount(Count = 0)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				public _003CWaitSaveOperationComplete_003Ed__3(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 2)]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[CallsUnknownMethods(Count = 10)]
				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 3)]
				[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
				[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
				[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
				[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 3)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private Action m_OnOperationComplete;

			[DeduplicatedMethod]
			[CallerCount(Count = 20)]
			public WaitSaveOperation(Action onCompleted)
			{
			}

			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(WaitSaveOperation), Member = "WaitSaveOperationComplete")]
			[CallsUnknownMethods(Count = 2)]
			public override void Execute()
			{
			}

			[CallsUnknownMethods(Count = 7)]
			[CalledBy(Type = typeof(WaitSaveOperation), Member = "Execute")]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
			private IEnumerator WaitSaveOperationComplete()
			{
				return null;
			}
		}

		private class AuthenticateOperation : CommonCloudOperation
		{
			private enum OperationStatus
			{
				Cancel,
				Retry,
				Success,
				ShowingRetryDialog,
				RetrieveToken,
				RetrievingToken,
				VerifyToken,
				VerifyingToken
			}

			private sealed class _003CAuthenticate_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public AuthenticateOperation _003C_003E4__this;

				private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
				{
					[DebuggerHidden]
					[DeduplicatedMethod]
					[CallerCount(Count = 29)]
					get
					{
						return null;
					}
				}

				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[DeduplicatedMethod]
					[DebuggerHidden]
					[CallerCount(Count = 29)]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				[DeduplicatedMethod]
				[CallerCount(Count = 0)]
				public _003CAuthenticate_003Ed__6(int _003C_003E1__state)
				{
				}

				[CallerCount(Count = 2)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[CallsUnknownMethods(Count = 1)]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(AuthenticateOperation), Member = "Update")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[DebuggerHidden]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
				[CallsUnknownMethods(Count = 3)]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			private string m_Token;

			private Action<bool> m_OnOperationComplete;

			private OperationStatus m_Status;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public AuthenticateOperation(string token, Action<bool> onOperationComplete)
			{
			}

			[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
			[Calls(Type = typeof(AuthenticateOperation), Member = "Authenticate")]
			[CallsUnknownMethods(Count = 2)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			public override void Execute()
			{
			}

			[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Execute")]
			[CallsUnknownMethods(Count = 7)]
			private IEnumerator Authenticate()
			{
				return null;
			}

			[CalledBy(Type = typeof(_003CAuthenticate_003Ed__6), Member = "MoveNext")]
			[CallsUnknownMethods(Count = 16)]
			[Calls(Type = typeof(AuthenticateOperation), Member = "RetrieveToken")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(AuthenticateOperation), Member = "AuthenticationComplete")]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(EnumerateFilesOperation), Member = ".ctor")]
			private void Update()
			{
			}

			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Success")]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(string), Member = "Concat")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Update")]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "EnumerateForAuthenticationDone")]
			private void AuthenticationComplete()
			{
			}

			[CalledBy(Type = typeof(AuthenticateOperation), Member = "Update")]
			[CallAnalysisFailed]
			[CallerCount(Count = 1)]
			private void RetrieveToken()
			{
			}

			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
			[CalledBy(Type = typeof(AuthenticateOperation), Member = "EnumerateForAuthenticationDone")]
			[CallsUnknownMethods(Count = 15)]
			private void ShowRetryDialog()
			{
			}

			[CallerCount(Count = 0)]
			private void CancelAuthentication(bool wasCanceled)
			{
			}

			[CallerCount(Count = 0)]
			private void RetryAuthentication()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AuthenticateOperation), Member = "ShowRetryDialog")]
			[Calls(Type = typeof(AuthenticateOperation), Member = "AuthenticationComplete")]
			private void EnumerateForAuthenticationDone(EnumerateFilesResult result)
			{
			}

			[Calls(Type = typeof(AuthenticateOperation), Member = "AuthenticationComplete")]
			[CallerCount(Count = 0)]
			private void Success()
			{
			}

			[CallsUnknownMethods(Count = 3)]
			[Calls(Type = typeof(Panel_OptionsMenu), Member = "SaveSettings")]
			[Calls(Type = typeof(SteamCloudManager), Member = "SetToken")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
			private static void SaveToken(string token)
			{
			}
		}

		public struct AuthenticationResult
		{
			public enum ResultType
			{
				Success,
				AccessDenied,
				MalformedUrlError,
				Canceled
			}

			public ResultType m_Result;

			public string m_Token;
		}

		public interface ICloudOperation
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 121780)]
			bool IsCompleted();

			[DeduplicatedMethod]
			[CallerCount(Count = 121780)]
			bool IsSuccess();

			[DeduplicatedMethod]
			[CallerCount(Count = 121780)]
			bool IsRetryPending();
		}

		private class CommonCloudOperation : ICloudOperation
		{
			protected bool m_Completed;

			protected bool m_Success;

			protected Action m_OnExecuteStarted;

			private int m_NumRetries;

			private int m_RetryCount;

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public bool IsCompleted()
			{
				return default(bool);
			}

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public bool IsSuccess()
			{
				return default(bool);
			}

			[CallerCount(Count = 0)]
			public bool IsRetryPending()
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public void SetNumRetries(int numRetries)
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			public virtual void Execute()
			{
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private void Reset()
			{
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 71)]
			public void SetOnExecuteStarted(Action onExecuteStarted)
			{
			}

			[Calls(Type = typeof(string), Member = "FormatHelper")]
			[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
			[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			public bool Retry()
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public CommonCloudOperation()
			{
			}
		}

		public const int MAX_SYNCOPERATION_RETRIES = 3;

		private Dictionary<CloudSyncStatus, List<EnumerateFilesResult.FileInfo>> m_CloudFilesBySyncStatus;

		private static readonly int s_CloudSyncStatusCount;

		private SyncConflictResult m_SyncConflictResult;

		private bool m_SaveFilesSynchronized;

		private bool m_SaveFilesSynchronizationStarted;

		private bool m_AreCloudFilesNewer;

		public const string STEAMCLOUD_SYNCING_LOCID = "STEAMCLOUD_Syncing";

		public const string STEAMCLOUD_SYNC_LOCID = "STEAMCLOUD_Sync";

		public const string STEAMCLOUD_SYNC_ON_LOCID = "STEAMCLOUD_SyncOn";

		public const string STEAMCLOUD_SYNC_OFF_LOCID = "STEAMCLOUD_SyncOff";

		public const string STEAMCLOUD_RETRIEVINGFILES_LOCID = "STEAMCLOUD_RetrievingFiles";

		public const string STEAMCLOUD_SYNCFAILED_LOCID = "STEAMCLOUD_SynchronizationFailed";

		public const string STEAMCLOUD_AUTH_FAILED_LOCID = "STEAMCLOUD_AuthenticationFailed";

		public const string STEAMCLOUD_AUTH_RETRY_LOCID = "STEAMCLOUD_RetryAuthentication";

		public const string STEAMCLOUD_CONFLICT_TITLE_LOCID = "STEAMCLOUD_ConflictTitle";

		public const string STEAMCLOUD_CLOUD_NEWER_LOCID = "STEAMCLOUD_CloudFilesNewerConfirm";

		public const string STEAMCLOUD_LOCAL_NEWER_LOCID = "STEAMCLOUD_LocalFilesNewerConfirm";

		private const string STEAM_AUTH_URL = "https://steamcommunity.com/oauth/login?response_type=token&state=void&mobileminimal=1";

		private const string STEAM_CLIENT_ID = "CEF005FA";

		private const string STEAMAUTH_CALLBACKURL = "https://tldnewseditor.com/steamauth";

		private const string STEAMAUTH_CALLBACKABLEURL = "https://steamcommunity.com/oauth";

		private const string STEAMAUTH_TOKENPARAM = "access_token";

		private const string STEAMAUTH_ERRORARAM = "error";

		private const string STEAMAUTH_ACCESSDENIED_ERROR = "access_denied";

		private string m_Token;

		private static SteamCloudManager s_Instance;

		private CommonCloudOperation m_CurrentCloudOperation;

		private DateTime m_LastEnumerationTime;

		private List<EnumerateFilesResult.FileInfo> m_CloudFiles;

		private List<EnumerateFilesResult.FileInfo> m_LocalFiles;

		private Queue<CommonCloudOperation> m_OperationsQueue;

		private string m_CurrentMessageId;

		private const string STEAM_URL_ENUMERATE = "https://api.steampowered.com/ICloudService/EnumerateUserFiles/v1/";

		private const string STEAM_URL_REQUESTUPLOAD = "https://api.steampowered.com/ICloudService/BeginHTTPUpload/v1";

		private const string STEAM_URL_COMMITUPLOAD = "https://api.steampowered.com/ICloudService/CommitHTTPUpload/v1";

		private const string STEAM_URL_REQUESTDELETE = "https://api.steampowered.com/ICloudService/Delete/v1";

		public const string SAVE_CLOUD_PATH = "%WinAppDataLocal%Hinterland/TheLongDark/";

		private const string STEAM_APP_ID = "305620";

		private const string PLATFORM_TO_SYNC = "All";

		private Action<bool> m_OnSyncEnabledChanged;

		private Action m_OnSyncDone;

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void EnumerateLocalFiles()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private static bool WriteDownloadedSaveFile(DownloadDataResult result, string filename, DateTime dateTime)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		private static bool ReadSaveFile(string filename, out byte[] bytes)
		{
			bytes = null;
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private static bool DeleteSaveFile(string filename)
		{
			return default(bool);
		}

		[Calls(Type = typeof(SaveGameSlots), Member = "IsValidSavedGameName")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "FileEnumerationForSyncComplete")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		public static bool CloudFileRequiresSync(string fileName)
		{
			return default(bool);
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		public static DateTime GetDateTimeFromSave(byte[] data)
		{
			return default(DateTime);
		}

		[CallsUnknownMethods(Count = 14)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncDone")]
		[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SaveGameSlots), Member = "ReInit")]
		public void ReloadSaves()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool IsSyncSavesEnabled()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 14)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AuthenticateForSyncDone")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void RetrieveFilesForSync()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		public void HandleSaveDeleted(string saveFilename)
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		private void DeleteSaveStarted()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		private void DeleteSaveDone(bool res)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool HasSyncStarted()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsUnknownMethods(Count = 36)]
		public void Sync()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void HandleDataSaved(string filename)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSync")]
		[CallsUnknownMethods(Count = 2)]
		private void AuthenticateForSyncDone(ICloudOperation operation)
		{
		}

		[CallsUnknownMethods(Count = 15)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		private void ReplaceCloudSave(string cloudFileName)
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		private void ReplaceCloudSaveStarted()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		private void ReplaceCloudSaveDone(ICloudOperation operation)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		private void SyncStarted()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		private void RetrieveFilesForSyncSyncStarted()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudFilesRetrievedForSync")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(SteamCloudManager), Member = "RequestUserConfirmation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		private void SyncInternal()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		[CallsUnknownMethods(Count = 3)]
		private void CloudFilesRetrievedForSync(EnumerateFilesResult res)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		private void CloudSyncLocalNewerDeclined(bool wasCancelled)
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallerCount(Count = 0)]
		private void CloudSyncLocalNewerAccepted()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		private void CloudSyncNewerDeclined(bool wasCancelled)
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		private void CloudSyncNewerAccepted()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncLocalNewerAccepted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncNewerDeclined")]
		[CallsUnknownMethods(Count = 46)]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudSyncLocalNewerDeclined")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDownloadSave")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 17)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteLocalSave")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchDeleteSave")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddBatchUploadSave")]
		private void DoSyncOperation()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void SyncingFilesOperationStarted()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(SteamCloudManager), Member = "ReloadSaves")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		private void SyncDone(ICloudOperation cloudOperation)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void NotifySyncDone()
		{
		}

		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallerCount(Count = 0)]
		private void ReloadSavesReady()
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RequestUserConfirmation")]
		[CallsUnknownMethods(Count = 18)]
		private bool AreCloudFilesNewer()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 30)]
		[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(SteamCloudManager), Member = "AreCloudFilesNewer")]
		[CallerCount(Count = 1)]
		private void RequestUserConfirmation()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[CallsUnknownMethods(Count = 20)]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ClearCloudFilesBySyncStatus")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
		private void GatherFilesStatus()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		private void ClearCloudFilesBySyncStatus()
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FileExists")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CallsUnknownMethods(Count = 2)]
		private void AddToListIfNotFound(EnumerateFilesResult.FileInfo info, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallsUnknownMethods(Count = 25)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(DownloadSaveOperation), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		private void AddBatchDownloadSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CallsUnknownMethods(Count = 25)]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UploadSaveOperation), Member = ".ctor")]
		private void AddBatchUploadSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CallsUnknownMethods(Count = 25)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		private void AddBatchDeleteSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[CallsUnknownMethods(Count = 25)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		private void AddBatchDeleteLocalSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CallsUnknownMethods(Count = 18)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateUploadReplaceSaveFileOperation")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		private void AddBatchUploadReplaceSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AddBatchUploadReplaceSave")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSave")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 22)]
		[Calls(Type = typeof(UploadSaveOperation), Member = ".ctor")]
		private BatchOperation CreateUploadReplaceSaveFileOperation(string cloudFileName, Action<ICloudOperation> onOperationComplete)
		{
			return null;
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncInternal")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		private bool AreFilesIdentical(List<EnumerateFilesResult.FileInfo> filesToCompare)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetLocalFileSyncStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetCloudFileSyncStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AreFilesIdentical")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GatherFilesStatus")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "FileExists")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		private EnumerateFilesResult.FileInfo FindFile(string filename, List<EnumerateFilesResult.FileInfo> filesToSearch)
		{
			return default(EnumerateFilesResult.FileInfo);
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(string), Member = "op_Inequality")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AddToListIfNotFound")]
		private bool FileExists(EnumerateFilesResult.FileInfo fileInfo, List<EnumerateFilesResult.FileInfo> comparedToList)
		{
			return default(bool);
		}

		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private CloudSyncStatus GetCloudFileSyncStatus(EnumerateFilesResult.FileInfo cloudInfo)
		{
			return default(CloudSyncStatus);
		}

		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(EnumerateFilesResult.FileInfo), Member = "op_Equality")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "FindFile")]
		private CloudSyncStatus GetLocalFileSyncStatus(EnumerateFilesResult.FileInfo localInfo)
		{
			return default(CloudSyncStatus);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
		private static bool TryExtractTimeStampFromSave(byte[] data, out DateTime timestamp)
		{
			System.Runtime.CompilerServices.Unsafe.As<DateTime, @null>(ref timestamp) = null;
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
		[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
		[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
		[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
		private static bool IsSaveOperationInProgress()
		{
			return default(bool);
		}

		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		public static AuthenticationResult RequestAuthenticationToken()
		{
			return default(AuthenticationResult);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public static string GetAuthenticationRequestUrl()
		{
			return null;
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[CallsUnknownMethods(Count = 51)]
		private SteamCloudManager()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		public string GetToken()
		{
			return null;
		}

		[CalledBy(Type = typeof(AuthenticateOperation), Member = "SaveToken")]
		[CalledBy(Type = typeof(ConsoleManager), Member = "SaveToken")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		public void SetToken(string token)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "UpdateQueue")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsUnknownMethods(Count = 1)]
		public void Update()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		private void UpdateQueue()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		public void Authenticate()
		{
		}

		[Calls(Type = typeof(SteamCloudManager), Member = ".ctor")]
		[CallerCount(Count = 37)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public static SteamCloudManager GetInstance()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private bool HasSyncMessage()
		{
			return default(bool);
		}

		[Calls(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		private void UpdateSyncMessage()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		private void QueueOperation(CommonCloudOperation cloudOperation)
		{
		}

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(EnumerateFilesOperation), Member = ".ctor")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSync")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteAllCloudFiles")]
		[CallsUnknownMethods(Count = 15)]
		private CommonCloudOperation CreateFileEnumerationOperationForSync(Action<EnumerateFilesResult> onActionComplete, Action onOperationStarted)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		public void GetAllFiles(Action<EnumerateFilesResult> onActionComplete, Action onOperationStarted, int numRetries)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public bool IsOperationPending()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool IsSyncPending()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManager), Member = "CreateFileEnumerationOperationForSync")]
		[Calls(Type = typeof(SteamCloudManager), Member = "ProcessOperation")]
		[CallsUnknownMethods(Count = 7)]
		public void DeleteAllCloudFiles()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public void EnableSyncSaves(bool enabled)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool AreSaveFilesSynchronized()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public void RegisterSyncEnabledChanged(Action<bool> onSyncEnabledChanged)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		public void UnRegisterSyncEnabledChanged(Action<bool> onSyncEnabledChanged)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		public void RegisterSyncDone(Action onSyncDone)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		public void UnRegisterSyncDone(Action onSyncDone)
		{
		}

		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "ToString")]
		public static void DebugLogFiles(EnumerateFilesResult result)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteSaveStarted")]
		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "UpdateSyncMessage")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncingFilesOperationStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSyncSyncStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncStarted")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSaveStarted")]
		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCurrentMessageLabel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		public static void ShowSyncMessage(string locId)
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSaveDone")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "UpdateSyncMessage")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Update")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReloadSavesReady")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "SyncDone")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "CloudFilesRetrievedForSync")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "AuthenticateForSyncDone")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(GameManager), Member = "Update")]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCurrentMessageLabel")]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetInstance")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteSaveDone")]
		public static void HideSyncMessage()
		{
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "HandleSaveDeleted")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "HandleDataSaved")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
		public static string GetCloudSaveFilename(string filename)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		private bool IsCurrentOperationPending()
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(SteamCloudManager), Member = "GetAllFiles")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DeleteAllCloudFiles")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "DoSyncOperation")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReplaceCloudSave")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "Sync")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ReloadSaves")]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(SteamCloudManager), Member = "IsOperationPending")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "RetrieveFilesForSync")]
		private void ProcessOperation(CommonCloudOperation cloudOperation, int numRetries)
		{
		}

		[CallerCount(Count = 0)]
		private bool HasToken()
		{
			return default(bool);
		}

		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CloudFileRequiresSync")]
		[CallsUnknownMethods(Count = 12)]
		[Calls(Type = typeof(DateTime), Member = "get_Now")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		private void FileEnumerationForSyncComplete(EnumerateFilesResult result)
		{
		}

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
		[Calls(Type = typeof(BatchOperation), Member = "AddOperation")]
		[CallsUnknownMethods(Count = 26)]
		[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
		[Calls(Type = typeof(DeleteOperation), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(BatchOperation), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		private void EnumerateForDeleteAllDone(EnumerateFilesResult result)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 19)]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "ShowSyncMessage")]
		[CalledBy(Type = typeof(SteamCloudManager), Member = "HideSyncMessage")]
		[CallsUnknownMethods(Count = 9)]
		private static UILabel GetCurrentMessageLabel()
		{
			return null;
		}

		[CallsDeduplicatedMethods(Count = 8)]
		[CallerCount(Count = 0)]
		private static void RefreshCurrentSaveUI()
		{
		}

		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
		[CallerCount(Count = 14)]
		private static void RefreshSaveUI<T>(SaveSlotType saveSlotType) where T : Panel_Base
		{
		}
	}

	public struct DownloadDataResult
	{
		public bool m_Success;

		public byte[] m_Result;

		public string m_Error;
	}

	public class SteamCloudManagerPC
	{
		[Calls(Type = typeof(SteamCloudManager), Member = "GetDateTimeFromSave")]
		[Calls(Type = typeof(SteamCloudManager.EnumerateFilesResult.FileInfo), Member = ".ctor")]
		[CallsUnknownMethods(Count = 14)]
		[Calls(Type = typeof(WebUtils), Member = "ComputeSha1Hex")]
		[Calls(Type = typeof(SteamCloudManager), Member = "CloudFileRequiresSync")]
		[Calls(Type = typeof(File), Member = "ReadAllBytes")]
		[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
		[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
		[Calls(Type = typeof(SteamCloudManagerPC), Member = "GetDownloadDirectory")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManager), Member = "GetCloudSaveFilename")]
		public static void EnumerateLocalSaveFiles(List<SteamCloudManager.EnumerateFilesResult.FileInfo> list)
		{
		}

		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SteamCloudManagerPC), Member = "GetDownloadDirectory")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(File), Member = "ReadAllBytes")]
		public static bool ReadSaveFile(string filename, out byte[] bytes)
		{
			bytes = null;
			return default(bool);
		}

		[Calls(Type = typeof(File), Member = "Delete")]
		[Calls(Type = typeof(File), Member = "Exists")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SteamCloudManagerPC), Member = "GetDownloadDirectory")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		public static bool DeleteSaveFile(string filename)
		{
			return default(bool);
		}

		[Calls(Type = typeof(File), Member = "WriteAllBytes")]
		[Calls(Type = typeof(File), Member = "SetCreationTime")]
		[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
		[Calls(Type = typeof(File), Member = "SetLastWriteTime")]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
		[Calls(Type = typeof(Directory), Member = "Exists")]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Path), Member = "GetFileName")]
		[Calls(Type = typeof(SteamCloudManagerPC), Member = "GetDownloadDirectory")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Path), Member = "GetDirectoryName")]
		public static bool WriteDownloadedSaveFile(byte[] result, string filename, DateTime dateTime)
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "WriteDownloadedSaveFile")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "DeleteSaveFile")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "ReadSaveFile")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
		[CallsDeduplicatedMethods(Count = 1)]
		private static string GetDownloadDirectory()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SteamCloudManagerPC()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public DownloadDataResult result;

		public Action<DownloadDataResult> onCompleted;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(Array), Member = "CopyTo")]
		[CallsUnknownMethods(Count = 4)]
		internal void _003CDownloadData_003Eb__0(UnityWebRequest response)
		{
		}

		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		internal void _003CDownloadData_003Eb__1(UnityWebRequest response)
		{
		}
	}

	private static readonly DateTime EPOCH_TIME;

	private static bool s_DebugVerbose;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WebUtils), Member = "DebugLogVerbose")]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(SteamCloudManager.DownloadOperation), Member = "Execute")]
	[CallsUnknownMethods(Count = 24)]
	public static void DownloadData(string url, Action<DownloadDataResult> onCompleted)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string ShowWebPage(string requestedUrl, string callbackUrl, string callbackableUrl)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static string GetParamFromURI(string uri, char fragmentstart, string param)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	[CalledBy(Type = typeof(SteamCloudManager.EnumerateFilesOperation._003C_003Ec__DisplayClass5_0), Member = "<WebRequestEnumerateFiles>b__0")]
	public static DateTime FromUnixTime(ulong unixTime)
	{
		return default(DateTime);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SteamCloudManagerPC), Member = "EnumerateLocalSaveFiles")]
	[CalledBy(Type = typeof(SteamCloudManager.UploadOperation), Member = ".ctor")]
	[CalledBy(Type = typeof(SteamCloudManager.DownloadOperation), Member = "DownloadDone")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(BitConverter), Member = "ToString")]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash")]
	[Calls(Type = typeof(SHA1CryptoServiceProvider), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static string ComputeSha1Hex(byte[] data)
	{
		return null;
	}

	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DebugLogVerbose(string txt)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ToggleVerbose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static string ShowWebPageInternal(string requestedUrl, string callbackUrl, string callbackableUrl)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public WebUtils()
	{
	}
}
