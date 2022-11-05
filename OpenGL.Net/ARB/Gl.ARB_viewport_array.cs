
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
		/// [GL] glDepthRangeArraydvNV: Binding for glDepthRangeArraydvNV.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		public static void DepthRangeArraydNV(uint first, int count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArraydvNV != null, "pglDepthRangeArraydvNV not implemented");
					Delegates.pglDepthRangeArraydvNV(first, count, p_v);
					LogCommand("glDepthRangeArraydvNV", null, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDepthRangeIndexeddNV: Binding for glDepthRangeIndexeddNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		public static void DepthRangeIndexeddNV(uint index, double n, double f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexeddNV != null, "pglDepthRangeIndexeddNV not implemented");
			Delegates.pglDepthRangeIndexeddNV(index, n, f);
			LogCommand("glDepthRangeIndexeddNV", null, index, n, f			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDepthRangeArraydvNV(uint first, int count, double* v);

			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDepthRangeArraydvNV pglDepthRangeArraydvNV;

			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDepthRangeIndexeddNV(uint index, double n, double f);

			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDepthRangeIndexeddNV pglDepthRangeIndexeddNV;

		}
	}

}
