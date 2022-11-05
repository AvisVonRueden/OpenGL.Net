
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
		/// [GL] Value of GL_SHADING_RATE_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_shading_rate", Api = "gles2")]
		public const int SHADING_RATE_QCOM = 0x96A4;

		/// <summary>
		/// [GL] Value of GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_shading_rate", Api = "gles2")]
		public const int SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM = 0x96A5;

		/// <summary>
		/// [GL] glShadingRateQCOM: Binding for glShadingRateQCOM.
		/// </summary>
		/// <param name="rate">
		/// A <see cref="T:ShadingRateQCOM"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_shading_rate", Api = "gles2")]
		public static void ShadingQCOM(ShadingRateQCOM rate)
		{
			Debug.Assert(Delegates.pglShadingRateQCOM != null, "pglShadingRateQCOM not implemented");
			Delegates.pglShadingRateQCOM((int)rate);
			LogCommand("glShadingRateQCOM", null, rate			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_QCOM_shading_rate", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glShadingRateQCOM(int rate);

			[RequiredByFeature("GL_QCOM_shading_rate", Api = "gles2")]
			[ThreadStatic]
			internal static glShadingRateQCOM pglShadingRateQCOM;

		}
	}

}
