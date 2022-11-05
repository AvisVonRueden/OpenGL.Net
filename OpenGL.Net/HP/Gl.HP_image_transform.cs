
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
		/// [GL] Value of GL_IMAGE_SCALE_X_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_SCALE_X_HP = 0x8155;

		/// <summary>
		/// [GL] Value of GL_IMAGE_SCALE_Y_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_SCALE_Y_HP = 0x8156;

		/// <summary>
		/// [GL] Value of GL_IMAGE_TRANSLATE_X_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_TRANSLATE_X_HP = 0x8157;

		/// <summary>
		/// [GL] Value of GL_IMAGE_TRANSLATE_Y_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_TRANSLATE_Y_HP = 0x8158;

		/// <summary>
		/// [GL] Value of GL_IMAGE_ROTATE_ANGLE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_ROTATE_ANGLE_HP = 0x8159;

		/// <summary>
		/// [GL] Value of GL_IMAGE_ROTATE_ORIGIN_X_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_ROTATE_ORIGIN_X_HP = 0x815A;

		/// <summary>
		/// [GL] Value of GL_IMAGE_ROTATE_ORIGIN_Y_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B;

		/// <summary>
		/// [GL] Value of GL_IMAGE_MAG_FILTER_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_MAG_FILTER_HP = 0x815C;

		/// <summary>
		/// [GL] Value of GL_IMAGE_MIN_FILTER_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_MIN_FILTER_HP = 0x815D;

		/// <summary>
		/// [GL] Value of GL_IMAGE_CUBIC_WEIGHT_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_CUBIC_WEIGHT_HP = 0x815E;

		/// <summary>
		/// [GL] Value of GL_CUBIC_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int CUBIC_HP = 0x815F;

		/// <summary>
		/// [GL] Value of GL_AVERAGE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int AVERAGE_HP = 0x8160;

		/// <summary>
		/// [GL] Value of GL_IMAGE_TRANSFORM_2D_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_TRANSFORM_2D_HP = 0x8161;

		/// <summary>
		/// [GL] Value of GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162;

		/// <summary>
		/// [GL] Value of GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163;

		/// <summary>
		/// [GL] glImageTransformParameteriHP: Binding for glImageTransformParameteriHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ImageTransformTargetHP"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ImageTransformPNameHP"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void ImageTransformParameterHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int param)
		{
			Debug.Assert(Delegates.pglImageTransformParameteriHP != null, "pglImageTransformParameteriHP not implemented");
			Delegates.pglImageTransformParameteriHP((int)target, (int)pname, param);
			LogCommand("glImageTransformParameteriHP", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glImageTransformParameterfHP: Binding for glImageTransformParameterfHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ImageTransformTargetHP"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ImageTransformPNameHP"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void ImageTransformParameterHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float param)
		{
			Debug.Assert(Delegates.pglImageTransformParameterfHP != null, "pglImageTransformParameterfHP not implemented");
			Delegates.pglImageTransformParameterfHP((int)target, (int)pname, param);
			LogCommand("glImageTransformParameterfHP", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glImageTransformParameterivHP: Binding for glImageTransformParameterivHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ImageTransformTargetHP"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ImageTransformPNameHP"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void ImageTransformParameterHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglImageTransformParameterivHP != null, "pglImageTransformParameterivHP not implemented");
					Delegates.pglImageTransformParameterivHP((int)target, (int)pname, p_params);
					LogCommand("glImageTransformParameterivHP", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glImageTransformParameterfvHP: Binding for glImageTransformParameterfvHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ImageTransformTargetHP"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ImageTransformPNameHP"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void ImageTransformParameterHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglImageTransformParameterfvHP != null, "pglImageTransformParameterfvHP not implemented");
					Delegates.pglImageTransformParameterfvHP((int)target, (int)pname, p_params);
					LogCommand("glImageTransformParameterfvHP", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetImageTransformParameterivHP: Binding for glGetImageTransformParameterivHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ImageTransformTargetHP"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ImageTransformPNameHP"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void GetImageTransformParameterHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetImageTransformParameterivHP != null, "pglGetImageTransformParameterivHP not implemented");
					Delegates.pglGetImageTransformParameterivHP((int)target, (int)pname, p_params);
					LogCommand("glGetImageTransformParameterivHP", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetImageTransformParameterfvHP: Binding for glGetImageTransformParameterfvHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ImageTransformTargetHP"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ImageTransformPNameHP"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void GetImageTransformParameterHP(ImageTransformTargetHP target, ImageTransformPNameHP pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetImageTransformParameterfvHP != null, "pglGetImageTransformParameterfvHP not implemented");
					Delegates.pglGetImageTransformParameterfvHP((int)target, (int)pname, p_params);
					LogCommand("glGetImageTransformParameterfvHP", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_HP_image_transform")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glImageTransformParameteriHP(int target, int pname, int param);

			[RequiredByFeature("GL_HP_image_transform")]
			[ThreadStatic]
			internal static glImageTransformParameteriHP pglImageTransformParameteriHP;

			[RequiredByFeature("GL_HP_image_transform")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glImageTransformParameterfHP(int target, int pname, float param);

			[RequiredByFeature("GL_HP_image_transform")]
			[ThreadStatic]
			internal static glImageTransformParameterfHP pglImageTransformParameterfHP;

			[RequiredByFeature("GL_HP_image_transform")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glImageTransformParameterivHP(int target, int pname, int* @params);

			[RequiredByFeature("GL_HP_image_transform")]
			[ThreadStatic]
			internal static glImageTransformParameterivHP pglImageTransformParameterivHP;

			[RequiredByFeature("GL_HP_image_transform")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glImageTransformParameterfvHP(int target, int pname, float* @params);

			[RequiredByFeature("GL_HP_image_transform")]
			[ThreadStatic]
			internal static glImageTransformParameterfvHP pglImageTransformParameterfvHP;

			[RequiredByFeature("GL_HP_image_transform")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetImageTransformParameterivHP(int target, int pname, int* @params);

			[RequiredByFeature("GL_HP_image_transform")]
			[ThreadStatic]
			internal static glGetImageTransformParameterivHP pglGetImageTransformParameterivHP;

			[RequiredByFeature("GL_HP_image_transform")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetImageTransformParameterfvHP(int target, int pname, float* @params);

			[RequiredByFeature("GL_HP_image_transform")]
			[ThreadStatic]
			internal static glGetImageTransformParameterfvHP pglGetImageTransformParameterfvHP;

		}
	}

}
