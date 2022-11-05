
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_PERFQUERY_SINGLE_CONTEXT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		[Log(BitmaskName = "GL")]
		public const int PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_GLOBAL_CONTEXT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		[Log(BitmaskName = "GL")]
		public const int PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_WAIT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_WAIT_INTEL = 0x83FB;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_FLUSH_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_FLUSH_INTEL = 0x83FA;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_DONOT_FLUSH_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_EVENT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_RAW_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_RAW_INTEL = 0x94F4;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF;

		/// <summary>
		/// [GL] Value of GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public const int PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500;

		/// <summary>
		/// [GL] glBeginPerfQueryINTEL: Binding for glBeginPerfQueryINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void BeginPerfQueryINTEL(uint queryHandle)
		{
			Debug.Assert(Delegates.pglBeginPerfQueryINTEL != null, "pglBeginPerfQueryINTEL not implemented");
			Delegates.pglBeginPerfQueryINTEL(queryHandle);
			LogCommand("glBeginPerfQueryINTEL", null, queryHandle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCreatePerfQueryINTEL: Binding for glCreatePerfQueryINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="queryHandle">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void CreatePerfQueryINTEL(uint queryId, uint[] queryHandle)
		{
			unsafe {
				fixed (uint* p_queryHandle = queryHandle)
				{
					Debug.Assert(Delegates.pglCreatePerfQueryINTEL != null, "pglCreatePerfQueryINTEL not implemented");
					Delegates.pglCreatePerfQueryINTEL(queryId, p_queryHandle);
					LogCommand("glCreatePerfQueryINTEL", null, queryId, queryHandle					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDeletePerfQueryINTEL: Binding for glDeletePerfQueryINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void DeletePerfQueryINTEL(uint queryHandle)
		{
			Debug.Assert(Delegates.pglDeletePerfQueryINTEL != null, "pglDeletePerfQueryINTEL not implemented");
			Delegates.pglDeletePerfQueryINTEL(queryHandle);
			LogCommand("glDeletePerfQueryINTEL", null, queryHandle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glEndPerfQueryINTEL: Binding for glEndPerfQueryINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void EndPerfQueryINTEL(uint queryHandle)
		{
			Debug.Assert(Delegates.pglEndPerfQueryINTEL != null, "pglEndPerfQueryINTEL not implemented");
			Delegates.pglEndPerfQueryINTEL(queryHandle);
			LogCommand("glEndPerfQueryINTEL", null, queryHandle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetFirstPerfQueryIdINTEL: Binding for glGetFirstPerfQueryIdINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void GetFirstPerfQueryIdINTEL([Out] uint[] queryId)
		{
			unsafe {
				fixed (uint* p_queryId = queryId)
				{
					Debug.Assert(Delegates.pglGetFirstPerfQueryIdINTEL != null, "pglGetFirstPerfQueryIdINTEL not implemented");
					Delegates.pglGetFirstPerfQueryIdINTEL(p_queryId);
					LogCommand("glGetFirstPerfQueryIdINTEL", null, queryId					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetNextPerfQueryIdINTEL: Binding for glGetNextPerfQueryIdINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="nextQueryId">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void GetNextPerfQueryIdINTEL(uint queryId, [Out] uint[] nextQueryId)
		{
			unsafe {
				fixed (uint* p_nextQueryId = nextQueryId)
				{
					Debug.Assert(Delegates.pglGetNextPerfQueryIdINTEL != null, "pglGetNextPerfQueryIdINTEL not implemented");
					Delegates.pglGetNextPerfQueryIdINTEL(queryId, p_nextQueryId);
					LogCommand("glGetNextPerfQueryIdINTEL", null, queryId, nextQueryId					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetPerfCounterInfoINTEL: Binding for glGetPerfCounterInfoINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="counterId">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="counterNameLength">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="counterName">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		/// <param name="counterDescLength">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="counterDesc">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		/// <param name="counterOffset">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="counterDataSize">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="counterTypeEnum">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="counterDataTypeEnum">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="rawCounterMaxValue">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void GetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, StringBuilder counterName, uint counterDescLength, StringBuilder counterDesc, [Out] uint[] counterOffset, [Out] uint[] counterDataSize, [Out] uint[] counterTypeEnum, [Out] uint[] counterDataTypeEnum, [Out] ulong[] rawCounterMaxValue)
		{
			unsafe {
				fixed (uint* p_counterOffset = counterOffset)
				fixed (uint* p_counterDataSize = counterDataSize)
				fixed (uint* p_counterTypeEnum = counterTypeEnum)
				fixed (uint* p_counterDataTypeEnum = counterDataTypeEnum)
				fixed (ulong* p_rawCounterMaxValue = rawCounterMaxValue)
				{
					Debug.Assert(Delegates.pglGetPerfCounterInfoINTEL != null, "pglGetPerfCounterInfoINTEL not implemented");
					Delegates.pglGetPerfCounterInfoINTEL(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, p_counterOffset, p_counterDataSize, p_counterTypeEnum, p_counterDataTypeEnum, p_rawCounterMaxValue);
					LogCommand("glGetPerfCounterInfoINTEL", null, queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetPerfQueryDataINTEL: Binding for glGetPerfQueryDataINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="dataSize">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="bytesWritten">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, IntPtr data, [Out] uint[] bytesWritten)
		{
			unsafe {
				fixed (uint* p_bytesWritten = bytesWritten)
				{
					Debug.Assert(Delegates.pglGetPerfQueryDataINTEL != null, "pglGetPerfQueryDataINTEL not implemented");
					Delegates.pglGetPerfQueryDataINTEL(queryHandle, flags, dataSize, data, p_bytesWritten);
					LogCommand("glGetPerfQueryDataINTEL", null, queryHandle, flags, dataSize, data, bytesWritten					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetPerfQueryDataINTEL: Binding for glGetPerfQueryDataINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="dataSize">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="bytesWritten">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void GetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, object data, [Out] uint[] bytesWritten)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				GetPerfQueryDataINTEL(queryHandle, flags, dataSize, pin_data.AddrOfPinnedObject(), bytesWritten);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// [GL] glGetPerfQueryIdByNameINTEL: Binding for glGetPerfQueryIdByNameINTEL.
		/// </summary>
		/// <param name="queryName">
		/// A <see cref="T:string"/>.
		/// </param>
		/// <param name="queryId">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void GetPerfQueryIdByNameINTEL(string queryName, [Out] uint[] queryId)
		{
			unsafe {
				fixed (uint* p_queryId = queryId)
				{
					Debug.Assert(Delegates.pglGetPerfQueryIdByNameINTEL != null, "pglGetPerfQueryIdByNameINTEL not implemented");
					Delegates.pglGetPerfQueryIdByNameINTEL(queryName, p_queryId);
					LogCommand("glGetPerfQueryIdByNameINTEL", null, queryName, queryId					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetPerfQueryInfoINTEL: Binding for glGetPerfQueryInfoINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="queryNameLength">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="queryName">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		/// <param name="dataSize">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="noCounters">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="noInstances">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="capsMask">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
		public static void GetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, StringBuilder queryName, [Out] uint[] dataSize, [Out] uint[] noCounters, [Out] uint[] noInstances, [Out] uint[] capsMask)
		{
			unsafe {
				fixed (uint* p_dataSize = dataSize)
				fixed (uint* p_noCounters = noCounters)
				fixed (uint* p_noInstances = noInstances)
				fixed (uint* p_capsMask = capsMask)
				{
					Debug.Assert(Delegates.pglGetPerfQueryInfoINTEL != null, "pglGetPerfQueryInfoINTEL not implemented");
					Delegates.pglGetPerfQueryInfoINTEL(queryId, queryNameLength, queryName, p_dataSize, p_noCounters, p_noInstances, p_capsMask);
					LogCommand("glGetPerfQueryInfoINTEL", null, queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glBeginPerfQueryINTEL(uint queryHandle);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glBeginPerfQueryINTEL pglBeginPerfQueryINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCreatePerfQueryINTEL(uint queryId, uint* queryHandle);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glCreatePerfQueryINTEL pglCreatePerfQueryINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeletePerfQueryINTEL(uint queryHandle);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glDeletePerfQueryINTEL pglDeletePerfQueryINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glEndPerfQueryINTEL(uint queryHandle);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glEndPerfQueryINTEL pglEndPerfQueryINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetFirstPerfQueryIdINTEL(uint* queryId);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetFirstPerfQueryIdINTEL pglGetFirstPerfQueryIdINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetNextPerfQueryIdINTEL(uint queryId, uint* nextQueryId);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetNextPerfQueryIdINTEL pglGetNextPerfQueryIdINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, StringBuilder counterName, uint counterDescLength, StringBuilder counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfCounterInfoINTEL pglGetPerfCounterInfoINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, IntPtr data, uint* bytesWritten);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfQueryDataINTEL pglGetPerfQueryDataINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetPerfQueryIdByNameINTEL(string queryName, uint* queryId);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfQueryIdByNameINTEL pglGetPerfQueryIdByNameINTEL;

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, StringBuilder queryName, uint* dataSize, uint* noCounters, uint* noInstances, uint* capsMask);

			[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfQueryInfoINTEL pglGetPerfQueryInfoINTEL;

		}
	}

}
