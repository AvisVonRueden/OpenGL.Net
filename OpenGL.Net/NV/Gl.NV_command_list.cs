
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
		/// [GL] Value of GL_TERMINATE_SEQUENCE_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int TERMINATE_SEQUENCE_COMMAND_NV = 0x0000;

		/// <summary>
		/// [GL] Value of GL_NOP_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int NOP_COMMAND_NV = 0x0001;

		/// <summary>
		/// [GL] Value of GL_DRAW_ELEMENTS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int DRAW_ELEMENTS_COMMAND_NV = 0x0002;

		/// <summary>
		/// [GL] Value of GL_DRAW_ARRAYS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int DRAW_ARRAYS_COMMAND_NV = 0x0003;

		/// <summary>
		/// [GL] Value of GL_DRAW_ELEMENTS_STRIP_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004;

		/// <summary>
		/// [GL] Value of GL_DRAW_ARRAYS_STRIP_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005;

		/// <summary>
		/// [GL] Value of GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006;

		/// <summary>
		/// [GL] Value of GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007;

		/// <summary>
		/// [GL] Value of GL_ELEMENT_ADDRESS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int ELEMENT_ADDRESS_COMMAND_NV = 0x0008;

		/// <summary>
		/// [GL] Value of GL_ATTRIBUTE_ADDRESS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009;

		/// <summary>
		/// [GL] Value of GL_UNIFORM_ADDRESS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int UNIFORM_ADDRESS_COMMAND_NV = 0x000A;

		/// <summary>
		/// [GL] Value of GL_BLEND_COLOR_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int BLEND_COLOR_COMMAND_NV = 0x000B;

		/// <summary>
		/// [GL] Value of GL_STENCIL_REF_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int STENCIL_REF_COMMAND_NV = 0x000C;

		/// <summary>
		/// [GL] Value of GL_LINE_WIDTH_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int LINE_WIDTH_COMMAND_NV = 0x000D;

		/// <summary>
		/// [GL] Value of GL_POLYGON_OFFSET_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int POLYGON_OFFSET_COMMAND_NV = 0x000E;

		/// <summary>
		/// [GL] Value of GL_ALPHA_REF_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int ALPHA_REF_COMMAND_NV = 0x000F;

		/// <summary>
		/// [GL] Value of GL_VIEWPORT_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int VIEWPORT_COMMAND_NV = 0x0010;

		/// <summary>
		/// [GL] Value of GL_SCISSOR_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int SCISSOR_COMMAND_NV = 0x0011;

		/// <summary>
		/// [GL] Value of GL_FRONT_FACE_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public const int FRONT_FACE_COMMAND_NV = 0x0012;

		/// <summary>
		/// [GL] glCreateStatesNV: Binding for glCreateStatesNV.
		/// </summary>
		/// <param name="states">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void CreateStateNV(uint[] states)
		{
			unsafe {
				fixed (uint* p_states = states)
				{
					Debug.Assert(Delegates.pglCreateStatesNV != null, "pglCreateStatesNV not implemented");
					Delegates.pglCreateStatesNV(states.Length, p_states);
					LogCommand("glCreateStatesNV", null, states.Length, states					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCreateStatesNV: Binding for glCreateStatesNV.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static uint CreateStateNV()
		{
			uint retValue;
			unsafe {
				Delegates.pglCreateStatesNV(1, &retValue);
				LogCommand("glCreateStatesNV", null, 1, "{ " + retValue + " }"				);
			}
			DebugCheckErrors(null);
			return (retValue);
		}

		/// <summary>
		/// [GL] glDeleteStatesNV: Binding for glDeleteStatesNV.
		/// </summary>
		/// <param name="states">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void DeleteStateNV(uint[] states)
		{
			unsafe {
				fixed (uint* p_states = states)
				{
					Debug.Assert(Delegates.pglDeleteStatesNV != null, "pglDeleteStatesNV not implemented");
					Delegates.pglDeleteStatesNV(states.Length, p_states);
					LogCommand("glDeleteStatesNV", null, states.Length, states					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIsStateNV: Binding for glIsStateNV.
		/// </summary>
		/// <param name="state">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static bool IsStateNV(uint state)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsStateNV != null, "pglIsStateNV not implemented");
			retValue = Delegates.pglIsStateNV(state);
			LogCommand("glIsStateNV", retValue, state			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glStateCaptureNV: Binding for glStateCaptureNV.
		/// </summary>
		/// <param name="state">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void StateCaptureNV(uint state, int mode)
		{
			Debug.Assert(Delegates.pglStateCaptureNV != null, "pglStateCaptureNV not implemented");
			Delegates.pglStateCaptureNV(state, mode);
			LogCommand("glStateCaptureNV", null, state, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetCommandHeaderNV: Binding for glGetCommandHeaderNV.
		/// </summary>
		/// <param name="tokenID">
		/// A <see cref="T:CommandOpcodesNV"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static uint GetNV(CommandOpcodesNV tokenID, uint size)
		{
			uint retValue;

			Debug.Assert(Delegates.pglGetCommandHeaderNV != null, "pglGetCommandHeaderNV not implemented");
			retValue = Delegates.pglGetCommandHeaderNV((int)tokenID, size);
			LogCommand("glGetCommandHeaderNV", retValue, tokenID, size			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glGetStageIndexNV: Binding for glGetStageIndexNV.
		/// </summary>
		/// <param name="shadertype">
		/// A <see cref="T:ShaderType"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static ushort GetStageIndexNV(ShaderType shadertype)
		{
			ushort retValue;

			Debug.Assert(Delegates.pglGetStageIndexNV != null, "pglGetStageIndexNV not implemented");
			retValue = Delegates.pglGetStageIndexNV((int)shadertype);
			LogCommand("glGetStageIndexNV", retValue, shadertype			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glDrawCommandsNV: Binding for glDrawCommandsNV.
		/// </summary>
		/// <param name="primitiveMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="indirects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void DrawCommandsNV(int primitiveMode, uint buffer, IntPtr[] indirects, int[] sizes, uint count)
		{
			unsafe {
				fixed (IntPtr* p_indirects = indirects)
				fixed (int* p_sizes = sizes)
				{
					Debug.Assert(Delegates.pglDrawCommandsNV != null, "pglDrawCommandsNV not implemented");
					Delegates.pglDrawCommandsNV(primitiveMode, buffer, p_indirects, p_sizes, count);
					LogCommand("glDrawCommandsNV", null, primitiveMode, buffer, indirects, sizes, count					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDrawCommandsAddressNV: Binding for glDrawCommandsAddressNV.
		/// </summary>
		/// <param name="primitiveMode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirects">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void DrawCommandsAddressNV(int primitiveMode, ulong[] indirects, int[] sizes, uint count)
		{
			unsafe {
				fixed (ulong* p_indirects = indirects)
				fixed (int* p_sizes = sizes)
				{
					Debug.Assert(Delegates.pglDrawCommandsAddressNV != null, "pglDrawCommandsAddressNV not implemented");
					Delegates.pglDrawCommandsAddressNV(primitiveMode, p_indirects, p_sizes, count);
					LogCommand("glDrawCommandsAddressNV", null, primitiveMode, indirects, sizes, count					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDrawCommandsStatesNV: Binding for glDrawCommandsStatesNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="indirects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="states">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="fbos">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void DrawCommandsStateNV(uint buffer, IntPtr[] indirects, int[] sizes, uint[] states, uint[] fbos, uint count)
		{
			unsafe {
				fixed (IntPtr* p_indirects = indirects)
				fixed (int* p_sizes = sizes)
				fixed (uint* p_states = states)
				fixed (uint* p_fbos = fbos)
				{
					Debug.Assert(Delegates.pglDrawCommandsStatesNV != null, "pglDrawCommandsStatesNV not implemented");
					Delegates.pglDrawCommandsStatesNV(buffer, p_indirects, p_sizes, p_states, p_fbos, count);
					LogCommand("glDrawCommandsStatesNV", null, buffer, indirects, sizes, states, fbos, count					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDrawCommandsStatesAddressNV: Binding for glDrawCommandsStatesAddressNV.
		/// </summary>
		/// <param name="indirects">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="states">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="fbos">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void DrawCommandsStatesAddresNV(ulong[] indirects, int[] sizes, uint[] states, uint[] fbos, uint count)
		{
			unsafe {
				fixed (ulong* p_indirects = indirects)
				fixed (int* p_sizes = sizes)
				fixed (uint* p_states = states)
				fixed (uint* p_fbos = fbos)
				{
					Debug.Assert(Delegates.pglDrawCommandsStatesAddressNV != null, "pglDrawCommandsStatesAddressNV not implemented");
					Delegates.pglDrawCommandsStatesAddressNV(p_indirects, p_sizes, p_states, p_fbos, count);
					LogCommand("glDrawCommandsStatesAddressNV", null, indirects, sizes, states, fbos, count					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCreateCommandListsNV: Binding for glCreateCommandListsNV.
		/// </summary>
		/// <param name="lists">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void CreateCommandListsNV(uint[] lists)
		{
			unsafe {
				fixed (uint* p_lists = lists)
				{
					Debug.Assert(Delegates.pglCreateCommandListsNV != null, "pglCreateCommandListsNV not implemented");
					Delegates.pglCreateCommandListsNV(lists.Length, p_lists);
					LogCommand("glCreateCommandListsNV", null, lists.Length, lists					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCreateCommandListsNV: Binding for glCreateCommandListsNV.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static uint CreateCommandListNV()
		{
			uint retValue;
			unsafe {
				Delegates.pglCreateCommandListsNV(1, &retValue);
				LogCommand("glCreateCommandListsNV", null, 1, "{ " + retValue + " }"				);
			}
			DebugCheckErrors(null);
			return (retValue);
		}

		/// <summary>
		/// [GL] glDeleteCommandListsNV: Binding for glDeleteCommandListsNV.
		/// </summary>
		/// <param name="lists">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void DeleteCommandListsNV(uint[] lists)
		{
			unsafe {
				fixed (uint* p_lists = lists)
				{
					Debug.Assert(Delegates.pglDeleteCommandListsNV != null, "pglDeleteCommandListsNV not implemented");
					Delegates.pglDeleteCommandListsNV(lists.Length, p_lists);
					LogCommand("glDeleteCommandListsNV", null, lists.Length, lists					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIsCommandListNV: Binding for glIsCommandListNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static bool IsCommandListNV(uint list)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsCommandListNV != null, "pglIsCommandListNV not implemented");
			retValue = Delegates.pglIsCommandListNV(list);
			LogCommand("glIsCommandListNV", retValue, list			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glListDrawCommandsStatesClientNV: Binding for glListDrawCommandsStatesClientNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="segment">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="indirects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="states">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="fbos">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void ListDrawCommandsStatesClientNV(uint list, uint segment, IntPtr[] indirects, int[] sizes, uint[] states, uint[] fbos)
		{
			unsafe {
				fixed (IntPtr* p_indirects = indirects)
				fixed (int* p_sizes = sizes)
				fixed (uint* p_states = states)
				fixed (uint* p_fbos = fbos)
				{
					Debug.Assert(Delegates.pglListDrawCommandsStatesClientNV != null, "pglListDrawCommandsStatesClientNV not implemented");
					Delegates.pglListDrawCommandsStatesClientNV(list, segment, p_indirects, p_sizes, p_states, p_fbos, (uint)indirects.Length);
					LogCommand("glListDrawCommandsStatesClientNV", null, list, segment, indirects, sizes, states, fbos, indirects.Length					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCommandListSegmentsNV: Binding for glCommandListSegmentsNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="segments">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void CommandListSegmentsNV(uint list, uint segments)
		{
			Debug.Assert(Delegates.pglCommandListSegmentsNV != null, "pglCommandListSegmentsNV not implemented");
			Delegates.pglCommandListSegmentsNV(list, segments);
			LogCommand("glCommandListSegmentsNV", null, list, segments			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCompileCommandListNV: Binding for glCompileCommandListNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void CompileCommandListNV(uint list)
		{
			Debug.Assert(Delegates.pglCompileCommandListNV != null, "pglCompileCommandListNV not implemented");
			Delegates.pglCompileCommandListNV(list);
			LogCommand("glCompileCommandListNV", null, list			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCallCommandListNV: Binding for glCallCommandListNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
		public static void CallCommandListNV(uint list)
		{
			Debug.Assert(Delegates.pglCallCommandListNV != null, "pglCallCommandListNV not implemented");
			Delegates.pglCallCommandListNV(list);
			LogCommand("glCallCommandListNV", null, list			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCreateStatesNV(int n, uint* states);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateStatesNV pglCreateStatesNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeleteStatesNV(int n, uint* states);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDeleteStatesNV pglDeleteStatesNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glIsStateNV(uint state);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glIsStateNV pglIsStateNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glStateCaptureNV(uint state, int mode);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glStateCaptureNV pglStateCaptureNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate uint glGetCommandHeaderNV(int tokenID, uint size);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetCommandHeaderNV pglGetCommandHeaderNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate ushort glGetStageIndexNV(int shadertype);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetStageIndexNV pglGetStageIndexNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDrawCommandsNV(int primitiveMode, uint buffer, IntPtr* indirects, int* sizes, uint count);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDrawCommandsNV pglDrawCommandsNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDrawCommandsAddressNV(int primitiveMode, ulong* indirects, int* sizes, uint count);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDrawCommandsAddressNV pglDrawCommandsAddressNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDrawCommandsStatesNV(uint buffer, IntPtr* indirects, int* sizes, uint* states, uint* fbos, uint count);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDrawCommandsStatesNV pglDrawCommandsStatesNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDrawCommandsStatesAddressNV(ulong* indirects, int* sizes, uint* states, uint* fbos, uint count);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDrawCommandsStatesAddressNV pglDrawCommandsStatesAddressNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCreateCommandListsNV(int n, uint* lists);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateCommandListsNV pglCreateCommandListsNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeleteCommandListsNV(int n, uint* lists);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDeleteCommandListsNV pglDeleteCommandListsNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glIsCommandListNV(uint list);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glIsCommandListNV pglIsCommandListNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glListDrawCommandsStatesClientNV(uint list, uint segment, IntPtr* indirects, int* sizes, uint* states, uint* fbos, uint count);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glListDrawCommandsStatesClientNV pglListDrawCommandsStatesClientNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCommandListSegmentsNV(uint list, uint segments);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCommandListSegmentsNV pglCommandListSegmentsNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCompileCommandListNV(uint list);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCompileCommandListNV pglCompileCommandListNV;

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCallCommandListNV(uint list);

			[RequiredByFeature("GL_NV_command_list", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCallCommandListNV pglCallCommandListNV;

		}
	}

}
