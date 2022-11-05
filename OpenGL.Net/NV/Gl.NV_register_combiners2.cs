
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
		/// [GL] Value of GL_PER_STAGE_CONSTANTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_register_combiners2")]
		public const int PER_STAGE_CONSTANTS_NV = 0x8535;

		/// <summary>
		/// [GL] glCombinerStageParameterfvNV: Binding for glCombinerStageParameterfvNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:CombinerStageNV"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:CombinerParameterNV"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners2")]
		public static void CombinerStageParameterNV(CombinerStageNV stage, CombinerParameterNV pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglCombinerStageParameterfvNV != null, "pglCombinerStageParameterfvNV not implemented");
					Delegates.pglCombinerStageParameterfvNV((int)stage, (int)pname, p_params);
					LogCommand("glCombinerStageParameterfvNV", null, stage, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetCombinerStageParameterfvNV: Binding for glGetCombinerStageParameterfvNV.
		/// </summary>
		/// <param name="stage">
		/// A <see cref="T:CombinerStageNV"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:CombinerParameterNV"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_register_combiners2")]
		public static void GetCombinerStageParameterNV(CombinerStageNV stage, CombinerParameterNV pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetCombinerStageParameterfvNV != null, "pglGetCombinerStageParameterfvNV not implemented");
					Delegates.pglGetCombinerStageParameterfvNV((int)stage, (int)pname, p_params);
					LogCommand("glGetCombinerStageParameterfvNV", null, stage, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NV_register_combiners2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCombinerStageParameterfvNV(int stage, int pname, float* @params);

			[RequiredByFeature("GL_NV_register_combiners2")]
			[ThreadStatic]
			internal static glCombinerStageParameterfvNV pglCombinerStageParameterfvNV;

			[RequiredByFeature("GL_NV_register_combiners2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetCombinerStageParameterfvNV(int stage, int pname, float* @params);

			[RequiredByFeature("GL_NV_register_combiners2")]
			[ThreadStatic]
			internal static glGetCombinerStageParameterfvNV pglGetCombinerStageParameterfvNV;

		}
	}

}
